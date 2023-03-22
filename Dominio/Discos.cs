using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Discos
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagen { get; set; }
        public Estilos Estilo { get; set; }
        public TiposEdicion Formato { get; set; }

    }
}
