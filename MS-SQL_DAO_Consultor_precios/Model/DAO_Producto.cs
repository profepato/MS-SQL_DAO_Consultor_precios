using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Using requerido*/
using System.Data;
/*Using requerido*/

namespace MS_SQL_DAO_Consultor_precios.Model {
    class DAO_Producto : Conexion, DAO<Producto> {

        public DAO_Producto() : base("consultor_precios") {
        }

        public void Create(Producto ob) {
            Ejecutar("INSERT INTO Producto " +
                "VALUES(NEWID(), " +
                "'"+ob.Descripcion+"'," +
                "'"+ob.Precio+"'," +
                "'"+ob.PrecioOferta+"');");
        }

        public void Delete(string id) {
        }

        public DataTable Read() {
            return Ejecutar("SELECT * FROM Productos ORDER BY 'Descripción'");
        }

        public void Update(Producto ob) {
        }

        public DataTable Read(String id) {
            return Ejecutar("SELECT * FROM Productos WHERE id = '"+id+"'");
        }
    }
}
