namespace Practica04
{
    partial class ClasificaDocumento
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
            this.btnConsultaCD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bntBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaCD
            // 
            this.btnConsultaCD.Location = new System.Drawing.Point(273, 73);
            this.btnConsultaCD.Name = "btnConsultaCD";
            this.btnConsultaCD.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaCD.TabIndex = 56;
            this.btnConsultaCD.Text = "...";
            this.btnConsultaCD.UseVisualStyleBackColor = true;
            this.btnConsultaCD.Click += new System.EventHandler(this.btnConsultaCD_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-4, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(618, 49);
            this.label5.TabIndex = 55;
            this.label5.Text = " Maestro Clasifica Documento ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(202, 113);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(359, 20);
            this.txtDescripcion.TabIndex = 48;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(202, 73);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(65, 20);
            this.txtClase.TabIndex = 47;
            this.txtClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClase_KeyPress);
            this.txtClase.Leave += new System.EventHandler(this.txtClase_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(169, 20);
            this.lblDescripcion.TabIndex = 50;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblClase
            // 
            this.lblClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClase.Location = new System.Drawing.Point(14, 73);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(169, 20);
            this.lblClase.TabIndex = 49;
            this.lblClase.Text = "CLASE";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(465, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 55);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bntBorrar
            // 
            this.bntBorrar.Location = new System.Drawing.Point(316, 176);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(129, 55);
            this.bntBorrar.TabIndex = 53;
            this.bntBorrar.Text = "Borrar";
            this.bntBorrar.UseVisualStyleBackColor = true;
            this.bntBorrar.Click += new System.EventHandler(this.bntBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(171, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 55);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(14, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 55);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ClasificaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 262);
            this.Controls.Add(this.btnConsultaCD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "ClasificaDocumento";
            this.Text = "ClasificaDocumento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultaCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button bntBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}