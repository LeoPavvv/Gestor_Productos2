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
    public partial class Frm_principal : Form
    {
        private Producto selectedProduct;
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form1 frm = new Form1())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cargarGrilla();
                    MessageBox.Show("Producto agregado con exito");
                }
            }
        }

        public void cargarGrilla()
        {
            grilla.DataSource = null;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToOrderColumns = false;
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.DataSource = RepositorioGlobal.repositorio.ToList();
        }

        private void Frm_principal_Load_1(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (grilla.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grilla.SelectedRows[0];

                Producto selectedProduct = new Producto
                {
                    Id = int.Parse(row.Cells["Id"].Value.ToString()),
                    descripcion = row.Cells["descripcion"].Value.ToString(),
                    precio = Math.Round(Decimal.Parse(row.Cells["precio"].Value.ToString()), 2)
                };

                using (Frm_ModificarProducto frm = new Frm_ModificarProducto(selectedProduct))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cargarGrilla();
                        MessageBox.Show("Producto modificado con exito");
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(grilla.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grilla.SelectedRows[0];

                int id = int.Parse(row.Cells["Id"].Value.ToString());

                Producto p = RepositorioGlobal.repositorio.FirstOrDefault(pr => pr.Id == id);
                RepositorioGlobal.repositorio.Remove(p);
                cargarGrilla();
                MessageBox.Show("Producto eliminado con exito");

            }
        }
    }
}
