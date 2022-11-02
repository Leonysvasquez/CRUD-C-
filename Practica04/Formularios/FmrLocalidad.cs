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
    public partial class FmrLocalidad : Form
    {
        string IdProvincia;
        string NombreProvincia;
       

        public FmrLocalidad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtIDProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;

                // esta preguntando si el contenido del textbox es diferente de vacio
                if (txtIDProvincia.Text.Trim() != string.Empty)
                {
                    // aqui esta preguntado que si lo digitado es solo numero y si la tecla de funcion presionada es diferente la tecla BackSpace
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        // aqui mueve el foco del cursor al siguiente textbox en este caso es txtNombrePosicion
                        txtNombreProvincia.Focus();
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

        private void txtIDProvincia_Leave(object sender, EventArgs e)
        {
            // esta preguntando si el contenido del textbox es diferente de vacio
            if (txtIDProvincia.Text.Trim() != string.Empty)
            {
                // ----------------------------------------------------------------------
                // Busco.CargosPosiciones
                //
                // Busco...                              es la clase que se esta invocando
                // CargosPosiciones...                   es el metodo dento de la clase
                // Convert.ToString(txtPosicion.Text)... es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                txtNombreProvincia.Text = Busco.Localidad(Convert.ToString(txtIDProvincia.Text));

                //txtNombrePosicion.Text = NombreCargo;
                buscar_datos();
            }
        }

        private void txtNombreProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;

                // esta preguntando si el contenido del textbox es diferente de vacio
                if (txtNombreProvincia.Text.Trim() != string.Empty)
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

        private void txtNombreProvincia_Leave(object sender, EventArgs e)
        {
            if (txtNombreProvincia.Text.Trim() != string.Empty)
            {
                // ----------------------------------------------------------------------
                // Busco.CargosPosiciones
                //
                // Busco...                              es la clase que se esta invocando
                // CargosPosiciones...                   es el metodo dento de la clase
                // Convert.ToString(txtPosicion.Text)... es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                txtNombreProvincia.Text = Busco.Localidad(Convert.ToString(txtIDProvincia.Text));

                //txtNombrePosicion.Text = NombreCargo;
                buscar_datos();
            }
        }

        private void btnConsultaIdP_Click(object sender, EventArgs e)
        {
            {
                txtIDProvincia.Focus();  // el curso se queda en el textbox txtdepartamento

                // creo el objeto frm y se le asigna el formulario frmVENDEPTO al objeto
                VENTLocalidad frm = new VENTLocalidad();

                DialogResult res = frm.ShowDialog();  // aqui muestra la ventana
                                                      // res = obtiene el valor de la ventana de consulta abierta
                                                      // obtendra el valor de ok cuando cierre la ventana

                if (res == DialogResult.OK)           // aqui pregunta que si res es igual a ok ejecute el siguiente codigo
                {
                    txtIDProvincia.Text = frm.varf1; // txtdepartamento se le asignara el valor contenido en la variable varf1
                    txtNombreProvincia.Text = frm.varf2;
                    
                }
            }
    }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarInformacion(Convert.ToString(txtIDProvincia.Text));  // Borra la informacion en la tabla POSICIONES en la base de datos antes de grabar
            // y se envia Convert.ToString(txtPosicion.Text) como parametro que es recibido 
            // por la funcion BorrarInformacion.

            GuardarInformacion();                                   // Inserta la informacion en la tabla POSICIONES en la base de datos
            btnLimpiar.PerformClick();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarEsteFormulario();  // viaja hasta la funcion LimpiarEsteFormulario() y ejecuta su contenido
            txtIDProvincia.Focus();      // mueve el cursor al textBox indicado
        }

        private void bntBorrar_Click(object sender, EventArgs e)
        {
            BorrarInformacion(Convert.ToString(txtIDProvincia.Text));
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

            SqlCommand queri = new SqlCommand("DELETE FROM LOCALIDAD WHERE IDLOCALIDAD = @RG;", cnndel);  // crea el comando para ejecutar el script de sql
            queri.Parameters.AddWithValue("@RG", numPosicion);   // aqui se le envia la data contenida en numPosicion al parametro @RG
            queri.ExecuteNonQuery();                             // ejecuta el query

            cnndel.Close();                                      // cierra la conexion a la base de datos
        }

        private void GuardarInformacion()
        {
            SqlConnection cnGuardar = new SqlConnection(cnn.db);
            cnGuardar.Open();   // aqui abre la base de datos

            // script sql para insertar data dentro de la tabla POSICIONES por medio de parametros de entrada
            string stQuery = "INSERT INTO LOCALIDAD (IDLocalidad ) VALUES (@A0, @A1);";
            SqlCommand miqueri = new SqlCommand(stQuery, cnGuardar); // crea el comando para ejecutar el script de sql

            miqueri.Parameters.AddWithValue("@A0", Convert.ToString(txtIDProvincia.Text));        // asignado valor al paramentro mediante los textbox
            miqueri.Parameters.AddWithValue("@A1", Convert.ToString(txtNombreProvincia.Text));
         

            miqueri.ExecuteNonQuery(); // ejecuta el query
            cnGuardar.Close();         // cierra la conexion a la base de datos
        }

        private void buscar_datos()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("    SELECT IDLocalidad ,NombreLocalidad,  " +
                                              " FROM LOCALIDAD "+
                                              "WHERE IDLocalidad =@PV", cnxn);

            cmmnd.Parameters.AddWithValue("@PV", txtIDProvincia.Text);

            SqlDataReader recordn = cmmnd.ExecuteReader();

            if (recordn.Read())
            {
                // los campos que contienen la data extraida de la tabla es asignado a cada elemento correspondiente
                txtNombreProvincia.Text = Convert.ToString(recordn["NOMBRELOCALIDAD"]);
                txtIDProvincia.Text = Convert.ToString(recordn["LOCADLIDAD"]);


                IDProvincia.Text = Convert.ToString(recordn["NombreLocalidad"]);
          
            }

            cmmnd.Dispose();  // libera el sqlcommand 
            cnxn.Close();   // cierra la conexion a la base de datos
        }

        private void LimpiarEsteFormulario()
        {
            // -----------------------------
            // Limpia los textBox and Label
            // -----------------------------
           
            txtNombreProvincia.Clear();
            txtIDProvincia.Clear();
            IDProvincia.Text = "";
            lblNombreProvincia.Text = "";
        }

       
    }
}

    

