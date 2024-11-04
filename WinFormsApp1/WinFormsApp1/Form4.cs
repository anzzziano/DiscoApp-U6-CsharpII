using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private List<Edicion> listaDeEdicion;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            EdicionData edicionData = new EdicionData();
            listaDeEdicion = edicionData.listar();
            dataGridView1.DataSource = listaDeEdicion;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
