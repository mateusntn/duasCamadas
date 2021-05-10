using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;

namespace TestLaptop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateLaptop()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Create(new Laptop("Dell Latitude 5410", 16 , 500));
                
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(rep.Consult("Dell Latitude 5410"));

        }

        [TestMethod]
        public void DeleteLaptop()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Delete("Dell Latitude 5410");

            }
            catch (Exception ex)
            {

            }
            Assert.IsNull(rep.Consult("Dell Latitude 5410"));

        }

        [TestMethod]
        public void ConsultLaptop()
        {
            Laptop lap = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                lap = rep.Consult("Lenovo");

            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(lap);

        }

        [TestMethod]
        public void ListLaptops()
        {
            List<Laptop> laptops = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                laptops = rep.List();

            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(laptops);

        }
    }
}
