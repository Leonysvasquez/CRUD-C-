﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  // habilita el cliente de SQL

namespace Practica04
{
    //private  string variablef1;
    //private  string variablef2;
    // private string variablef3;
    public partial class frmClasificaCte : Form
    {
        public frmClasificaCte()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;

                // esta preguntando si el contenido del textbox es diferente de vacio
                if (txtClase.Text.Trim() != string.Empty)
                {
                    // aqui esta preguntado que si lo digitado es solo numero y si la tecla de funcion presionada es diferente la tecla BackSpace
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        // aqui mueve el foco del cursor al siguiente textbox en este caso es txtNombrePosicion
                        txtDescripcion.Focus();
                    }
                    else  // else significa... de lo contrario haz esto
                    {
                        MessageBox.Show("Solo números", "MSJ",  // abre la caja de mensajes y despliega el mensaje que dice Solo Números
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        private void txtClase_Leave(object sender, EventArgs e)
        {
            if (txtClase.Text.Trim() != string.Empty)

            {
                // ----------------------------------------------------------------------
                // Busco.CargosPosiciones
                //
                // Busco...                              es la clase que se esta invocando
                // CargosPosiciones...                   es el metodo dento de la clase
                // Convert.ToString(txtPosicion.Text)... es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                txtDescripcion.Text = Busco.Localidad(Convert.ToString(txtClase.Text));

                //txtNombrePosicion.Text = NombreCargo;
                buscar_datos();
            }

        }

      

       

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    e.Handled = true;

                    // esta preguntando si el contenido del textbox es diferente de vacio
                    if (txtClase.Text.Trim() != string.Empty)
                    {
                        // aqui esta preguntado que si lo digitado es solo numero y si la tecla de funcion presionada es diferente la tecla BackSpace
                        if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                        {
                            // aqui mueve el foco del cursor al siguiente textbox en este caso es txtNombrePosicion
                            txtSecuencia.Focus();
                        }
                        else  // else significa... de lo contrario haz esto
                        {
                            MessageBox.Show("Solo números", "MSJ",  // abre la caja de mensajes y despliega el mensaje que dice Solo Números
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() != string.Empty)

            {
                // ----------------------------------------------------------------------
                // Busco.CargosPosiciones
                //
                // Busco...                              es la clase que se esta invocando
                // CargosPosiciones...                   es el metodo dento de la clase
                // Convert.ToString(txtPosicion.Text)... es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                txtDescripcion.Text = Busco.Localidad(Convert.ToString(txtClase.Text));

                //txtNombrePosicion.Text = NombreCargo;
                buscar_datos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInformacion();                                   // Inserta la informacion en la tabla POSICIONES en la base de datos
            btnLimpiar.PerformClick();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarEsteFormulario();  // viaja hasta la funcion LimpiarEsteFormulario() y ejecuta su contenido
            txtClase.Focus();      // mueve el cursor al textBox indicado
        }

        private void bntBorrar_Click(object sender, EventArgs e)
        {
            BorrarInformacion(Convert.ToString(txtClase.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario
        }

        private void BorrarInformacion(string numPosicion)
        {
            // ----------------------------------------------------------
            // se crea la conexion hacia SQL
            // cnn.db ... contiene el string conexion a la base de datos
            // cnndel ... es el objeto creado que manipulara la conexion a la base de datos
            // ----------------------------------------------------------
            SqlConnection cnndel = new SqlConnection(cnn.db);
            cnndel.Open();  // aqui abre la base de datos

            // aqui se arma el script de sql y contiene un parametro @RG
            // string miQuery = "DELETE FROM POSICIONES WHERE IDPOSICION = @RG;";

            SqlCommand queri = new SqlCommand("DELETE FROM CLASIFICA_Cte WHERE CLASIFICA = @RG;", cnndel);  // crea el comando para ejecutar el script de sql
            queri.Parameters.AddWithValue("@RG", numPosicion);   // aqui se le envia la data contenida en numPosicion al parametro @RG
            queri.ExecuteNonQuery();                             // ejecuta el query

            cnndel.Close();                                      // cierra la conexion a la base de datos
        }

        private void GuardarInformacion()
        {
            SqlConnection cnGuardar = new SqlConnection(cnn.db);
            cnGuardar.Open();   // aqui abre la base de datos

            // script sql para insertar data dentro de la tabla POSICIONES por medio de parametros de entrada
            string stQuery = "INSERT INTO CLASIFICA_Cte  (Clasifica ,Descripcion, SECUENCIA) VALUES (@A0, @A1,@2);";
            SqlCommand miqueri = new SqlCommand(stQuery, cnGuardar); // crea el comando para ejecutar el script de sql

            miqueri.Parameters.AddWithValue("@A0", Convert.ToString(txtClase.Text));        // asignado valor al paramentro mediante los textbox
            miqueri.Parameters.AddWithValue("@A1", Convert.ToString(txtDescripcion.Text));
            miqueri.Parameters.AddWithValue("@A2", Convert.ToString(txtSecuencia.Text));


            miqueri.ExecuteNonQuery(); // ejecuta el query
            cnGuardar.Close();         // cierra la conexion a la base de datos
        }

        private void buscar_datos()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("    SELECT Clasifica ,Descripcion,SECUENCIA" +
                                              " FROM Clasifica_Cte " +
                                              "WHERE Clasifica =@PV", cnxn);

            cmmnd.Parameters.AddWithValue("@PV", txtClase.Text);

            SqlDataReader recordn = cmmnd.ExecuteReader();

            if (recordn.Read())
            {
                // los campos que contienen la data extraida de la tabla es asignado a cada elemento correspondiente
                txtClase.Text = Convert.ToString(recordn["Clasifica"]);
                txtDescripcion.Text = Convert.ToString(recordn["Descripcion"]);
                txtSecuencia.Text = Convert.ToString(recordn["SECUENCIA"]);




            }

            cmmnd.Dispose();  // libera el sqlcommand 
            cnxn.Close();   // cierra la conexion a la base de datos
        }
        private void LimpiarEsteFormulario()
        {
            // -----------------------------
            // Limpia los textBox and Label
            // -----------------------------

            txtClase.Clear();
            txtDescripcion.Clear();
            txtSecuencia.Clear();
            
        }

        private void txtSecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;

                // esta preguntando si el contenido del textbox es diferente de vacio
                if (txtSecuencia.Text.Trim() != string.Empty)
                {
                    // aqui esta preguntado que si lo digitado es solo numero y si la tecla de funcion presionada es diferente la tecla BackSpace
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        // aqui mueve el foco del cursor al siguiente textbox en este caso es txtNombrePosicion
                        btnGuardar.Focus();
                    }
                    else  // else significa... de lo contrario haz esto
                    {
                        MessageBox.Show("Solo números", "MSJ",  // abre la caja de mensajes y despliega el mensaje que dice Solo Números
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        private void txtSecuencia_Leave(object sender, EventArgs e)
        {

            if (txtSecuencia.Text.Trim() != string.Empty)

            {
                // ----------------------------------------------------------------------
                // Busco.CargosPosiciones
                //
                // Busco...                              es la clase que se esta invocando
                // CargosPosiciones...                   es el metodo dento de la clase
                // Convert.ToString(txtPosicion.Text)... es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                txtDescripcion.Text = Busco.Localidad(Convert.ToString(txtClase.Text));

                //txtNombrePosicion.Text = NombreCargo;
                buscar_datos();
            }
        }

      

        private void btnConsultaCD_Click(object sender, EventArgs e)
        {
            txtClase.Focus();  // el curso se queda en el textbox txtdepartamento

            VENTCLASIFICACTE frm = new VENTCLASIFICACTE();

            DialogResult res = frm.ShowDialog();  // aqui muestra la ventana
                                                  // res = obtiene el valor de la ventana de consulta abierta
                                                  // obtendra el valor de ok cuando cierre la ventana

            if (res == DialogResult.OK)           // aqui pregunta que si res es igual a ok ejecute el siguiente codigo
            {
                txtClase.Text = frm.varf1; // txtdepartamento se le asignara el valor contenido en la variable varf1
                txtDescripcion.Text = frm.varf2; // txtdepartamento se le asignara el valor contenido en la variable varf2
                txtSecuencia.Text = frm.varf3;
            }
        }

      
    }
}
