using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Bunun adı Generic Repository Design Pattern
    public interface IEntityRepository<T> where T:class,IEntity,new()//Generic Constraint
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filter=null filtresizde olabilir demek filtre vermezsek hepsini getir.
        T Get(Expression<Func<T, bool>> filter);//Parantez içindeki LINQ aslında filtreleme yapmamızı sağlıyo, Burada null yazmadık filtre mecburi.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
