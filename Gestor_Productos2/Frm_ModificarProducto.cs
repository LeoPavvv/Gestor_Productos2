using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Productos2
{
    public partial class Frm_ModificarProducto : Form
    {
        Producto p;
        public Frm_ModificarProducto(Producto selectedProduct)
        {
            InitializeComponent();

            if(selectedProduct == null)
            {
                MessageBox.Show("No se ha seleccionado ningun producto para editar.");
                this.Close();
                return;
            }

            p = selectedProduct;
            mostrarValores();
        }

        public void mostrarValores()
        {
            txtId.Text = p.Id.ToString();
            txtDescripcion.Text = p.descripcion;
            txtPrecio.Text = p.precio.ToString("0.00");
        }

        private void Frm_ModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            p.descripcion = txtDescripcion.Text;
            p.precio = Decimal.Parse(txtPrecio.Text);

            int a = RepositorioGlobal.repositorio.FindIndex(p => p.Id == int.Parse(txtId.Text));

            RepositorioGlobal.repositorio[a] = p;

            MessageBox.Show(RepositorioGlobal.repositorio[a].ToString());
            this.DialogResult = DialogResult.OK;

            this.Close();
            
        }
    }
}
