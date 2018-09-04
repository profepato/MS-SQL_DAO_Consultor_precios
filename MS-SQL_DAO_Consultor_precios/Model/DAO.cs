using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Using requerido*/
using System.Data;
/*Using requerido*/

namespace MS_SQL_DAO_Consultor_precios.Model {
    interface DAO<T> {
        void Create(T ob);
        DataTable Read();
        void Update(T ob);
        void Delete(String id);
    }
}
