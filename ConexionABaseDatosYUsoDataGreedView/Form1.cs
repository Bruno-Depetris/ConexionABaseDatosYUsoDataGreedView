using ConexionABaseDatosYUsoDataGreedView.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionABaseDatosYUsoDataGreedView.Logica;
using System.Web;
using System.Drawing.Drawing2D;
using System.Threading;

namespace ConexionABaseDatosYUsoDataGreedView {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            dataGridView_datos.ReadOnly = true;

            dataGridView_datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta al espacio disponible
            dataGridView_datos.AutoResizeColumns(); // Ajusta al contenido


        }
        private string nombreValidado = string.Empty;
        private string apellidoValidado = string.Empty;
        private string direccionValidada = string.Empty;
        private int telefonoValidado = 0;

        private bool validacionDatos() {
            bool retorno = true;

            if (string.IsNullOrEmpty(textBox_nombre.Text)) {
                MessageBox.Show("Error al ingresar nombre \n por favor revise los datos");
                textBox_nombre.Clear();
                textBox_nombre.Focus();
                return retorno = false; 
            }
            if (string.IsNullOrEmpty(textBox_apellido.Text)) {
                MessageBox.Show("Error al ingresar Apellido \n por favor revise los datos");
                textBox_apellido.Clear();
                textBox_apellido.Focus();

                return retorno = false;
            }
            if (string.IsNullOrEmpty(textBox_direccion.Text)) {
                MessageBox.Show("Error al ingresar Direccion \n por favor revise los datos");
                textBox_direccion.Clear();
                textBox_direccion.Focus();
                return retorno = false;
            }
            if (textBox_telefono.Text.Length != 10 && !textBox_telefono.Text.All(char.IsDigit)) {
                MessageBox.Show("Error al ingresar Telefono \n por favor revise los datos");
                textBox_telefono.Clear();
                textBox_telefono.Focus();
                return retorno = false;
            }
            
            nombreValidado = textBox_nombre.Text;
            apellidoValidado = textBox_apellido.Text;
            direccionValidada = textBox_direccion.Text;
            telefonoValidado = int.Parse(textBox_telefono.Text);

            textBox_nombre.Clear();
            textBox_apellido.Clear();   
            textBox_direccion.Clear();
            textBox_telefono.Clear();

            textBox_nombre.Focus();
            MessageBox.Show("Datos guardados con exito");

            return retorno = true;

        }
        private void button_cargarDatos_Click(object sender, EventArgs e) {

            if (validacionDatos()) {
                Usuario usuario = new Usuario() {
                    nombre = nombreValidado,
                    apellido = apellidoValidado,
                    direccion = direccionValidada,
                    telefono = telefonoValidado
                };

                bool respuesta = LogicaUsuario.Instancia.Guardar(usuario);

                if (respuesta) {
                    MessageBox.Show("datos guardados en la base de datos");

                }
            }
            MostrarDatos();

        }

        public void MostrarDatos() {
            dataGridView_datos.DataSource = string.Empty;
         
            dataGridView_datos.DataSource = LogicaUsuario.Instancia.Listar();
            

        }

        private void Form1_Load(object sender, EventArgs e) {
            MostrarDatos();
        }
    }
}
