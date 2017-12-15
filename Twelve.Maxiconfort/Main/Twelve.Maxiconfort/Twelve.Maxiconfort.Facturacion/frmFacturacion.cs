using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twelve.Maxiconfort.Core.Facade;
using Twelve.Maxiconfort.Model.Entities;

namespace Twelve.Maxiconfort.Facturacion
{
    public partial class frmFacturacion : Form
    {

        #region Propiedades

        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private int _Rol;

        public int Rol
        {
            get { return _Rol; }
            set { _Rol = value; }
        }
        #endregion Propiedades

        #region Contructor

        public frmFacturacion(string usuario, int rol)
        {
            this.Usuario = usuario;
            this.Rol = rol;
            InitializeComponent();
            lblNombreVendedor.Text = usuario;
        }

        #endregion Constructor

        #region Eventos Controles

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnImprimir.Visible = false;

            if (this.Rol == 2)
            {
                tabPanel.TabPages.RemoveAt(1);
            }
            this.rpvFacturasConsolidadas.RefreshReport();
            this.rpvFacturasConsolidadas.RefreshReport();
            this.rpvFacturasConsolidadas.RefreshReport();
            this.rpvFacturasConsolidadas.RefreshReport();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardar
                List<DetalleFactura> lstDetalleFactura = new List<DetalleFactura>();

                foreach (DataGridViewRow item in dgvProductos.Rows)
                {
                    if (item.Index + 1 < dgvProductos.Rows.Count)
                    {
                        if (item.Cells[0].Value == null)
                            throw new Exception("Ingrese la cantidad");
                        if (item.Cells[1].Value == null)
                            throw new Exception("Ingrese la referencia");
                        if (item.Cells[2].Value == null)
                            throw new Exception("Ingrese el valor del producto");

                        int cantidad = int.Parse(item.Cells[0].Value.ToString());
                        string producto = item.Cells[1].Value.ToString();
                        float valorUnitario = float.Parse(item.Cells[2].Value.ToString());

                        lstDetalleFactura.Add(new DetalleFactura()
                        {
                            Cantidad = cantidad,
                            Producto = producto,
                            ValorUnitario = valorUnitario,
                            ValorTotal = valorUnitario * cantidad
                        });
                    }
                }

                Factura objFactura = new Factura()
                {
                    CodigoFactura = "",
                    Fecha = DateTime.Now,
                    Usuario = lblNombreVendedor.Text,
                    DetalleFacturas = lstDetalleFactura,
                    Cliente = txtCliente.Text,
                    Direccion = txtDireccion.Text,
                    Nit = txtNit.Text,
                    Telefono = txtTelefono.Text
                };

                FacturacionFacade.SaveFactura(objFactura);

                DialogResult result = MessageBox.Show("Registro guardado con éxito. ¿Desea imprimir la Factura?. ", "Exitoso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    new frmImprimirFactura(objFactura.FacturaId).Show();
                }

                this.LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                    int cantidad;
                    float valorUnitario;

                    if (row.Cells[0].Value == null)
                        cantidad = 0;
                    else
                        cantidad = int.Parse(row.Cells[0].Value.ToString());

                    if (row.Cells[2].Value == null)
                        valorUnitario = 0;
                    else
                        valorUnitario = float.Parse(row.Cells[2].Value.ToString());

                    row.Cells[3].Value = valorUnitario * cantidad;


                    float acu = 0;
                    foreach (DataGridViewRow item in dgvProductos.Rows)
                    {
                        if (item.Index + 1 < dgvProductos.Rows.Count)
                        {
                            if (item.Cells[3].Value == null)
                                acu = 0;
                            else
                                acu += float.Parse(item.Cells[3].Value.ToString());
                        }
                    }

                    lblTotalTotal.Text = acu.ToString("C0");
                }
                catch
                {
                    MessageBox.Show("Ingrese un valor correcto");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar Campos
            LimpiarCampos();

            //Se habilitan los campos
            HabilitarCampos();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lklCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0 || cboTipo.SelectedIndex == 1)
            {
                cboPeriodos.Visible = false;
                dtpPeriodo.Visible = true;
            }
            else if (cboTipo.SelectedIndex == 2 || cboTipo.SelectedIndex == 3 || cboTipo.SelectedIndex == 4 || cboTipo.SelectedIndex == 5)
            {
                cboPeriodos.Visible = true;
                dtpPeriodo.Visible = false;

                var query = FacturacionFacade.GetPeriodos(cboTipo.SelectedIndex - 1);

                cboPeriodos.DataSource = query;
                cboPeriodos.ValueMember = "Periodo";
                cboPeriodos.DisplayMember = "Descripcion";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0)
            {
                //Diario
                this.SPGetFacturasConsolidadoByFechaTableAdapter.Fill(this.MaxiconfortDataSetConsolidado.SPGetFacturasConsolidadoByFecha, dtpPeriodo.Value.AddDays(-1), dtpPeriodo.Value);
            }
            else if (cboTipo.SelectedIndex == 1)
            {
                //Semanal
                this.SPGetFacturasConsolidadoByFechaTableAdapter.Fill(this.MaxiconfortDataSetConsolidado.SPGetFacturasConsolidadoByFecha, dtpPeriodo.Value.AddDays(-1), dtpPeriodo.Value.AddDays(6));
            }
            else
            {
                //Por periodos
                var query = FacturacionFacade.GetPeriodos(cboTipo.SelectedIndex - 1);
                int periodo = int.Parse(cboPeriodos.SelectedValue.ToString());
                var periodoSelected = query.Where(p => p.Periodo == periodo).FirstOrDefault();
                this.SPGetFacturasConsolidadoByFechaTableAdapter.Fill(this.MaxiconfortDataSetConsolidado.SPGetFacturasConsolidadoByFecha, periodoSelected.FechaInicio, periodoSelected.FechaFin);
            }
            rpvFacturasConsolidadas.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Factura objFactura = FacturacionFacade.SelectByIdFactura(txtNumeroFactura.Text);

            txtCliente.Text = objFactura.Cliente;
            txtDireccion.Text = objFactura.Direccion;
            txtNit.Text = objFactura.Nit;
            txtTelefono.Text = objFactura.Telefono;

            var list = objFactura.DetalleFacturas.ToList();
            var binding = new BindingList<DetalleFactura>(list);
            dgvProductos.DataSource = binding;
            dgvProductos.Refresh();

            for (int i = 0; i < list.Count; i++)
            {
                dgvProductos.Rows[i].Cells[0].Value = list[i].Cantidad;
                dgvProductos.Rows[i].Cells[1].Value = list[i].Producto;
                dgvProductos.Rows[i].Cells[2].Value = list[i].ValorUnitario;
            }

            dgvProductos.Enabled = false;
            btnGuardar.Visible = false;
            btnImprimir.Visible = true;
            lblNombreVendedor.Text = objFactura.Usuario;

            //Se deshabilitan los campos
            DeshabilitarCampos();


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            new frmImprimirFactura(int.Parse(txtNumeroFactura.Text)).Show();
        }

        private void lblMinimizarReporte_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblCerrarReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Eventos Controles

        #region Metodos públicos

        public void LimpiarCampos()
        {
            txtNumeroFactura.Text = string.Empty;
            lblTotalTotal.Text = "0";
            txtCliente.Text = string.Empty;
            txtNit.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            dgvProductos.Enabled = true;
            btnGuardar.Visible = true;
            btnImprimir.Visible = false;
            lblNombreVendedor.Text = this.Usuario;
        }

        public void DeshabilitarCampos()
        {
            txtCliente.Enabled = false;
            txtNit.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            dgvProductos.Enabled = false;
        }

        public void HabilitarCampos()
        {
            txtCliente.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            dgvProductos.Enabled = true;
        }


        #endregion Metodos públicos

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
