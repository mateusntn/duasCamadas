using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioEntity : IRepositorio
    {
        private RepositorioContext db = new RepositorioContext();
        public Laptop Consult(string brand)
        {
            return db.Laptops.First<Laptop>(c => c.Brand == brand);
        }

        public void Create(Laptop laptop)
        {
            db.Laptops.Add(laptop);
            db.SaveChanges();
        }

        public void Delete(string brand)
        {
            throw new NotImplementedException();
        }

        public List<Laptop> List()
        {
            throw new NotImplementedException();
        }
    }
}
