using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace NegocioDatos
{
    public class DatosDiscos
    {
        private Discos discos;
        public List<Discos> listarDiscos()
        {
            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lectura;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true"; 
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Formato, D.IdEstilo, D.IdTipoEdicion From DISCOS D, ESTILOS E, TIPOSEDICION T Where E.id = D.IdEstilo AND T.Id = D.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lectura = comando.ExecuteReader();

                while (lectura.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)lectura["Id"];
                    aux.Titulo = (string)lectura["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lectura["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lectura["CantidadCanciones"];
                    if (!(lectura["UrlImagenTapa"] is DBNull))
                    {
                        aux.UrlImagen = (string)lectura["UrlImagenTapa"];
                    }
                    aux.Estilo = new Estilos();
                    aux.Estilo.Id = (int)lectura["IdEstilo"];
                    aux.Estilo.Descripcion = (string)lectura["Estilo"];
                    aux.Formato = new TiposEdicion();
                    aux.Formato.Id = (int)lectura["IdTipoEdicion"];
                    aux.Formato.Descripcion = (string)lectura["Formato"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;       
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AgregarDisco(Discos valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo,IdTipoEdicion) values (@Titulo, @FechaLanzamiento, @CantidadCanciones, @UrlImagenTapa, @IdEstilo, @IdTipoEdicion)");
                datos.setearParametros("@Titulo", valor.Titulo);
                datos.setearParametros("@FechaLanzamiento", valor.FechaLanzamiento);
                datos.setearParametros("@CantidadCanciones", valor.CantidadCanciones);
                datos.setearParametros("@UrlImagenTapa", valor.UrlImagen);
                datos.setearParametros("@IdEstilo", valor.Estilo.Id);
                datos.setearParametros("@IdTipoEdicion", valor.Formato.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void ModificarDisco(Discos valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update DISCOS set Titulo = @titulo, FechaLanzamiento = @Date, CantidadCanciones = @cantCan, UrlImagenTapa = @url, IdEstilo = @idEstilo, IdTipoEdicion = @IdEdicion where id = @id");
                datos.setearParametros("@titulo", valor.Titulo);
                datos.setearParametros("@Date", valor.FechaLanzamiento);
                datos.setearParametros("@cantCan", valor.CantidadCanciones);
                datos.setearParametros("@url", valor.UrlImagen);
                datos.setearParametros("@idEstilo", valor.Estilo.Id);
                datos.setearParametros("@IdEdicion", valor.Formato.Id);
                datos.setearParametros("@id", valor.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from DISCOS where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Discos> FiltroAvanzado(string filtro, string seleccion, string fecha)
        {
            List<Discos> listaDisco = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion Estilo, T.Descripcion Formato, D.IdEstilo, D.IdTipoEdicion From DISCOS D, ESTILOS E, TIPOSEDICION T Where E.id = D.IdEstilo AND T.Id = D.IdTipoEdicion AND ";
                switch (seleccion)
                {
                    case "Titulo":
                        consulta += "Titulo like '" + filtro + "%'";
                            break;
                    case "Fecha de lanzamiento":
                        consulta += "FechaLanzamiento = '" + fecha + "'";
                        break;
                    case "Cantidad de canciones":
                        consulta += "CantidadCanciones = " + filtro;
                        break;
                    case "Estilo":
                        consulta += "E.Descripcion like '" + filtro + "%'";
                        break;
                    default:
                        consulta += "T.Descripcion like '" + filtro + "%'";
                        break;
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilos();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Formato = new TiposEdicion();
                    aux.Formato.Id = (int)datos.Lector["IdEstilo"];
                    aux.Formato.Descripcion = (string)datos.Lector["Formato"];

                    listaDisco.Add(aux);
                }
                return listaDisco;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
