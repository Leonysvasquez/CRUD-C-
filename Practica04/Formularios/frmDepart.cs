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
    public partial class frmDepart : Form
    {
        string IDdepartamento;
        string NombreDepartamento;
        string IDfabrica;
        public frmDepart()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

            SqlCommand queri = new SqlCommand("DELETE FROM DEPARTAMENTO WHERE IDdepartamento = @RG;", cnndel);  // crea el comando para ejecutar el script de sql
            queri.Parameters.AddWithValue("@RG", numPosicion);   // aqui se le envia la data contenida en numPosicion al parametro @RG
            queri.ExecuteNonQuery();                             // ejecuta el query

            cnndel.Close();                                      // cierra la conexion a la base de datos
        }

        private void GuardarInformacion()
        {
            SqlConnection cnGuardar = new SqlConnection(cnn.db);
            cnGuardar.Open();   // aqui abre la base de datos

            // script sql para insertar data dentro de la tabla POSICIONES por medio de parametros de entrada
            string stQuery = "INSERT INTO FABRICA (IDposicion, NombreDePosicion, Fabrica, Departamento ) VALUES (@A0, @A1, @A2,@A3);";
            SqlCommand miqueri = new SqlCommand(stQuery, cnGuardar); // crea el comando para ejecutar el script de sql

            miqueri.Parameters.AddWithValue("@A0", Convert.ToString(txtDepartamento.Text));        // asignado valor al paramentro mediante los textbox
            miqueri.Parameters.AddWithValue("@A1", Convert.ToString(txtNombreDepto.Text));
            miqueri.Parameters.AddWithValue("@A2", Convert.ToString(txtFabrica.Text));
            miqueri.Parameters.AddWithValue("@A2", Convert.ToString(txtDepartamento.Text));
           

            miqueri.ExecuteNonQuery(); // ejecuta el query
            cnGuardar.Close();         // cierra la conexion a la base de datos
        }

        private void buscar_datos()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("SELECT * FROM DEPARTAMENTO A LEFT JOIN FABRICA  B ON A.NombreDepartamento = B.NombreDefabrica", cnxn);

            cmmnd.Parameters.AddWithValue("@PV", txtFabrica.Text);

            SqlDataReader recordn = cmmnd.ExecuteReader();

            if (recordn.Read())
            {
                // los campos que contienen la data extraida de la tabla es asignado a cada elemento correspondiente
                txtNombreDepto.Text = Convert.ToString(recordn["NOMBREDEPARTAMENTO"]);
                txtFabrica.Text = Convert.ToString(recordn["FABRICA"]);


                lblFabricaNombre.Text = Convert.ToString(recordn["NombreDeLocalidad"]);

            }

            cmmnd.Dispose();  // libera el sqlcommand 
            cnxn.Close();   // cierra la conexion a la base de datos
        }
        private void LimpiarEsteFormulario()
        {
            // -----------------------------
            // Limpia los textBox and Label
            // -----------------------------
            txtDepartamento.Clear();
            txtNombreDepto.Clear();
            txtFabrica.Clear();
            lblFabricaNombre.Text = "";

        }

        private void frmDepart_Load(object sender, EventArgs e)
        {
            this.Text = HMenu.cia + " Maestro de Departamento ";
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtDepartamento.Text.Trim() != string.Empty)
                {
                    txtNombreDepto.Focus();
                }
            }
        }

        private void txtDepartamento_Leave(object sender, EventArgs e)
        {
            if (txtDepartamento.Text.Trim() != string.Empty)
            {
                // ----------------------------------------------------------------------
                // Busco.NombreDepartamento
                // Busco...                                  es la clase que se esta invocando
                // NombreDepartamento...                     es el metodo dento de la clase
                // Convert.ToString(txtDepartamento.Text)... es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                txtNombreDepto.Text = Busco.Departamento(Convert.ToString(txtDepartamento.Text)); // valor retornado por la clase es asignado al TextBox
            }
        }

        private void txtNombreDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtNombreDepto.Text.Trim() != string.Empty)
                {
                    // mueve el cursor al textbox txtDepartamento
                    txtFabrica.Focus();
                }
            }
        }

        private void txtNombreDepto_Leave(object sender, EventArgs e)
        {
            txtFabrica.Focus();
        }

        private void txtFabrica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtFabrica.Text.Trim() != string.Empty)
                {
                    // mueve el cursor al textbox txtDepartamento
                    btnGuardar.Focus();
                }
            }
        }

        private void txtFabrica_Leave(object sender, EventArgs e)
        {
            if (txtFabrica.Text.Trim() != string.Empty)
            {
                // ----------------------------------------------------------------------
                // Busco.NombreDepartamento
                // Busco...                                  es la clase que se esta invocando
                // Fabrica...                                es el metodo dento de la clase
                // Convert.ToString(txtFabrica.Text)...      es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                IDfabrica = Busco.Fabrica(Convert.ToString(txtFabrica.Text));
                lblFabricaNombre.Text = IDfabrica;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarInformacion(Convert.ToString(txtDepartamento.Text));  // Borra la informacion en la tabla POSICIONES en la base de datos antes de grabar
            // y se envia Convert.ToString(txtPosicion.Text) como parametro que es recibido 
            // por la funcion BorrarInformacion.

            GuardarInformacion();                                   // Inserta la informacion en la tabla POSICIONES en la base de datos
            btnLimpiar.PerformClick();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarEsteFormulario();  // viaja hasta la funcion LimpiarEsteFormulario() y ejecuta su contenido
            txtDepartamento.Focus();
        }

        private void bntBorrar_Click(object sender, EventArgs e)
        {
            // Borra la informacion en la tabla POSICIONES en la base de datos antes de grabar
            // y se envia Convert.ToString(txtPosicion.Text) como parametro que es recibido 
            // por la funcion BorrarInformacion.
            BorrarInformacion(Convert.ToString(txtDepartamento.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario
        }

        private void btnConsultaDepto_Click(object sender, EventArgs e)
        {
            {
                txtDepartamento.Focus();  // el curso se queda en el textbox txtdepartamento

                // creo el objeto frm y se le asigna el formulario frmVENDEPTO al objeto
                frmVENDEPTO frm = new frmVENDEPTO();

                DialogResult res = frm.ShowDialog();  // aqui muestra la ventana
                                                      // res = obtiene el valor de la ventana de consulta abierta
                                                      // obtendra el valor de ok cuando cierre la ventana

                if (res == DialogResult.OK)           // aqui pregunta que si res es igual a ok ejecute el siguiente codigo
                {
                    txtDepartamento.Text = frm.varf1; // txtdepartamento se le asignara el valor contenido en la variable varf1
                    txtNombreDepto.Text = frm.varf2; // txtdepartamento se le asignara el valor contenido en la variable varf2
                }
            }
        }

        private void btnConsultaFabrica_Click(object sender, EventArgs e)
        {
            {
                txtNombreDepto.Focus();  // el curso se queda en el textbox txtdepartamento

                // creo el objeto frm y se le asigna el formulario frmVENDEPTO al objeto
                frmVENFABRICA frm = new frmVENFABRICA();

                DialogResult res = frm.ShowDialog();  // aqui muestra la ventana
                                                      // res = obtiene el valor de la ventana de consulta abierta
                                                      // obtendra el valor de ok cuando cierre la ventana

                if (res == DialogResult.OK)           // aqui pregunta que si res es igual a ok ejecute el siguiente codigo
                {
                    txtFabrica.Text = frm.varf1; // txtdepartamento se le asignara el valor contenido en la variable varf1
                    lblFabricaNombre.Text = frm.varf2; // txtdepartamento se le asignara el valor contenido en la variable varf2
                }
            }
        }
    }
}
