using Data.DAL.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Component
{
    public interface IComponentRepositories : IDisposable
    {
        IComponentRepository ComponentRepo { get; }
        IComponentTypeRepository ComponentTypeRepo { get; }

        void Commit();
        void BeginTransaction();
    }
}
