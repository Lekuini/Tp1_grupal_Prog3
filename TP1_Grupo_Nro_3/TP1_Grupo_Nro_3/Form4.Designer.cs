
namespace TP1_Grupo_Nro_3
{
    partial class FormEjercicio3
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
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSoltero = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.clbxRubros = new System.Windows.Forms.CheckedListBox();
            this.btnMostrarSeleccionado = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.gbxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFemenino);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(37, 44);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 0;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbtnMasculino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnMasculino.Location = new System.Drawing.Point(18, 63);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(87, 20);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Checked = true;
            this.rbtnFemenino.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbtnFemenino.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnFemenino.Location = new System.Drawing.Point(18, 31);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(86, 20);
            this.rbtnFemenino.TabIndex = 0;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbtnSoltero);
            this.gbxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstadoCivil.Location = new System.Drawing.Point(341, 44);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(199, 100);
            this.gbxEstadoCivil.TabIndex = 2;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnSoltero
            // 
            this.rbtnSoltero.AutoSize = true;
            this.rbtnSoltero.Location = new System.Drawing.Point(18, 66);
            this.rbtnSoltero.Name = "rbtnSoltero";
            this.rbtnSoltero.Size = new System.Drawing.Size(69, 20);
            this.rbtnSoltero.TabIndex = 3;
            this.rbtnSoltero.Text = "Soltero";
            this.rbtnSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnCasado.Checked = true;
            this.rbtnCasado.Location = new System.Drawing.Point(18, 31);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(74, 20);
            this.rbtnCasado.TabIndex = 0;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = false;
            // 
            // clbxRubros
            // 
            this.clbxRubros.CheckOnClick = true;
            this.clbxRubros.FormattingEnabled = true;
            this.clbxRubros.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbxRubros.Location = new System.Drawing.Point(159, 160);
            this.clbxRubros.Name = "clbxRubros";
            this.clbxRubros.Size = new System.Drawing.Size(255, 124);
            this.clbxRubros.TabIndex = 3;
            // 
            // btnMostrarSeleccionado
            // 
            this.btnMostrarSeleccionado.Location = new System.Drawing.Point(159, 300);
            this.btnMostrarSeleccionado.Name = "btnMostrarSeleccionado";
            this.btnMostrarSeleccionado.Size = new System.Drawing.Size(255, 23);
            this.btnMostrarSeleccionado.TabIndex = 4;
            this.btnMostrarSeleccionado.Text = "Mostrar lo que se seleccionó";
            this.btnMostrarSeleccionado.UseVisualStyleBackColor = true;
            this.btnMostrarSeleccionado.Click += new System.EventHandler(this.btnMostrarSeleccionado_Click);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionado.Location = new System.Drawing.Point(51, 343);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 20);
            this.lblSeleccionado.TabIndex = 5;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 539);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.btnMostrarSeleccionado);
            this.Controls.Add(this.clbxRubros);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.gbxSexo);
            this.Name = "FormEjercicio3";
            this.Text = "Ejercicio 3";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnSoltero;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.CheckedListBox clbxRubros;
        private System.Windows.Forms.Button btnMostrarSeleccionado;
        private System.Windows.Forms.Label lblSeleccionado;
    }
}