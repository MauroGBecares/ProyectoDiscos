using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDatos
{
    public class DatosEdiciones
    {
        public List<TiposEdicion> listaEdiciones()
        {
            List<TiposEdicion> lista = new List<TiposEdicion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From TIPOSEDICION");
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    TiposEdicion aux = new TiposEdicion();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                    return lista;
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
    }
}
