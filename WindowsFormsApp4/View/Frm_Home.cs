using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.View;

namespace WindowsFormsApp4
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar cadastrar = new Frm_Cadastrar();
            this.Hide();
            cadastrar.Show();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Frm_Buscar buscar = new Frm_Buscar();
            this.Hide();
            buscar.Show();
        }
    }
}
