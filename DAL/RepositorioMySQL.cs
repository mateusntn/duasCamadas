using Models;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class RepositorioMySQL
    {
        public void Create(Laptop laptop)
        {
            MySqlConnection connection = new MySqlConnection(connectionString: "server=localhost;user id=root;pwd=7890;database=duas_camadas;allowuservariables=True");
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText: $"INSERT INTO laptops (brand, ram, storage) values (@Brand, @Ram, @Storage)", connection);
                cmd.Parameters.AddWithValue(parameterName: "@Brand", laptop.Brand);
                cmd.Parameters.AddWithValue(parameterName: "@Ram", laptop.Ram);
                cmd.Parameters.AddWithValue(parameterName: "@Storage", laptop.Storage);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { connection.Close(); }
        }

        public void Delete(string v)
        {
            throw new NotImplementedException();
        }

        public Laptop Consult(string brand)
        {
            Laptop lap = null;
            MySqlConnection connection = new MySqlConnection(connectionString: "server=localhost;user id=root;pwd=7890;database=duas_camadas;allowuservariables=True");
            MySqlDataReader dr = null;
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText: $"SELECT * FROM laptops WHERE brand like @Brand", connection);
                cmd.Parameters.AddWithValue(parameterName: "@Brand", brand);
                dr = cmd.ExecuteReader();
                lap = new Laptop();
                while (dr.Read())
                {
                    lap.Id = dr.GetInt32(column: "Id");
                    lap.Brand = dr.GetString(column: "Brand");
                    lap.Ram = dr.GetInt32(column: "Ram");
                    lap.Storage = dr.GetInt32(column: "Storage");
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                if (dr != null)
                {
                    dr.Close();
                }
            }

            return lap;
        }
    }
}
