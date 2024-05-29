using Solucion___Practica.Datos;
using Solucion___Practica.Dominio;
using Solucion___Practica.Servicios;

namespace Solucion___Practica
{
    public partial class Form1 : Form
    {
        private IServicio servicio;
        OrdenRetiro ordenRetiro;
        public Form1()
        {
            InitializeComponent();
            servicio = new FactoryServiceImp().GetServicio();
            ordenRetiro = new OrdenRetiro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetMateriales();
        }

        private void GetMateriales()
        {
            List<Parameter> lPs = new List<Parameter>();
            List<Material> lMs = servicio.GetMateriales(lPs);
            cboMateriales.DataSource = lMs;
            cboMateriales.ValueMember = "Codigo";
            cboMateriales.DisplayMember = "Nombre";
            cboMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Material m = (Material)cboMateriales.SelectedItem;
            DetalleOrden d = new DetalleOrden(m, (int)nudCantidad.Value);
            ordenRetiro.AddDetalles(d);
            dgvDetalles.Rows.Add(new object[] { m.Nombre, m.Stock, nudCantidad.Value });
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ordenRetiro.Responsable = txtResponsable.Text;
            servicio.Save(ordenRetiro);
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                ordenRetiro.RemoveDetalles(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que querés salir capo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Dispose();
            else
                return;
        }
    }
}