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
    public partial class FormEjercicio2 : Form
    {
        public FormEjercicio2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /// pregunta si se ingesa o no datos y segun lo que falte avisa
            bool hayTexto = true;
            if (txtNombre.Text.Trim() == "" && txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("No se ingreso Nombre ni Apellido");
                hayTexto = false;
            }
            else
            {
                if (txtNombre.Text.Trim() == "" && hayTexto == true)
                {
                    MessageBox.Show("No se ingreso Nombre");
                    hayTexto = false;
                }
                if (txtApellido.Text.Trim() == "" && hayTexto == true)
                {
                    MessageBox.Show("No se ingreso Apellido");
                    hayTexto = false;
                }
            }
                                                                                        

            ///////////////////////// Pasar el nombre y apellido al lxbNombres

            // Se toma el campo nombre y apellido ya validado y se pasa al campo elementos
            // Antes de agregar al ListBox elementos verifico que no se repita
            Boolean noEsta = true;
            foreach(String apellidoYNombre in lbxElementos.Items)
            {
                if((txtApellido.Text.ToUpper().Trim()+" "+txtNombre.Text.ToUpper().Trim()) == apellidoYNombre.ToString().ToUpper())
                {
                    noEsta = false;
                }
            }

            /// Veo si los campos nombres y apellido tienen texto y si ya esta en la lista de elementos
            if(hayTexto && noEsta)
            {
                lbxElementos.Items.Add(txtApellido.Text.Trim() + " " + txtNombre.Text.Trim());
            }
            else
            {
                /// si esta repetido aviso por mensaje en pantalla
                if(!noEsta)
                {
                    MessageBox.Show(txtApellido.Text.Trim() + " " + txtNombre.Text.Trim() + " ya se agrego", "Apellido y Nombre");
                }
            }

            // Se limpian los campos nombre y apellido
            txtApellido.Clear();
            txtNombre.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbxElementos.SelectedIndex != -1)
            {
                lbxElementos.Items.RemoveAt(lbxElementos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un objeto el cual eliminar");
            }
        }
    }
}
