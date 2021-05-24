using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaptop
{
    [TestClass]
    public class TestDBEntity
    {
        [TestMethod]
        public void CreateLaptop()
        {
            IRepositorio rep = new RepositorioEntity();
            try
            {
                rep.Create(new Laptop("Dell Latitude 5410", 16, 500));

            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(rep.Consult("Dell Latitude 5410"));
        }
    }
}
