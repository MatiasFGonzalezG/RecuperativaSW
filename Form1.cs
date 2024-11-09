using EvaluaciónRecuperativa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_Click(object sender, EventArgs e)
        {
            string pinIngresado = textBox_PIN.Text;  // Aquí almacenamos el PIN ingresado por el usuario

            if (pinIngresado == "123123" && pinIngresado.Length == 6 && pinIngresado.All(char.IsDigit))
            {
                // Si el PIN es correcto, abrir la siguiente ventana
                Productos mantenimientoForm = new Productos();
                mantenimientoForm.Show();
                this.Hide();  // Ocultar la ventana de bienvenida
            }
            else
            {
                MessageBox.Show("PIN incorrecto, intente nuevamente.");
            }
        }
    }
}
