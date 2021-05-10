using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class RepositorioMySQL : IRepositorio
    {
        private readonly string connectionString = "server=localhost;user id=root;pwd=7890;database=duas_camadas;allowuservariables=True";

        private void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
        {
            MySqlConnection connection = GetConnection();
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                foreach(MySqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { connection.Close(); }
        }
        public void Create(Laptop laptop)
        {
            try
            {
                ExecuteNonQuery(
                    $"INSERT INTO laptops (brand, ram, storage) values (@Brand, @Ram, @Storage)",
                    new MySqlParameter("@Brand", laptop.Brand),
                    new MySqlParameter("@Ram", laptop.Ram),
                    new MySqlParameter("@Storage", laptop.Storage)
                );

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string brand)
        {
            try
            {
                ExecuteNonQuery(
                    $"DELETE FROM laptops WHERE brand = @Brand",
                    new MySqlParameter("@Brand", brand)
                );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Laptop Consult(string brand)
        {
            Laptop lap = null;
            MySqlConnection connection = GetConnection();
            MySqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(
                    connection, 
                    $"SELECT * FROM laptops WHERE brand like @Brand", 
                    new MySqlParameter("@Brand", brand)
                );
                while (dr.Read())
                {
                    lap = new Laptop(
                        dr.GetInt32(column: "Id"), 
                        dr.GetString(column: "Brand"), 
                        dr.GetInt32(column: "Ram"), 
                        dr.GetInt32(column: "Storage")
                    );
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnectionAndDataReader(connection, dr);
            }

            return lap;
        }

        public List<Laptop> List()
        {
            List<Laptop> laptops = null;
            MySqlConnection connection = GetConnection();
            MySqlDataReader dr = null;
            try
            {
                dr = ExecuteReader(connection, $"SELECT * FROM laptops");
                if (dr.HasRows)
                {
                    laptops = new List<Laptop>();
                    while (dr.Read())
                    {
                        laptops.Add(new Laptop(
                                            dr.GetInt32("Id"), 
                                            dr.GetString("Brand"), 
                                            dr.GetInt32("Ram"), 
                                            dr.GetInt32("Storage")
                                    ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnectionAndDataReader(connection, dr);
            }

            return laptops;
        }

        private static void CloseConnectionAndDataReader(MySqlConnection connection, MySqlDataReader dr)
        {
            connection.Close();
            if (dr != null)
            {
                dr.Close();
            }
        }

        private static MySqlDataReader ExecuteReader(MySqlConnection connection, string sql, params MySqlParameter[] parameters)
        {
            MySqlDataReader dr;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            foreach (MySqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            dr = cmd.ExecuteReader();
            return dr;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
