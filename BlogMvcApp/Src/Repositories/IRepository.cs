using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Repositories
{
    //T=Comment
    public interface IRepository<T>
    {
        T Find(string Id);
        List<T> List();
        void Add(T entity);
        void Update(T entity);
        void Delete(string Id);

    }
}
