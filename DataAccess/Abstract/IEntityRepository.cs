using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()

        //Since all of these operations could be used for different entities, a "Generic" type was done.
        //If a different entity is added to the program later, it is enough for us to send the relevant entity instead of "T" to apply the methods in it.
        //Generic constraints were applied in the "where" section to be used with classes referenced to the IEntity.
    {
        List<T> GetAll(); 
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
