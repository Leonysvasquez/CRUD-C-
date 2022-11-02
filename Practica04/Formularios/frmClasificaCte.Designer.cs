namespace Practica04
{
    partial class frmClasificaCte
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
            this.SECUENCIA = new System.Windows.Forms.Label();
            this.txtSecuencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConsultaCD
            // 
            this.btnConsultaCD.Location = new System.Drawing.Point(271, 73);
            this.btnConsultaCD.Name = "btnConsultaCD";
            this.btnConsultaCD.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaCD.TabIndex = 44;
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
            this.label5.Location = new System.Drawing.Point(-6, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(618, 49);
            this.label5.TabIndex = 43;
            this.label5.Text = " Maestro Clasifica Documento Cte";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(200, 113);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(359, 20);
            this.txtDescripcion.TabIndex = 36;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(200, 73);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(65, 20);
            this.txtClase.TabIndex = 35;
            this.txtClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClase_KeyPress);
            this.txtClase.Leave += new System.EventHandler(this.txtClase_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(169, 20);
            this.lblDescripcion.TabIndex = 38;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblClase
            // 
            this.lblClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClase.Location = new System.Drawing.Point(12, 73);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(169, 20);
            this.lblClase.TabIndex = 37;
            this.lblClase.Text = "CLASE";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(462, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 55);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bntBorrar
            // 
            this.bntBorrar.Location = new System.Drawing.Point(312, 183);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(129, 55);
            this.bntBorrar.TabIndex = 41;
            this.bntBorrar.Text = "Borrar";
            this.bntBorrar.UseVisualStyleBackColor = true;
            this.bntBorrar.Click += new System.EventHandler(this.bntBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(163, 183);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 55);
            this.btnLimpiar.TabIndex = 40;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 183);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 55);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // SECUENCIA
            // 
            this.SECUENCIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SECUENCIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SECUENCIA.Location = new System.Drawing.Point(12, 150);
            this.SECUENCIA.Name = "SECUENCIA";
            this.SECUENCIA.Size = new System.Drawing.Size(169, 20);
            this.SECUENCIA.TabIndex = 45;
            this.SECUENCIA.Text = "SECUENCIA";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(200, 148);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(78, 20);
            this.txtSecuencia.TabIndex = 46;
            this.txtSecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuencia_KeyPress);
            this.txtSecuencia.Leave += new System.EventHandler(this.txtSecuencia_Leave);
            // 
            // frmClasificaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 269);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.SECUENCIA);
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
            this.Name = "frmClasificaCte";
            this.Text = "frmClasificaCte";

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
        private System.Windows.Forms.Label SECUENCIA;
        private System.Windows.Forms.TextBox txtSecuencia;
    }
}