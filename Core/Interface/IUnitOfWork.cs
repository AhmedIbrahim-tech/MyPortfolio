using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface
{
    public interface IUnitOfWork<T> where T : class
    {
        IAllFunction<T> Entity { get; }
        void Save();
    }
}
