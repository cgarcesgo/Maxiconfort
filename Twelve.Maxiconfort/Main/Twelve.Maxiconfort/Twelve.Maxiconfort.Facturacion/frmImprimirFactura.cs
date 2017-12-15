using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twelve.Maxiconfort.Facturacion
{
    public partial class frmImprimirFactura : Form
    {
        private int FacturaId;

        public frmImprimirFactura(int facturaId)
        {
            InitializeComponent();
            this.FacturaId = facturaId;
        }

        private void frmImprimirFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'MaxiconfortDataSet.SPGetFactura' Puede moverla o quitarla según sea necesario.
            this.SPGetFacturaTableAdapter.Fill(this.MaxiconfortDataSet.SPGetFactura,(this.FacturaId));

            this.reportViewer1.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
