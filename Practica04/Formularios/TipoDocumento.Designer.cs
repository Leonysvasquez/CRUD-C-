namespace Practica04
{
    partial class TipoDocumento
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
            this.txtSecuenciaActual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrigenDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClaseDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultaTipDoc = new System.Windows.Forms.Button();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.bntBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSecuenciaActual
            // 
            this.txtSecuenciaActual.Location = new System.Drawing.Point(181, 195);
            this.txtSecuenciaActual.Name = "txtSecuenciaActual";
            this.txtSecuenciaActual.Size = new System.Drawing.Size(359, 20);
            this.txtSecuenciaActual.TabIndex = 71;
            this.txtSecuenciaActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuenciaActual_KeyPress);
            this.txtSecuenciaActual.Leave += new System.EventHandler(this.txtSecuenciaActual_Leave);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = " Secuencia Actual";
            // 
            // txtOrigenDoc
            // 
            this.txtOrigenDoc.Location = new System.Drawing.Point(181, 169);
            this.txtOrigenDoc.Name = "txtOrigenDoc";
            this.txtOrigenDoc.Size = new System.Drawing.Size(359, 20);
            this.txtOrigenDoc.TabIndex = 69;
            this.txtOrigenDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrigenDoc_KeyPress);
            this.txtOrigenDoc.Leave += new System.EventHandler(this.txtOrigenDoc_Leave);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Origen Documento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(181, 117);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(92, 20);
            this.txtDescripcion.TabIndex = 67;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Descripcion";
            // 
            // txtClaseDoc
            // 
            this.txtClaseDoc.Location = new System.Drawing.Point(181, 143);
            this.txtClaseDoc.Name = "txtClaseDoc";
            this.txtClaseDoc.Size = new System.Drawing.Size(359, 20);
            this.txtClaseDoc.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Clase Documento";
            // 
            // btnConsultaTipDoc
            // 
            this.btnConsultaTipDoc.Location = new System.Drawing.Point(273, 116);
            this.btnConsultaTipDoc.Name = "btnConsultaTipDoc";
            this.btnConsultaTipDoc.Size = new System.Drawing.Size(27, 22);
            this.btnConsultaTipDoc.TabIndex = 63;
            this.btnConsultaTipDoc.Text = "...";
            this.btnConsultaTipDoc.UseVisualStyleBackColor = true;
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(181, 91);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(92, 20);
            this.txtTipoDoc.TabIndex = 62;
            this.txtTipoDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoDoc_KeyPress);
            this.txtTipoDoc.Leave += new System.EventHandler(this.txtTipoDoc_Leave);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tipo Documento";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-3, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(733, 55);
            this.label5.TabIndex = 61;
            this.label5.Text = " Maestro Tipo Documento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(575, 265);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 57);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bntBorrar
            // 
            this.bntBorrar.Location = new System.Drawing.Point(433, 265);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(119, 57);
            this.bntBorrar.TabIndex = 75;
            this.bntBorrar.Text = "Borrar";
            this.bntBorrar.UseVisualStyleBackColor = true;
            this.bntBorrar.Click += new System.EventHandler(this.bntBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(287, 265);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 57);
            this.btnLimpiar.TabIndex = 74;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(148, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 57);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(10, 265);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(119, 55);
            this.btnConsulta.TabIndex = 77;
            this.btnConsulta.Text = "Consulta ";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // TipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 364);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSecuenciaActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrigenDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClaseDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultaTipDoc);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "TipoDocumento";
            this.Text = "TipoDocumento";
            this.Load += new System.EventHandler(this.TipoDocumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecuenciaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrigenDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClaseDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultaTipDoc;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button bntBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsulta;
    }
}