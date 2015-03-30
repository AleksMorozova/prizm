using NHibernate;
using NHibernate.Transform;
using Ninject;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{
    public class SelectiveNotificationRepository
    {
        protected readonly ISession session;
        [Inject]
        public SelectiveNotificationRepository(ISession session)
        { 
            this.session = session; 
        }

        public IList<SelectiveOperation> GetAllSelectiveOperation()
        {
            var query = session.CreateSQLQuery(
                @"select pmst.id, ptr.pipeTestId, pt.code, pt.name, pmst.[type], pt.selectivePercent, count(ptr.pipeId) as pipesCount from PipeTestResult  ptr 
                  inner join PipeTest  pt  on ptr.pipeTestId = pt.Id 
                  inner join Pipe p on ptr.pipeId = p.id
                  inner join PipeMillSizeType pmst on pt.pipeMillSizeTypeId = pmst.id
                  where pt.isActive = 1
                  AND p.isActive = 1
                  AND pt.frequencyType = '"+ InspectionFrequencyType.S.ToString()+@"'
                  Group by pmst.id, ptr.pipeTestId, pt.code, pt.name,pmst.[type], pt.name, pt.selectivePercent "
                ).SetResultTransformer(SelectiveOperationQuery.Transformer);
            var results = query.List<SelectiveOperation>();
            return results;        
        }

        public  IList<KeyValuePair<Guid, int>> GetPipesCountPerMillSizeType()
        {
            var query = session.CreateSQLQuery
                (@" select typeId, count(id) from pipe
             where isActive = 1 
             group by typeId");
            var results = query.List<KeyValuePair<Guid, int>>();
            return results;
        }

        private class SelectiveOperationQuery : IResultTransformer
        {
            public static readonly SelectiveOperationQuery Transformer = new SelectiveOperationQuery();
            private SelectiveOperationQuery () { }
            #region IResultTransformer Members

            public IList TransformList(IList collection)
            {
                return collection;
            }

            public object TransformTuple(object[] tuple, string[] aliases)
            {

                return new SelectiveOperation()
                {
                    PipeSizeTypeId = (Guid)tuple[0],
                    OperationId = (Guid)tuple[1],
                    OperationCode = tuple[2].ToString(),
                    OperationName = tuple[3].ToString(),
                    PipeSizeTypeName = tuple[4].ToString(),
                    SelectivePercent = (int)tuple[5],
                    PipesCount = (int)tuple[6]
                };
            }
            #endregion
        }
    }
}
