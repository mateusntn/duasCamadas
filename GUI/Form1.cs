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
using DAL;
using Models;

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
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Create(laptop: new Laptop(txtBrand.Text, int.Parse(txtRam.Text), int.Parse(txtStorage.Text)));
                ListLaptops();
                MessageBox.Show(text: $"Notebook {txtBrand.Text} de {txtRam.Text}GB de RAM e {txtStorage.Text} de armazenamento foi adicionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: $"Ocorreu um erro: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListLaptops();
        }

        private void ListLaptops()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                gridLaptops.DataSource = null;
                gridLaptops.DataSource = rep.List();
                gridLaptops.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
