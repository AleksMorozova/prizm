using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using Ninject;
using Prizm.Data.DAL.Synch;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{

    public class PortionRepository : AbstractHibernateRepository<Guid, Portion>, IPortionRepository
    {
        [Inject]
        public PortionRepository(ISession session)
            : base(session)
        {
        }
        public int GetPortionNumber(Project currentProject)
        {
            var maxIndex = session.QueryOver<Portion>()
                .Where(x => x.IsExport)
                .Where(x => x.Project == currentProject)
                .Select
                (
                Projections.Max<Portion>(x => x.PortionNumber)
                ).SingleOrDefault<int>();
            return maxIndex + 1;

        }

        public List<int> CheckPortionSequence(Project importProject)
        {
            IList<int> result = session.QueryOver<Portion>().Where(_ => !_.IsExport && _.Project == importProject)
                                                                   .Select(_ => _.PortionNumber).List<int>();
            List<int> sorted = new List<int>(result);
            sorted.Sort();

            return (result.Count == 0) ? new List<int>() { 0 } : sorted;

        }

        public override IList<Portion> GetAll()
        {
            try
            {
                Portion portionAlias = null;
                Project projectAlias = null;
                FlatPortionDTO dto = null;

                var q = session.QueryOver<Portion>(() => portionAlias)
                    .JoinAlias(p => p.Project, () => projectAlias, JoinType.LeftOuterJoin)
                    .SelectList(list => list
                        .Select(x => x.Id).WithAlias(() => dto.Id)
                        .Select(x => x.ExportDateTime).WithAlias(() => dto.ExportDateTime)
                        .Select(x => x.IsExport).WithAlias(() => dto.IsExport)
                        .Select(x => x.PortionNumber).WithAlias(() => dto.PortionNumber)

                        .Select(x => projectAlias.Title).WithAlias(() => dto.Title)
                        .Select(x => projectAlias.Client).WithAlias(() => dto.Client)
                        .Select(x => projectAlias.MillName).WithAlias(() => dto.MillName)
                        .Select(x => projectAlias.DocumentSizeLimit).WithAlias(() => dto.DocumentSizeLimit)
                        .Select(x => projectAlias.WorkstationType).WithAlias(() => dto.WorkstationType)
                        .Select(x => projectAlias.MillPipeNumberMask).WithAlias(() => dto.MillPipeNumberMask)
                        .Select(x => projectAlias.MillPipeNumberMaskRegexp).WithAlias(() => dto.MillPipeNumberMaskRegexp)
                        .Select(x => projectAlias.IsNative).WithAlias(() => dto.IsNative)
                    )
                    .TransformUsing(Transformers.AliasToBean<FlatPortionDTO>())
                    .List<FlatPortionDTO>();

                var portions = new List<Portion>();

                foreach(var item in q)
                {
                    portions.Add(new Portion
                    {
                        Id = item.Id,
                        ExportDateTime = item.ExportDateTime,
                        IsExport = item.IsExport,
                        PortionNumber = item.PortionNumber,
                        Project = new Project 
                        { 
                            Title = item.Title,
                            Client = item.Client,
                            MillName = item.MillName,
                            DocumentSizeLimit = item.DocumentSizeLimit,
                            WorkstationType = item.WorkstationType,
                            MillPipeNumberMask = item.MillPipeNumberMask,
                            MillPipeNumberMaskRegexp = item.MillPipeNumberMaskRegexp,
                            IsNative = item.IsNative
                        }
                    });
                }

                return portions;
               
            }
            catch(GenericADOException ex)
            {
                throw new RepositoryException("GetAll", ex);
            }
        }
    }

    private class FlatPortionDTO
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime ExportDateTime { get; set; }
        public virtual bool IsExport { get; set; }
        public virtual int PortionNumber { get; set; }

        public virtual string Title { get; set; }
        public virtual string Client { get; set; }
        public virtual string MillName { get; set; }
        public virtual int DocumentSizeLimit { get; set; }
        public virtual WorkstationType WorkstationType { get; set; }
        public virtual string MillPipeNumberMask { get; set; }
        public virtual string MillPipeNumberMaskRegexp { get; set; }
        public virtual bool IsNative { get; set; }
    }
}
