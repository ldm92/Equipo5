using Equipo5.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipo5.Data.Services;

namespace Equipo5.Business
{
    public class CategoryBiz
    {
        public void Agregar(Category model)
        {
            var db = new BaseDataService<Category>();
            db.Create(model);

        }

        public List<Category> Listar()
        {
            var db = new BaseDataService<Category>();
            var lista = db.Get();
            
            return lista;
        }

        /*public int Buscar()
        {
            var db = new BaseDataService<Category>();
            var id = db.Get();

            return lista;
        }*/

        public Category Get(int id)
        {
            var db = new BaseDataService<Category>();
            return db.GetById(id);
        }

        public void Eliminar(Category model)
        {
            var db = new BaseDataService<Category>();
            db.Delete(model);
        }

        public void Modificar(Category model)
        {
            var db = new BaseDataService<Category>();
            db.Update(model);
        }
    }
}
