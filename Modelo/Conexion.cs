using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Conexion
    {
        private MySqlBaseConnectionStringBuilder builder;
        private string cadenaConexion;

        public Conexion()
        {
            builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",        
                Port = 3306,                
                Database = "BibliotecaSena",
                UserID = "root",
                Password = "carlosmanuel",
                SslMode = MySqlSslMode.None,
            };
            cadenaConexion = builder.ConnectionString;
        }
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
        public async Task<int> EjecutarComandoAsyn(string consulta, MySqlParameter[] parametros = null)
        {
            try
            {
                using (var conn = new MySqlConnection(cadenaConexion))
                {
                    await conn.OpenAsync();
                    using (var comando = conn.CreateCommand())
                    {
                        comando.CommandText = consulta;
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }
                        return await comando.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la ejecucion " + ex.Message);
            }
        }
        public int EjecutarComando(string consulta, MySqlParameter[] parametros = null)
        {
            try
            {
                using (var conn = new MySqlConnection(cadenaConexion))
                {
                    conn.Open();
                    using (var comando = conn.CreateCommand())
                    {
                        comando.CommandText = consulta;

                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }

                        return comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar comando: " + ex.Message);
            }
        }
        public MySqlDataReader EjecutarConsulta(string consulta, MySqlParameter[] parametros = null)
        {
            try
            {
                var conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                var comando = conn.CreateCommand();

                comando.CommandText = consulta;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros);
                }
                return comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


            }
            catch (Exception ex)
            {
                throw new Exception("Error en la ejecucion " + ex.Message);
            }
        }
        public async Task CrearTabla()
        {


            using (var conn = new MySqlConnection(cadenaConexion))
            {
                Console.WriteLine("Opening connection");
                await conn.OpenAsync();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "DROP TABLE IF EXISTS libro;";
                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("Finished dropping table (if existed)");

                    command.CommandText = "CREATE TABLE libro (id serial PRIMARY KEY, nombre VARCHAR(50), editorial VARCHAR(50), precio INTEGER);";
                    await command.ExecuteNonQueryAsync();
                    Console.WriteLine("Finished creating table");


                }

                // connection will be closed by the 'using' block
                Console.WriteLine("Closing connection");
            }

            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();
        }
    }
}