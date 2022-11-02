using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practica04
{
    public partial class frmCliente : Form
    {
        Boolean ClienteExiste;

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Text = HMenu.cia + " Maestro de Cliente " + HMenu.pc;
            this.KeyPreview = true;    // puedo presionar la tecla escape

            ClienteExiste = false;
        }

        private void txtClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtClase.Text.Trim() != string.Empty)
                {
                    txtSecuencia.Focus();  // mueve el cursor al textbos txtSecuencia
                }
            }
        }

        private void txtClase_Leave(object sender, EventArgs e)
        {
            if (txtClase.Text.Trim() != string.Empty)
            {
                txtClase.Text = Convert.ToInt32(txtClase.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void txtSecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtClase.Text.Trim() != string.Empty)
                {
                    txtNombreCliente.Focus();
                }
            }
        }

        private void txtSecuencia_Leave(object sender, EventArgs e)
        {
            btnConsultaCliente.PerformClick();  // ejecuta el contenido del boton btnConsultaCliente
        }

        private void btnClase_Click(object sender, EventArgs e)
        {
            if (txtClase.Text.Trim() != string.Empty)
            {
                txtSecuencia.Text = Convert.ToInt32(txtSecuencia.Text).ToString("00000000"); // formatea el textbox txtsecuencia con 8 digitos numericos

                BuscarCliente();
            }
        }






        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtClase.Text.Trim() != string.Empty)
                {
                    txtDirrecion.Focus();
                }
            }
        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text.Trim() != string.Empty)
            {
                txtNombreCliente.Text = Convert.ToInt32(txtNombreCliente.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void textDirrecion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtDirrecion.Text.Trim() != string.Empty)
                {
                    txtSector.Focus();
                }
            }
        }

        private void textDirrecion_Leave(object sender, EventArgs e)
        {
            if (txtDirrecion.Text.Trim() != string.Empty)
            {
                txtDirrecion.Text = Convert.ToInt32(txtDirrecion.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void txtSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtSector.Text.Trim() != string.Empty)
                {
                    txtEdificio.Focus();
                }
            }
        }

        private void txtSector_Leave(object sender, EventArgs e)
        {
            if (txtSector.Text.Trim() != string.Empty)
            {
                txtSector.Text = Convert.ToInt32(txtSector.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void txtEdificio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtEdificio.Text.Trim() != string.Empty)
                {
                    txtCuidad.Focus();
                }
            }
        }

        private void txtEdificio_Leave(object sender, EventArgs e)
        {
            if (txtEdificio.Text.Trim() != string.Empty)
            {
                txtEdificio.Text = Convert.ToInt32(txtEdificio.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void txtCuidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtCuidad.Text.Trim() != string.Empty)
                {
                    txtTelefCasa.Focus();
                }
            }
        }

        private void txtCuidad_Leave(object sender, EventArgs e)
        {
            if (txtCuidad.Text.Trim() != string.Empty)
            {
                txtCuidad.Text = Convert.ToInt32(txtCuidad.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void textTelefCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtTelefCasa.Text.Trim() != string.Empty)
                {
                    txtTelefMovil.Focus();
                }
            }
        }

        private void textTelefCasa_Leave(object sender, EventArgs e)
        {
            if (txtTelefCasa.Text.Trim() != string.Empty)
            {
                txtTelefCasa.Text = Convert.ToInt32(txtTelefCasa.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void textTelefMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtTelefMovil.Text.Trim() != string.Empty)
                {
                    textContacto.Focus();
                }
            }
        }

        private void textTelefMovil_Leave(object sender, EventArgs e)
        {
            if (txtTelefMovil.Text.Trim() != string.Empty)
            {
                txtTelefMovil.Text = Convert.ToInt32(txtTelefMovil.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void textContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtTelefMovil.Text.Trim() != string.Empty)
                {
                    textCorreoElectronico.Focus();
                }
            }
        }

        private void textContacto_Leave(object sender, EventArgs e)
        {
            if (textContacto.Text.Trim() != string.Empty)
            {
                textContacto.Text = Convert.ToInt32(textContacto.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

        private void textCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (textCorreoElectronico.Text.Trim() != string.Empty)
                {
                    btnConsultaCliente.Focus();
                }
            }
        }

        private void textCorreoElectronico_Leave(object sender, EventArgs e)
        {
            if (textCorreoElectronico.Text.Trim() != string.Empty)
            {
                textCorreoElectronico.Text = Convert.ToInt32(textCorreoElectronico.Text).ToString("000"); // formatea el textbox txtClase con 3 digitos numericos

                txtSecuencia.Text = SecuenciaDelCliente(Convert.ToString(txtClase.Text));
            }
        }

    

        private void bntBorrar_Click(object sender, EventArgs e)
        {
            if (ClienteExiste==true)
             BorrarInformation(Convert.ToString(txtClase));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClienteExiste = false;
            LimpiarEsteFormulario();  // viaja hasta la funcion LimpiarEsteFormulario() y ejecuta su contenido
            txtClase.Focus();

        }

        // ===============================================================================================
        // Metodos
        // ===============================================================================================
        private static string SecuenciaDelCliente(string numeroSecuencia)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("SELECT SECUENCIA  FROM CLASE_DOC  WHERE CLASE = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numeroSecuencia);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            {
                int secuencia = Convert.ToInt32(rdr["SECUENCIA"]);
                secuencia = secuencia + 1;

                return secuencia.ToString("00000000");
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        private void BuscarCliente()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();  // aqui abre la conexion a la base de datos

            // ejecuta el script de sql por medio del objecto de comando cmmnd
            SqlCommand cmmnd = new SqlCommand("SELECT Clasifica,Secuencia,	Cliente,	Nombre,	    Direccion,	Sector, " +
                                              "       Ciudad,    	Edificio,	Tel_Casa,	Tel_Movil,	CorreoElectronico, " +
                                              "       NombreDelContacto " +
                                              "  FROM CLIENTES   WHERE Cliente = @PV", cnxn);  // crea el comando para ejecutar el script de sql

            // por medio del textbox txtLocalidad le asigna valor al parametro @PV 
            cmmnd.Parameters.AddWithValue("@PV", txtSecuencia.Text);

            // ejecuta el query
            SqlDataReader recordn = cmmnd.ExecuteReader();

            ClienteExiste = false;

            if (recordn.Read())
            {
                ClienteExiste = true;
                // coloca aqui los textbox a llenar
                txtClase.Text = Convert.ToString(recordn["CLASIFICA"]);
                txtSecuencia.Text = Convert.ToString(recordn["SECUENCIA"]);
                txtNombreCliente.Text = Convert.ToString(recordn["NOMBRECLIENTE"]);
                txtDirrecion.Text = Convert.ToString(recordn["DIRRECION"]);
                txtSector.Text = Convert.ToString(recordn["SECTOR"]);
                txtEdificio.Text = Convert.ToString(recordn["EDIFICIO"]);
                txtCuidad.Text = Convert.ToString(recordn["CUIDAD"]);
                txtTelefCasa.Text = Convert.ToString(recordn["TELEFCASA"]);
                txtTelefMovil.Text = Convert.ToString(recordn["TELFMOVIL"]);
                textContacto.Text = Convert.ToString(recordn["CONCTATO"]);
                textCorreoElectronico.Text = Convert.ToString(recordn["CORREO"]);
            }
        }
      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // ========================================================================
            // coloca aqui guardar en la tabla cliente
            // ========================================================================




            // ========================================================================
            // Actualiza Secuencia en la tabla Clasifica_Cte
            // ========================================================================
            if (ClienteExiste == false)
            {
                SqlConnection cnUpdate = new SqlConnection(cnn.db);
                cnUpdate.Open();   // aqui abre la base de datos

                // ejecuta el script de sql por medio del objecto de comando miQueri
                SqlCommand miUpdate = new SqlCommand("UPDATE Clasifica_Cte  SET Secuencia = @A1  FROM Clasifica_Cte  WHERE Clasifica =@A0", cnUpdate);

                miUpdate.Parameters.AddWithValue("@A0", Convert.ToString(txtClase.Text));            // asignado valor al paramentro @A1 mediante los textbox
                miUpdate.Parameters.AddWithValue("@A1", Convert.ToString(txtSecuencia.Text));        // asignado valor al paramentro @A0 mediante los textbox

                miUpdate.ExecuteNonQuery(); // ejecuta el query
                cnUpdate.Close();           // cierra la conexion a la base de datos
            }

            ClienteExiste = false;
        }

    
        private void LimpiarEsteFormulario()
        {
            // -----------------------------
            // Limpia los textBox and Label
            // -----------------------------
            txtClase.Clear();
            txtSecuencia.Clear();
            txtNombreCliente.Clear();
            txtDirrecion.Clear();
            txtSector.Clear();
            txtEdificio.Clear();
            txtCuidad.Clear();
            txtTelefCasa.Clear();
            txtTelefMovil.Clear();
            textContacto.Clear();
            textCorreoElectronico.Clear();

        }
        private void BorrarInformation(string Clasifica)
        {
            SqlConnection cnndel = new SqlConnection(cnn.db);
            cnndel.Open();  // aqui abre la base de datos

            // aqui se arma el script de sql y contiene un parametro @RG
            // string miQuery = "DELETE FROM POSICIONES WHERE IDPOSICION = @RG;";

            SqlCommand queri = new SqlCommand("DELETE FROM Clientes Where  Clasifica=@PV", cnndel);  // crea el comando para ejecutar el script de sql
            
            queri.Parameters.AddWithValue("@RG", Clasifica);// aqui se le envia la data contenida en numPosicion al parametro @RG
            queri.ExecuteNonQuery();                             // ejecuta el query

            cnndel.Close();
        }

    }

}
