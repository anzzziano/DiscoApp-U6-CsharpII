using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Negocio;

namespace WinFormsApp1
{
    public partial class WindowIndexForm : Form
    {
        public WindowIndexForm()
        {
            InitializeComponent();
        }

        private void verDiscosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {

                if (item.GetType() == typeof(Form2))
                {
                    MessageBox.Show("ya esta una ventana abierta");
                    return;
                }
            }

            Form2 windowViewFormDB = new Form2();
            windowViewFormDB.Show();
        }

        private void buttonCloseWindowIndex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verEstilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {

                if (item.GetType() == typeof(Form3))
                {
                    MessageBox.Show("ya esta una ventana abierta");
                    return;
                }
            }

            Form3 windowViewFormDB = new Form3();
            windowViewFormDB.Show();
        }

        private void verEdicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {

                if (item.GetType() == typeof(Form4))
                {
                    MessageBox.Show("ya esta una ventana abierta");
                    return;
                }
            }

            Form4 windowViewFormDB = new Form4();
            windowViewFormDB.Show();
        }
    }
}
