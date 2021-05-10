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
    }
}
