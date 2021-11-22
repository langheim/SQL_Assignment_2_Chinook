using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SQL_Assignment_2_Chinook.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Generic interface with TEntity class set. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //Get generic objects based on ID
        TEntity Get(int id);
        //Get all generic objects
        IEnumerable<TEntity> GetAll();
        //Get all with input offset
        IEnumerable<TEntity> GetOffset(int offset, int amount);
        //Find with a predicate of Func
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        //Add object
        void Add(TEntity entity);
        //Add range of objects
        void AddRange(IEnumerable<TEntity> entities);
        //Remove object
        void Remove(TEntity entity);
        //Remove range of obects
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
