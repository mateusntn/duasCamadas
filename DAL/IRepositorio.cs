using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositorio
    {
        void Create(Laptop laptop);
        void Delete(string brand);
        Laptop Consult(string brand);
        List<Laptop> List();


    }
}
