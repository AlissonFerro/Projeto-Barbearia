using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.View
{
    public partial class Frm_Buscar : Form
    {
        public Frm_Buscar()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DBService.FindByName(Txt_Input.Text);
            Lst_Lista.Items.Add(DBService.clientes[0].Nome);
        }
    }
}
