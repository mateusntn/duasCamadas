using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
                MySqlConnection connection = new MySqlConnection(connectionString: "server=localhost;user id=root;pwd=7890;database=duas_camadas;allowuservariables=True");
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(cmdText: $"INSERT INTO laptops (brand, ram, storage) values ('{txtBrand.Text}', '{txtRam.Text}', '{txtStorage.Text}')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(text: "Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: "Ocorreu um erro ao tentar salvar.");
            }
            finally { connection.Close(); }
            
        }
    }
}
