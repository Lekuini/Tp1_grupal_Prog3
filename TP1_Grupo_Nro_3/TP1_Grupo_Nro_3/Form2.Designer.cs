
namespace TP1_Grupo_Nro_3
{
    partial class FormEjercicio1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIngresarNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.lbxNombresIzquierda = new System.Windows.Forms.ListBox();
            this.lbxNombresDerecha = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblIngresarNombre
            // 
            this.lblIngresarNombre.AutoSize = true;
            this.lblIngresarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarNombre.Location = new System.Drawing.Point(21, 48);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(136, 15);
            this.lblIngresarNombre.TabIndex = 0;
            this.lblIngresarNombre.Text = "Ingrese un nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(429, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(609, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionado.Location = new System.Drawing.Point(330, 169);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(114, 46);
            this.btnSeleccionado.TabIndex = 5;
            this.btnSeleccionado.Text = ">";
            this.btnSeleccionado.UseVisualStyleBackColor = true;
            this.btnSeleccionado.Click += new System.EventHandler(this.btnSeleccionado_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.Location = new System.Drawing.Point(330, 256);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(114, 46);
            this.btnTodo.TabIndex = 6;
            this.btnTodo.Text = ">>";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // lbxNombresIzquierda
            // 
            this.lbxNombresIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNombresIzquierda.FormattingEnabled = true;
            this.lbxNombresIzquierda.ItemHeight = 15;
            this.lbxNombresIzquierda.Location = new System.Drawing.Point(21, 103);
            this.lbxNombresIzquierda.Name = "lbxNombresIzquierda";
            this.lbxNombresIzquierda.Size = new System.Drawing.Size(260, 289);
            this.lbxNombresIzquierda.TabIndex = 7;
            // 
            // lbxNombresDerecha
            // 
            this.lbxNombresDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNombresDerecha.FormattingEnabled = true;
            this.lbxNombresDerecha.ItemHeight = 15;
            this.lbxNombresDerecha.Location = new System.Drawing.Point(493, 103);
            this.lbxNombresDerecha.Name = "lbxNombresDerecha";
            this.lbxNombresDerecha.Size = new System.Drawing.Size(260, 289);
            this.lbxNombresDerecha.TabIndex = 8;
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxNombresDerecha);
            this.Controls.Add(this.lbxNombresIzquierda);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnSeleccionado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIngresarNombre);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSeleccionado;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.ListBox lbxNombresIzquierda;
        private System.Windows.Forms.ListBox lbxNombresDerecha;
    }
}