using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ConexionABaseDatosYUsoDataGreedView.Modelo;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;

namespace ConexionABaseDatosYUsoDataGreedView.Logica {
    public class LogicaUsuario {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString; //cadena de donde trae la configuracion 

        private static LogicaUsuario _LogicaUsuario = null;

        public LogicaUsuario() {


        }

        public static LogicaUsuario Instancia {
            get {
                if (_LogicaUsuario == null) {
                    _LogicaUsuario = new LogicaUsuario();
                }
                return _LogicaUsuario;
            }

        }

        public bool Guardar(Usuario obj) {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {

                conexion.Open(); //abro la conexion de la base de datos

                // creo mi query sirve para hacer la sintaxis para comunicarse con  la base de datos
                string query = "INSERT INTO Usuarios (Nombre, Apellido, Direccion, Telefono) VALUES (@nombres , @apellidos, @direcciones, @telefonos)";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombres", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellidos", obj.apellido));
                cmd.Parameters.Add(new SQLiteParameter("@direcciones", obj.direccion));
                cmd.Parameters.Add(new SQLiteParameter("@telefonos", obj.telefono));


                if (cmd.ExecuteNonQuery() < 1) {
                    respuesta = false;
                    Console.WriteLine("Error en la consulta [GUARDAR]");

                } else {
                    Console.WriteLine("Datos guardados correctamente");
                }

            }

            return respuesta;

        }


        public List<Usuario> Listar() {
            List<Usuario> datosLista = new List<Usuario>();
            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {

                conexion.Open(); //abro la conexion de la base de datos
                string query = "SELECT UsuarioID, Nombre, Apellido, Direccion, Telefono FROM Usuarios";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        datosLista.Add(new Usuario() {

                            id = int.Parse(reader["UsuarioID"].ToString()),
                            nombre = reader["Nombre"].ToString(),
                            apellido = reader["Apellido"].ToString(),
                            direccion = reader["Direccion"].ToString(),
                            telefono = int.Parse(reader["Telefono"].ToString())


                        });
                    }
                }

            }

            return datosLista;
        }

        public bool Editar(Usuario obj) {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {

                conexion.Open(); //abro la conexion de la base de datos

                // creo mi query sirve para hacer la sintaxis para comunicarse con  la base de datos
                string query = "UPDATE Usuarios SET Nombre=@nombres, Apellidos=@apellido, Direccion=@direccion, Telefono=@telefono";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));
                cmd.Parameters.Add(new SQLiteParameter("@nombres", obj.nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellidos", obj.apellido));
                cmd.Parameters.Add(new SQLiteParameter("@direcciones", obj.direccion));
                cmd.Parameters.Add(new SQLiteParameter("@telefonos", obj.telefono));


                if (cmd.ExecuteNonQuery() < 1) {
                    respuesta = false;
                    Console.WriteLine("Error en la consulta [GUARDAR]");

                } else {
                    Console.WriteLine("Datos guardados correctamente");
                }

            }

            return respuesta;

        }

        public bool Eliminar(Usuario obj) {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {

                conexion.Open(); //abro la conexion de la base de datos

                // creo mi query sirve para hacer la sintaxis para comunicarse con  la base de datos
                string query = "DELETE FROM Usuarios WHERE ClienteID=@id";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.id));

                if (cmd.ExecuteNonQuery() < 1) {
                    respuesta = false;
                    Console.WriteLine("Error en la consulta [GUARDAR]");

                } else {
                    Console.WriteLine("Datos guardados correctamente");
                }

            }

            return respuesta;
        }

    }
}
