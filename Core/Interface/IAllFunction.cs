using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interface
{
    public interface IAllFunction<T> where T : class
    {
        List<T> Find();
        T Details(object id);
        void Create(T entitiy);
        void Edit(T entitiy);
        void Delete(object id);
    }


    /// <summary>
    /// Mohamed Elbahrawy
    /// </summary>
    //interface AllFunction<TClass>
    //{
    //    List<TClass> Find();
    //    void Create(TClass tclass);
    //    TClass Details(int id);
    //    void Edit(TClass tclass);
    //    void Delete(TClass tclass);
    //}


    /// <summary>
    /// Khalid ESSAADANI
    /// </summary>
    //interface AllAllFunction<T> where T : class
    //{
    //    IEnumerable<T> GetAll();
    //    T GetbyId(object id);
    //    void Create(T entity);
    //    void Edit(T entity);
    //    void Delete(object id);
    //}



}
