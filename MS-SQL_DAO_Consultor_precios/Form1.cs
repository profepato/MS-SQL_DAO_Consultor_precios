using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_SQL_DAO_Consultor_precios.Model;

namespace MS_SQL_DAO_Consultor_precios {
    public partial class Form1 : Form {
        private DAO_Producto dp;
        
        public Form1() {
            InitializeComponent();
            dp = new DAO_Producto();

            gridProductos.DataSource = dp.Read();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            Producto p = new Producto();

            p.Descripcion = txtDescripcion.Text;
            p.Precio = int.Parse(txtPrecio.Text);

            if (txtPrecioOferta.Text.Trim() == "") {
                p.PrecioOferta = "Sin Oferta";
            } else {
                p.PrecioOferta = txtPrecioOferta.Text;
            }

            dp.Create(p);
            gridProductos.DataSource = dp.Read();

            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtPrecioOferta.Text = "";

            txtDescripcion.Focus();
        }

        private void btnCargar_Click(object sender, EventArgs e) {
            gridProductos.DataSource = dp.Read();
        }

        private void txtIdBuscar_TextChange(object sender, EventArgs e) {
            String id = txtIdBuscar.Text;
            if (id.Count() == 36) {
                txtIdBuscar.Text = "";
                txtIdBuscar.Focus();
                txtId.Text = id;

                DataTable dt = dp.Read(id);

                // si existen filas en la tabla
                // si se encontró el producto
                if (dt.Rows.Count != 0) {
                    gridProductos.DataSource = dt;

                    txtDescripcion.Text = dt.Rows[0][1].ToString();
                    txtPrecio.Text = "$ "+dt.Rows[0][2].ToString();
                    txtPrecioOferta.Text = dt.Rows[0][3].ToString();

                    // En System.Drawing
                    if (txtPrecioOferta.Text == "Sin Oferta") {
                        // Rojo
                        txtPrecioOferta.BackColor = ColorTranslator.FromHtml("#cc0000");
                    } else {
                        // Verde
                        txtPrecioOferta.BackColor = ColorTranslator.FromHtml("#33cc33");
                    }
                } else {
                    txtDescripcion.Text = "No existe en la base de datos";
                    txtPrecio.Text = "0";
                    txtPrecioOferta.Text = "Sin Oferta";

                    gridProductos.DataSource = dp.Read();
                }
            }
        }
    }
}
