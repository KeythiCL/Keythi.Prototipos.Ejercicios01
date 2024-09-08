using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keythi.Prototipos.Ejercicios01.DatosDeUnaPersona
{
    public partial class DatosDeUnaPersonaForm : Form
    {
        private DatosDeUnaPersonaModelo modelo = new();

        public DatosDeUnaPersonaForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var persona = new Persona();
            // creo objeto persona

            if(!int.TryParse(TxtDocumento.Text, out int documento))
            {
                MessageBox.Show("El documento no es numérico");
                return;
            }

            if(!DateTime.TryParse(TxtFechaNacimiento.Text, out  DateTime fechaNacimiento))
            {
                MessageBox.Show("La fecha de nacimiento no es válida");
                return;
            }

            // le paso los datos de la pantalla:
            persona.Dni = documento;
            persona.Apellido = TxtApellido.Text;
            persona.Nombre = TxtNombre.Text;
            persona.FechaNacimiento = fechaNacimiento;

            var error = modelo.IngresarPersona(persona);
            if(error == null)
            {
                MessageBox.Show("Datos ingresos correctamente.");
            }
            else
            {
                MessageBox.Show(error);
            }
        }
    }
}
