using System;
using System.Collections.Generic;
using System.Text;

namespace KluCareer.DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        bool Commit(bool state = true);
    }
}
