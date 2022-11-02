namespace Practica04
{
    partial class FmrLocalidad
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
            this.btnConsultaIdP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProvincia = new System.Windows.Forms.TextBox();
            this.txtIDProvincia = new System.Windows.Forms.TextBox();
            this.lblNombreProvincia = new System.Windows.Forms.Label();
            this.IDProvincia = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bntBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaIdP
            // 
            this.btnConsultaIdP.Location = new System.Drawing.Point(256, 85);
            this.btnConsultaIdP.Name = "btnConsultaIdP";
            this.btnConsultaIdP.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaIdP.TabIndex = 34;
            this.btnConsultaIdP.Text = "...";
            this.btnConsultaIdP.UseVisualStyleBackColor = true;
            this.btnConsultaIdP.Click += new System.EventHandler(this.btnConsultaIdP_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(577, 49);
            this.label5.TabIndex = 33;
            this.label5.Text = " Maestro de  Provincias";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreProvincia
            // 
            this.txtNombreProvincia.Location = new System.Drawing.Point(191, 113);
            this.txtNombreProvincia.Name = "txtNombreProvincia";
            this.txtNombreProvincia.Size = new System.Drawing.Size(359, 20);
            this.txtNombreProvincia.TabIndex = 18;
            this.txtNombreProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProvincia_KeyPress);
            this.txtNombreProvincia.Leave += new System.EventHandler(this.txtNombreProvincia_Leave);
            // 
            // txtIDProvincia
            // 
            this.txtIDProvincia.Location = new System.Drawing.Point(191, 87);
            this.txtIDProvincia.Name = "txtIDProvincia";
            this.txtIDProvincia.Size = new System.Drawing.Size(65, 20);
            this.txtIDProvincia.TabIndex = 17;
            this.txtIDProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDProvincia_KeyPress);
            this.txtIDProvincia.Leave += new System.EventHandler(this.txtIDProvincia_Leave);
            // 
            // lblNombreProvincia
            // 
            this.lblNombreProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreProvincia.Location = new System.Drawing.Point(16, 113);
            this.lblNombreProvincia.Name = "lblNombreProvincia";
            this.lblNombreProvincia.Size = new System.Drawing.Size(169, 20);
            this.lblNombreProvincia.TabIndex = 24;
            this.lblNombreProvincia.Text = "Nombre de la Provincia";
            // 
            // IDProvincia
            // 
            this.IDProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDProvincia.Location = new System.Drawing.Point(16, 87);
            this.IDProvincia.Name = "IDProvincia";
            this.IDProvincia.Size = new System.Drawing.Size(169, 20);
            this.IDProvincia.TabIndex = 23;
            this.IDProvincia.Text = "ID Provincia";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(433, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 34);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bntBorrar
            // 
            this.bntBorrar.Location = new System.Drawing.Point(289, 182);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(129, 34);
            this.bntBorrar.TabIndex = 29;
            this.bntBorrar.Text = "Borrar";
            this.bntBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBorrar.UseVisualStyleBackColor = true;
            this.bntBorrar.Click += new System.EventHandler(this.bntBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(154, 182);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 34);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 34);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FmrLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 242);
            this.Controls.Add(this.btnConsultaIdP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreProvincia);
            this.Controls.Add(this.txtIDProvincia);
            this.Controls.Add(this.lblNombreProvincia);
            this.Controls.Add(this.IDProvincia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FmrLocalidad";
            this.Text = "FmrLocalidad";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaIdP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreProvincia;
        private System.Windows.Forms.TextBox txtIDProvincia;
        private System.Windows.Forms.Label lblNombreProvincia;
        private System.Windows.Forms.Label IDProvincia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button bntBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}