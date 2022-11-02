namespace Practica04
{
    partial class frmCliente
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.bntBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSecuencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClase = new System.Windows.Forms.Button();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.txtDirrecion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefCasa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefMovil = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textContacto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(604, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 57);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bntBorrar
            // 
            this.bntBorrar.Location = new System.Drawing.Point(452, 398);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(119, 57);
            this.bntBorrar.TabIndex = 54;
            this.bntBorrar.Text = "Borrar";
            this.bntBorrar.UseVisualStyleBackColor = true;
            this.bntBorrar.Click += new System.EventHandler(this.bntBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(294, 398);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 57);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(141, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 57);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(187, 123);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.Size = new System.Drawing.Size(92, 20);
            this.txtSecuencia.TabIndex = 50;
            this.txtSecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecuencia_KeyPress);
            this.txtSecuencia.Leave += new System.EventHandler(this.txtSecuencia_Leave);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = " Secuencia del Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(187, 149);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(359, 20);
            this.txtNombreCliente.TabIndex = 48;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            this.txtNombreCliente.Leave += new System.EventHandler(this.txtNombreCliente_Leave);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = " Nombre del Cliente";
            // 
            // btnClase
            // 
            this.btnClase.Location = new System.Drawing.Point(279, 122);
            this.btnClase.Name = "btnClase";
            this.btnClase.Size = new System.Drawing.Size(27, 22);
            this.btnClase.TabIndex = 46;
            this.btnClase.Text = "...";
            this.btnClase.UseVisualStyleBackColor = true;
            this.btnClase.Click += new System.EventHandler(this.btnClase_Click);
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(187, 97);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(92, 20);
            this.txtClase.TabIndex = 45;
            this.txtClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClase_KeyPress);
            this.txtClase.Leave += new System.EventHandler(this.txtClase_Leave);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = " Clasificacion Cliente";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(756, 55);
            this.label5.TabIndex = 44;
            this.label5.Text = " Maestro de Clientes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Location = new System.Drawing.Point(3, 398);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(119, 55);
            this.btnConsultaCliente.TabIndex = 56;
            this.btnConsultaCliente.Text = "Consulta Clientes  ";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            // 
            // txtDirrecion
            // 
            this.txtDirrecion.Location = new System.Drawing.Point(187, 175);
            this.txtDirrecion.Name = "txtDirrecion";
            this.txtDirrecion.Size = new System.Drawing.Size(359, 20);
            this.txtDirrecion.TabIndex = 57;
            this.txtDirrecion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDirrecion_KeyPress);
            this.txtDirrecion.Leave += new System.EventHandler(this.textDirrecion_Leave);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = " Direccion";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(187, 201);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(359, 20);
            this.txtSector.TabIndex = 59;
            this.txtSector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSector_KeyPress);
            this.txtSector.Leave += new System.EventHandler(this.txtSector_Leave);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = " Sector";
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(187, 227);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(359, 20);
            this.txtEdificio.TabIndex = 61;
            this.txtEdificio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdificio_KeyPress);
            this.txtEdificio.Leave += new System.EventHandler(this.txtEdificio_Leave);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = " Edificio";
            // 
            // txtCuidad
            // 
            this.txtCuidad.Location = new System.Drawing.Point(187, 253);
            this.txtCuidad.Name = "txtCuidad";
            this.txtCuidad.Size = new System.Drawing.Size(359, 20);
            this.txtCuidad.TabIndex = 63;
            this.txtCuidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuidad_KeyPress);
            this.txtCuidad.Leave += new System.EventHandler(this.txtCuidad_Leave);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(12, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = " Ciudad";
            // 
            // txtTelefCasa
            // 
            this.txtTelefCasa.Location = new System.Drawing.Point(187, 279);
            this.txtTelefCasa.Name = "txtTelefCasa";
            this.txtTelefCasa.Size = new System.Drawing.Size(119, 20);
            this.txtTelefCasa.TabIndex = 65;
            this.txtTelefCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefCasa_KeyPress);
            this.txtTelefCasa.Leave += new System.EventHandler(this.textTelefCasa_Leave);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = " Telefono Casa";
            // 
            // txtTelefMovil
            // 
            this.txtTelefMovil.Location = new System.Drawing.Point(187, 305);
            this.txtTelefMovil.Name = "txtTelefMovil";
            this.txtTelefMovil.Size = new System.Drawing.Size(119, 20);
            this.txtTelefMovil.TabIndex = 67;
            this.txtTelefMovil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefMovil_KeyPress);
            this.txtTelefMovil.Leave += new System.EventHandler(this.textTelefMovil_Leave);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(12, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = " Telefono Movil";
            // 
            // textContacto
            // 
            this.textContacto.Location = new System.Drawing.Point(187, 331);
            this.textContacto.Name = "textContacto";
            this.textContacto.Size = new System.Drawing.Size(359, 20);
            this.textContacto.TabIndex = 69;
            this.textContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textContacto_KeyPress);
            this.textContacto.Leave += new System.EventHandler(this.textContacto_Leave);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(12, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = " Contacto";
            // 
            // textCorreoElectronico
            // 
            this.textCorreoElectronico.Location = new System.Drawing.Point(187, 357);
            this.textCorreoElectronico.Name = "textCorreoElectronico";
            this.textCorreoElectronico.Size = new System.Drawing.Size(359, 20);
            this.textCorreoElectronico.TabIndex = 71;
            this.textCorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCorreoElectronico_KeyPress);
            this.textCorreoElectronico.Leave += new System.EventHandler(this.textCorreoElectronico_Leave);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(12, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 72;
            this.label12.Text = " Correo Electronico";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.textCorreoElectronico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textContacto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTelefMovil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelefCasa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCuidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDirrecion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultaCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClase);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button bntBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSecuencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClase;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.TextBox txtDirrecion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefCasa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefMovil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textContacto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCorreoElectronico;
        private System.Windows.Forms.Label label12;
    }
}