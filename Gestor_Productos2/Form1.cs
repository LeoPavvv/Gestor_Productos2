namespace Gestor_Productos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            p.Id = int.Parse(txtId.Text);
            p.precio = Decimal.Parse(txtPrecio.Text);
            p.descripcion = txtDescripcion.Text;

            RepositorioGlobal.repositorio.Add(p);

            MessageBox.Show(p.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
