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
    public partial class FormEjercicio3 : Form
    {
        public FormEjercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrarSeleccionado_Click(object sender, EventArgs e)
        {
            /// Variable que guarda mensaje para mostrar por el label
            String salida;
            /// Se va agregando al mensaje lo seleccionado en los group box
            salida = "Usted seleccionó los siguientes elementos:" + "\r\n";
            salida += "Sexo: " + (string)(rbtnFemenino.Checked ? "Femenino" : "Masculino") + "\r\n";
            salida += "Estado Civil: " + (string)(rbtnCasado.Checked ? "Casado" : "Soltero") + "\r\n";
            salida += "Oficio:" + "\r\n";
            /// Se va agregando al mensaje lo que esta seleccionado en el checked list box
            foreach(string item in clbxRubros.CheckedItems)
            {
                salida += "   -" + item.ToString() + "\r\n";
            }

            /// Se asigno el mensaje al lebel
            lblSeleccionado.Text = salida;
        }
    }
}
