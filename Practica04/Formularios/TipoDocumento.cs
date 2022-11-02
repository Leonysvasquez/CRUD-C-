using System;
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
    public partial class TipoDocumento : Form
    {
        public TipoDocumento()
        {
            InitializeComponent();
        }

        private void TipoDocumento_Load(object sender, EventArgs e)
        {
            this.Text = HMenu.cia + " Maestro Tipo Documento " + HMenu.pc;
            this.KeyPreview = true;
        }

        private void txtTipoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtTipoDoc.Text.Trim() != string.Empty)
                {
                    txtDescripcion.Focus();  // mueve el cursor al textbos txtSecuencia
                }
            }
        }

        private void txtTipoDoc_Leave(object sender, EventArgs e)
        {
            if (txtTipoDoc.Text.Trim() != string.Empty) ;

            txtDescripcion.Text = Busco.CargosPosiciones(Convert.ToString(txtTipoDoc.Text));

            //txtNombrePosicion.Text = NombreCargo;
            //buscar_datos();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtTipoDoc.Text.Trim() != string.Empty)
                {
                    txtClaseDoc.Focus();  // mueve el cursor al textbos txtSecuencia
                }
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() != string.Empty) ;

            txtClaseDoc.Text = Busco.CargosPosiciones(Convert.ToString(txtDescripcion.Text));

            //txtNombrePosicion.Text = NombreCargo;
            //buscar_datos();
        }

        private void txtOrigenDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtOrigenDoc.Text.Trim() != string.Empty)
                {
                    txtSecuenciaActual.Focus();  // mueve el cursor al textbos txtSecuencia
                }
            }
        }

        private void txtOrigenDoc_Leave(object sender, EventArgs e)
        {
            if (txtOrigenDoc.Text.Trim() != string.Empty) ;

            txtSecuenciaActual.Text = Busco.CargosPosiciones(Convert.ToString(txtOrigenDoc.Text));

            //txtNombrePosicion.Text = NombreCargo;
            //buscar_datos();
        }

        private void txtSecuenciaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtSecuenciaActual.Text.Trim() != string.Empty)
                {
                    btnGuardar.Focus();  // mueve el cursor al textbos txtSecuencia
                }
            }
        }

        private void txtSecuenciaActual_Leave(object sender, EventArgs e)
        {
            if (txtSecuenciaActual.Text.Trim() != string.Empty) ;

            txtSecuenciaActual.Text = Busco.CargosPosiciones(Convert.ToString(txtSecuenciaActual.Text));

            //txtNombrePosicion.Text = NombreCargo;
            //buscar_datos();
        }

        

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInformacion();                            
            btnLimpiar.PerformClick();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarEsteFormulario(); 
            txtTipoDoc.Focus();
        }

        private void bntBorrar_Click(object sender, EventArgs e)
        {
            BorrarInformacion(Convert.ToString(txtTipoDoc));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrarInformacion(string TipDoc)
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

            SqlCommand queri = new SqlCommand("DELETE FROM TipDoc  WHERE TipDoc = @RG;", cnndel);  // crea el comando para ejecutar el script de sql
            queri.Parameters.AddWithValue("@RG", TipDoc);   // aqui se le envia la data contenida en numPosicion al parametro @RG
            queri.ExecuteNonQuery();                             // ejecuta el query

            cnndel.Close();                                      // cierra la conexion a la base de datos
        }

        private void GuardarInformacion()
        {
            SqlConnection cnGuardar = new SqlConnection(cnn.db);
            cnGuardar.Open();   // aqui abre la base de datos

            // script sql para insertar data dentro de la tabla POSICIONES por medio de parametros de entrada
            string stQuery = "INSERT INTO TipDoc (   TipDoc,Descripcion,Origen, ClaDoc,Numero ) VALUES (@A0, @A1, @A2, @A3, @A4 );";
            SqlCommand miqueri = new SqlCommand(stQuery, cnGuardar); // crea el comando para ejecutar el script de sql

            miqueri.Parameters.AddWithValue("@A0", Convert.ToString(txtTipoDoc.Text));        // asignado valor al paramentro mediante los textbox
            miqueri.Parameters.AddWithValue("@A1", Convert.ToString(txtDescripcion.Text));
            miqueri.Parameters.AddWithValue("@A2", Convert.ToString(txtClaseDoc.Text));
            miqueri.Parameters.AddWithValue("@A3", Convert.ToString(txtOrigenDoc.Text));
            miqueri.Parameters.AddWithValue("@A3", Convert.ToString(txtSecuenciaActual.Text));

            miqueri.ExecuteNonQuery(); // ejecuta el query
            cnGuardar.Close();         // cierra la conexion a la base de datos
        }

        private void buscar_datos()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("SELECT TipDoc ,Descripcion,Origen,ClaDoc,Numero" +
                "                                     FROM TipDoc", cnxn);

            cmmnd.Parameters.AddWithValue("@PV", txtTipoDoc.Text);

            SqlDataReader recordn = cmmnd.ExecuteReader();

            if (recordn.Read())
            {
                // los campos que contienen la data extraida de la tabla es asignado a cada elemento correspondiente
                txtTipoDoc.Text = Convert.ToString(recordn["TipDoc"]);
                txtDescripcion.Text = Convert.ToString(recordn["Descripcion"]);
                txtClaseDoc.Text = Convert.ToString(recordn["Origen"]);

                txtOrigenDoc.Text = Convert.ToString(recordn["Origen"]);
                txtSecuenciaActual.Text = Convert.ToString(recordn["Secuencia"]);
               
            }

            cmmnd.Dispose();  // libera el sqlcommand 
            cnxn.Close();   // cierra la conexion a la base de datos
        }

        private void LimpiarEsteFormulario()
        {
            // -----------------------------
            // Limpia los textBox and Label
            // -----------------------------
            txtTipoDoc.Clear();
            txtDescripcion.Clear();
            txtClaseDoc.Clear();
            txtOrigenDoc.Clear();
            txtSecuenciaActual.Clear();
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            {
                txtSecuenciaActual.Focus();  // el curso se queda en el textbox txtdepartamento

                // creo el objeto frm y se le asigna el formulario frmVENDEPTO al objeto
                VENTTipDoc frm = new VENTTipDoc();

                DialogResult res = frm.ShowDialog();  // aqui muestra la ventana
                                                      // res = obtiene el valor de la ventana de consulta abierta
                                                      // obtendra el valor de ok cuando cierre la ventana

                if (res == DialogResult.OK)           // aqui pregunta que si res es igual a ok ejecute el siguiente codigo
                {
                    txtTipoDoc.Text = frm.varf1; // txtdepartamento se le asignara el valor contenido en la variable varf1
                    txtDescripcion.Text = frm.varf2;
                    txtClaseDoc.Text = frm.varf3;
                    txtOrigenDoc.Text = frm.varf4;
                    txtSecuenciaActual.Text = frm.varf5;// txtdepartamento se le asignara el valor contenido en la variable varf2
                }
            }
        }
    }
}
