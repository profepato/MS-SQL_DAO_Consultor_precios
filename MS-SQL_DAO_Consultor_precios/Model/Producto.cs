using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_SQL_DAO_Consultor_precios.Model {
    class Producto {
        private String id;
        private String descripcion;
        private int precio;
        private String precioOferta;

        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public string PrecioOferta { get => precioOferta; set => precioOferta = value; }
    }
}
