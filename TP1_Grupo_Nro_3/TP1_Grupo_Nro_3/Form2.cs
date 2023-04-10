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
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /// veo si esta en la lista nombres izquierda
            Boolean esta = false;
            foreach(String aux in lbxNombresIzquierda.Items)
            {
                /// Se le quitan los espacion en blanco al nombre ingresado y se le compara con los de la lista
                /// Si son iguales se cambia el valor de la variable estado
                if(aux.Trim() == txtNombre.Text.Trim())
                {
                    esta = true;
                } 
                /// Lo mismo que antes pero poniendolos en mayusculas
                if(aux.ToUpper() == txtNombre.Text.ToUpper())
                {
                    esta = true;
                }
            }
            /// Veo si esta en blanco text box nombre y/ en la lista izquierda
            /// segun el caso se avisa que pasa o se agrega
            if (txtNombre.Text.Trim() != "" && !esta)
            {
                lbxNombresIzquierda.Items.Add(txtNombre.Text);
            }
            else
            {
                if(txtNombre.Text.Trim() != "")
                {
                    /// Ya esta en la lista izquierda
                    MessageBox.Show("El nombre ya esta en la lista", "Nombre");
                }
                else
                {
                    /// Esta  en blanco text box nombre
                    MessageBox.Show("Debe ingresar un nombre", "Nombre");
                }
            }
            /// limpio text box nombre
            txtNombre.Text = "";
        }

        private void btnSeleccionado_Click(object sender, EventArgs e)
        {
            if (lbxNombresIzquierda.SelectedIndex >= 0) /// se validad la selección = -1 (no se selecciono ningún item),
            {                                           /// 0 en adelante (se selecciono algun item del ListoBox)

                lbxNombresDerecha.Items.Add(lbxNombresIzquierda.SelectedItem); /// se agrega el item en lbxNombresDerecha
                lbxNombresIzquierda.Items.Remove(lbxNombresIzquierda.SelectedItem); /// se elimina el item de lbxNombresIzquierda
            }
            else MessageBox.Show("Debe seleccionar un nombre de la lista"); /// en caso de no haber selección se muestra un messageBox
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            // Se toman todos los elementos de lbxNombresIzquierda y los agrega a la lbxNombresDerecha
            lbxNombresDerecha.Items.AddRange(lbxNombresIzquierda.Items);
            // Se eliminan todos los items de lbxNombresIzquierda
            lbxNombresIzquierda.Items.Clear();
        }
    }
}
