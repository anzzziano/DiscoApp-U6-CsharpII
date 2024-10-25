using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        private List<Disco> listaDeDisco;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DiscoData dataDisc = new DiscoData();
            listaDeDisco = dataDisc.listar();
            dGVWindowIndex.DataSource = listaDeDisco;
            dGVWindowIndex.Columns["UrlImagenTapa"].Visible = false;
            loadImage(listaDeDisco[0].UrlImagenTapa);

        }

        private void btnRegresarFormDB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVWindowIndex_SelectionChanged(object sender, EventArgs e)
        {
            Disco discoSeleccionado = (Disco)dGVWindowIndex.CurrentRow.DataBoundItem;
            loadImage(discoSeleccionado.UrlImagenTapa);
        }

        private void loadImage(string image)
        {
            try
            {
                pictureBox1.Load(image);
            }
            catch (Exception ex)
            {
                pictureBox1.Load("https://t4.ftcdn.net/jpg/06/71/92/37/360_F_671923740_x0zOL3OIuUAnSF6sr7PuznCI5bQFKhI0.jpg");
            }
        }

    }
}
