using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Grupo_Nro_3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            FormEjercicio1 f1 = new FormEjercicio1();
            f1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            FormEjercicio2 f2 = new FormEjercicio2();
            f2.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 f3 = new FormEjercicio3();
            f3.Show();        
        }
    }
}
