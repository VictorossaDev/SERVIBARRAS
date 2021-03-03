using System;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace SERVIBARRAS.AccesoDatos.Data.Repository
{

    // Implementa una clase generica
    public interface IRepository<T> where T : class
    {
        // Metodo que recibe por parametro el id que es un int para optener un registro
        T Get(int id);

        // Metodo que retorna todos los metodos de una entidad, devuelve todos los que encuentre
       // El includeProperties = null lo podemos variar en caso de que queramos que se incluya lo relacionado
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
         );
 
        // Trae el primero o por defecto
        T GetFirstOrDefault(
          Expression<Func<T, bool>> filter = null,
           string includeProperties = null
        );

        // Agregar una entidad
        void Add(T entity);

        // Eliminar una entidad por parametro o identificador unico
        void Remove(int id);

        // Eliminar una entidad pasandole la entidad completa
        void Remove(T entity);
    }
}
