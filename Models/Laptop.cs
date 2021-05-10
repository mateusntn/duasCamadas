using System;

namespace Models
{
    public class Laptop
    {
        private int id;
        private string brand;
        private int ram;
        private int storage;

        public Laptop() { }
        public Laptop(string brand, int ram, int storage)
        {
            Brand = brand;
            Ram = ram;
            Storage = storage;
        }

        public Laptop(int id, string brand, int ram, int storage) : this(brand, ram, storage)
        {
            Id = id;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value.ToUpper();
            }
        }

        public int Ram
        {
            get
            {
                return ram;
            }

            set
            {
                ram = value;
            }
        }

        public int Storage
        {
            get
            {
                return storage;
            }

            set
            {
                storage = value;
            }
        }
    }
}
