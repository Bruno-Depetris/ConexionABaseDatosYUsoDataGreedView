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



        }

        private void ConfigurarColumnas() {
            // Configurar el orden de las columnas de datos
            dataGridView_datos.Columns["id"].DisplayIndex = 0;
            dataGridView_datos.Columns["nombre"].DisplayIndex = 1;
            dataGridView_datos.Columns["apellido"].DisplayIndex = 2;
            dataGridView_datos.Columns["direccion"].DisplayIndex = 3;
            dataGridView_datos.Columns["telefono"].DisplayIndex = 4;

            // Configurar las columnas de botones para que estén al final
            dataGridView_datos.Columns["Edit"].DisplayIndex = 5;
            dataGridView_datos.Columns["Delete"].DisplayIndex = 6;
            dataGridView_datos.Columns["Print"].DisplayIndex = 7;
        }


        private void AgregarColumnasBotones() {
            // Agregar la columna de Editar
            if (!dataGridView_datos.Columns.Contains("Edit")) {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "Edit";
                btnEdit.HeaderText = "Editar";
                btnEdit.Text = "Editar";
                btnEdit.UseColumnTextForButtonValue = true;
                dataGridView_datos.Columns.Add(btnEdit);
            }

            // Agregar la columna de Borrar
            if (!dataGridView_datos.Columns.Contains("Delete")) {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.HeaderText = "Borrar";
                btnDelete.Text = "Borrar";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView_datos.Columns.Add(btnDelete);
            }

            // Agregar la columna de Imprimir
            if (!dataGridView_datos.Columns.Contains("Print")) {
                DataGridViewButtonColumn btnPrint = new DataGridViewButtonColumn();
                btnPrint.Name = "Print";
                btnPrint.HeaderText = "Imprimir";
                btnPrint.Text = "Imprimir";
                btnPrint.UseColumnTextForButtonValue = true;
                dataGridView_datos.Columns.Add(btnPrint);
            }
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
            // Limpiar la fuente de datos actual
            dataGridView_datos.DataSource = null;

            // Obtener los datos
            var datos = LogicaUsuario.Instancia.Listar();

            // Asignar la nueva fuente de datos
            dataGridView_datos.DataSource = datos;

            // Agregar columnas de botones si no están presentes
            AgregarColumnasBotones();

            // Configurar el orden de las columnas
            ConfigurarColumnas();
        }


        private void Form1_Load(object sender, EventArgs e) {
            MostrarDatos();
        }

        private void dataGridView_datos_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
    {
        string columnName = dataGridView_datos.Columns[e.ColumnIndex].Name;

        switch (columnName)
        {
            case "Edit":
                EditarFila(e.RowIndex);
                break;
            case "Delete":
                BorrarFila(e.RowIndex);
                break;
            case "Print":
                ImprimirFila(e.RowIndex);
                break;
        }
    }
}

private void EditarFila(int rowIndex)
{
    var selectedRow = dataGridView_datos.Rows[rowIndex];
    // Lógica para editar la fila
    MessageBox.Show("Editar fila: " + selectedRow.Index);
}

private void BorrarFila(int rowIndex)
{
    var result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo);
    if (result == DialogResult.Yes)
    {
        dataGridView_datos.Rows.RemoveAt(rowIndex);
        MessageBox.Show("Fila eliminada");
    }
}

private void ImprimirFila(int rowIndex)
{
    var selectedRow = dataGridView_datos.Rows[rowIndex];
    // Lógica para imprimir la fila
    MessageBox.Show("Imprimir fila: " + selectedRow.Index);
}

    }

}
