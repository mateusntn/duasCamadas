using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;

namespace TestLaptop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateLaptop()
        {
            RepositorioMySQL rep = new RepositorioMySQL();
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
            RepositorioMySQL rep = new RepositorioMySQL();
            try
            {
                rep.Delete("Dell");

            }
            catch (Exception ex)
            {

            }
            Assert.IsNull(rep.Consult("Dell"));

        }

        [TestMethod]
        public void ConsultLaptop()
        {
            Laptop lap = null;
            RepositorioMySQL rep = new RepositorioMySQL();
            try
            {
                lap = rep.Consult("Dell");

            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(lap);

        }
    }
}
