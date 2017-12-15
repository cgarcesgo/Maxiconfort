namespace Twelve.Maxiconfort.Facturacion
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabPageFacturacion = new System.Windows.Forms.TabPage();
            this.lklCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.lblTotalTotal = new System.Windows.Forms.Label();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigoFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabPageReportes = new System.Windows.Forms.TabPage();
            this.lblCerrarReporte = new System.Windows.Forms.Label();
            this.lblMinimizarReporte = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPeriodos = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.rpvFacturasConsolidadas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SPGetFacturasConsolidadoByFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaxiconfortDataSetConsolidado = new Twelve.Maxiconfort.Facturacion.MaxiconfortDataSetConsolidado();
            this.SPGetFacturasConsolidadoByFechaTableAdapter = new Twelve.Maxiconfort.Facturacion.MaxiconfortDataSetConsolidadoTableAdapters.SPGetFacturasConsolidadoByFechaTableAdapter();
            this.tabPanel.SuspendLayout();
            this.tabPageFacturacion.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPageReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGetFacturasConsolidadoByFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiconfortDataSetConsolidado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPanel.Controls.Add(this.tabPageFacturacion);
            this.tabPanel.Controls.Add(this.tabPageReportes);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(1019, 595);
            this.tabPanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPanel.TabIndex = 1;
            // 
            // tabPageFacturacion
            // 
            this.tabPageFacturacion.BackgroundImage = global::Twelve.Maxiconfort.Facturacion.Properties.Resources.formFactura2NewTel;
            this.tabPageFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageFacturacion.Controls.Add(this.lklCerrarSesion);
            this.tabPageFacturacion.Controls.Add(this.lblTotalTotal);
            this.tabPageFacturacion.Controls.Add(this.lblTotalVenta);
            this.tabPageFacturacion.Controls.Add(this.gbBuscar);
            this.tabPageFacturacion.Controls.Add(this.lblCerrar);
            this.tabPageFacturacion.Controls.Add(this.lblMinimizar);
            this.tabPageFacturacion.Controls.Add(this.lblNombreVendedor);
            this.tabPageFacturacion.Controls.Add(this.btnImprimir);
            this.tabPageFacturacion.Controls.Add(this.btnLimpiar);
            this.tabPageFacturacion.Controls.Add(this.btnGuardar);
            this.tabPageFacturacion.Controls.Add(this.txtTelefono);
            this.tabPageFacturacion.Controls.Add(this.dgvProductos);
            this.tabPageFacturacion.Controls.Add(this.txtDireccion);
            this.tabPageFacturacion.Controls.Add(this.txtNit);
            this.tabPageFacturacion.Controls.Add(this.txtCliente);
            this.tabPageFacturacion.Controls.Add(this.lblTelefono);
            this.tabPageFacturacion.Controls.Add(this.lblDireccion);
            this.tabPageFacturacion.Controls.Add(this.lblVendedor);
            this.tabPageFacturacion.Controls.Add(this.lblNit);
            this.tabPageFacturacion.Controls.Add(this.lblCliente);
            this.tabPageFacturacion.Location = new System.Drawing.Point(4, 25);
            this.tabPageFacturacion.Name = "tabPageFacturacion";
            this.tabPageFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFacturacion.Size = new System.Drawing.Size(1011, 566);
            this.tabPageFacturacion.TabIndex = 0;
            this.tabPageFacturacion.Text = "Facturación";
            this.tabPageFacturacion.UseVisualStyleBackColor = true;
            // 
            // lklCerrarSesion
            // 
            this.lklCerrarSesion.AutoSize = true;
            this.lklCerrarSesion.BackColor = System.Drawing.Color.Silver;
            this.lklCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCerrarSesion.Location = new System.Drawing.Point(901, 490);
            this.lklCerrarSesion.Name = "lklCerrarSesion";
            this.lklCerrarSesion.Size = new System.Drawing.Size(93, 17);
            this.lklCerrarSesion.TabIndex = 23;
            this.lklCerrarSesion.TabStop = true;
            this.lklCerrarSesion.Text = "Cerrar sesión";
            this.lklCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCerrarSesion_LinkClicked);
            // 
            // lblTotalTotal
            // 
            this.lblTotalTotal.AutoSize = true;
            this.lblTotalTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTotal.Location = new System.Drawing.Point(844, 320);
            this.lblTotalTotal.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblTotalTotal.Name = "lblTotalTotal";
            this.lblTotalTotal.Size = new System.Drawing.Size(150, 25);
            this.lblTotalTotal.TabIndex = 22;
            this.lblTotalTotal.Text = "0";
            this.lblTotalTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.ForeColor = System.Drawing.Color.Black;
            this.lblTotalVenta.Location = new System.Drawing.Point(710, 320);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(128, 25);
            this.lblTotalVenta.TabIndex = 21;
            this.lblTotalVenta.Text = "Total Venta:";
            // 
            // gbBuscar
            // 
            this.gbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.lblCodigoFactura);
            this.gbBuscar.Controls.Add(this.txtNumeroFactura);
            this.gbBuscar.Location = new System.Drawing.Point(6, 125);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(464, 44);
            this.gbBuscar.TabIndex = 20;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar Factura";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(379, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 20);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigoFactura
            // 
            this.lblCodigoFactura.AutoSize = true;
            this.lblCodigoFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFactura.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoFactura.Location = new System.Drawing.Point(6, 19);
            this.lblCodigoFactura.Name = "lblCodigoFactura";
            this.lblCodigoFactura.Size = new System.Drawing.Size(61, 13);
            this.lblCodigoFactura.TabIndex = 17;
            this.lblCodigoFactura.Text = "N° Factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(71, 16);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(292, 20);
            this.txtNumeroFactura.TabIndex = 18;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.Location = new System.Drawing.Point(955, 3);
            this.lblCerrar.MinimumSize = new System.Drawing.Size(48, 48);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(48, 48);
            this.lblCerrar.TabIndex = 16;
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.Location = new System.Drawing.Point(901, 3);
            this.lblMinimizar.MinimumSize = new System.Drawing.Size(48, 48);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(48, 48);
            this.lblMinimizar.TabIndex = 15;
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Black;
            this.lblNombreVendedor.Location = new System.Drawing.Point(77, 329);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblNombreVendedor.TabIndex = 14;
            this.lblNombreVendedor.Text = "Vendedor";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::Twelve.Maxiconfort.Facturacion.Properties.Resources.paper6;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(492, 393);
            this.btnImprimir.MinimumSize = new System.Drawing.Size(48, 48);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(48, 48);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Tag = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::Twelve.Maxiconfort.Facturacion.Properties.Resources.document185;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Location = new System.Drawing.Point(438, 393);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(48, 48);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Tag = "Nueva Factura";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::Twelve.Maxiconfort.Facturacion.Properties.Resources.diskette18;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(492, 393);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 48);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Tag = "Guardar Factura";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 291);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(292, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Referencia,
            this.ValorUnitario,
            this.Total});
            this.dgvProductos.Location = new System.Drawing.Point(385, 186);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(609, 125);
            this.dgvProductos.TabIndex = 10;
            this.dgvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellValueChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.Width = 165;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Valor Unitario";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Width = 120;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 200;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(77, 255);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(292, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(77, 222);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(292, 20);
            this.txtNit.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(77, 186);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(292, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(11, 294);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(12, 258);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.Black;
            this.lblVendedor.Location = new System.Drawing.Point(11, 329);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.BackColor = System.Drawing.Color.Transparent;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.ForeColor = System.Drawing.Color.Black;
            this.lblNit.Location = new System.Drawing.Point(12, 225);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(23, 13);
            this.lblNit.TabIndex = 1;
            this.lblNit.Text = "Nit:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(12, 189);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // tabPageReportes
            // 
            this.tabPageReportes.BackgroundImage = global::Twelve.Maxiconfort.Facturacion.Properties.Resources.formFactura2NewTel;
            this.tabPageReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageReportes.Controls.Add(this.rpvFacturasConsolidadas);
            this.tabPageReportes.Controls.Add(this.lblCerrarReporte);
            this.tabPageReportes.Controls.Add(this.lblMinimizarReporte);
            this.tabPageReportes.Controls.Add(this.button1);
            this.tabPageReportes.Controls.Add(this.cboPeriodos);
            this.tabPageReportes.Controls.Add(this.cboTipo);
            this.tabPageReportes.Controls.Add(this.label3);
            this.tabPageReportes.Controls.Add(this.label2);
            this.tabPageReportes.Controls.Add(this.dtpPeriodo);
            this.tabPageReportes.Location = new System.Drawing.Point(4, 25);
            this.tabPageReportes.Name = "tabPageReportes";
            this.tabPageReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportes.Size = new System.Drawing.Size(1011, 566);
            this.tabPageReportes.TabIndex = 1;
            this.tabPageReportes.Text = "Reportes";
            this.tabPageReportes.UseVisualStyleBackColor = true;
            // 
            // lblCerrarReporte
            // 
            this.lblCerrarReporte.AutoSize = true;
            this.lblCerrarReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrarReporte.Location = new System.Drawing.Point(955, 3);
            this.lblCerrarReporte.MinimumSize = new System.Drawing.Size(48, 48);
            this.lblCerrarReporte.Name = "lblCerrarReporte";
            this.lblCerrarReporte.Size = new System.Drawing.Size(48, 48);
            this.lblCerrarReporte.TabIndex = 18;
            this.lblCerrarReporte.Click += new System.EventHandler(this.lblCerrarReporte_Click);
            // 
            // lblMinimizarReporte
            // 
            this.lblMinimizarReporte.AutoSize = true;
            this.lblMinimizarReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizarReporte.Location = new System.Drawing.Point(901, 3);
            this.lblMinimizarReporte.MinimumSize = new System.Drawing.Size(48, 48);
            this.lblMinimizarReporte.Name = "lblMinimizarReporte";
            this.lblMinimizarReporte.Size = new System.Drawing.Size(48, 48);
            this.lblMinimizarReporte.TabIndex = 17;
            this.lblMinimizarReporte.Click += new System.EventHandler(this.lblMinimizarReporte_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ver Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboPeriodos
            // 
            this.cboPeriodos.FormattingEnabled = true;
            this.cboPeriodos.Location = new System.Drawing.Point(347, 128);
            this.cboPeriodos.Name = "cboPeriodos";
            this.cboPeriodos.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodos.TabIndex = 4;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensual",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.cboTipo.Location = new System.Drawing.Point(123, 128);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 3;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(278, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo reporte";
            // 
            // dtpPeriodo
            // 
            this.dtpPeriodo.Location = new System.Drawing.Point(347, 129);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.Size = new System.Drawing.Size(200, 20);
            this.dtpPeriodo.TabIndex = 5;
            this.dtpPeriodo.Visible = false;
            // 
            // rpvFacturasConsolidadas
            // 
            reportDataSource1.Name = "dtSetFacturasConsolidado";
            reportDataSource1.Value = this.SPGetFacturasConsolidadoByFechaBindingSource;
            this.rpvFacturasConsolidadas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFacturasConsolidadas.LocalReport.ReportEmbeddedResource = "Twelve.Maxiconfort.Facturacion.Reports.rptFacturasByFechas.rdlc";
            this.rpvFacturasConsolidadas.Location = new System.Drawing.Point(0, 166);
            this.rpvFacturasConsolidadas.Name = "rpvFacturasConsolidadas";
            this.rpvFacturasConsolidadas.Size = new System.Drawing.Size(1011, 349);
            this.rpvFacturasConsolidadas.TabIndex = 19;
            // 
            // SPGetFacturasConsolidadoByFechaBindingSource
            // 
            this.SPGetFacturasConsolidadoByFechaBindingSource.DataMember = "SPGetFacturasConsolidadoByFecha";
            this.SPGetFacturasConsolidadoByFechaBindingSource.DataSource = this.MaxiconfortDataSetConsolidado;
            // 
            // MaxiconfortDataSetConsolidado
            // 
            this.MaxiconfortDataSetConsolidado.DataSetName = "MaxiconfortDataSetConsolidado";
            this.MaxiconfortDataSetConsolidado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SPGetFacturasConsolidadoByFechaTableAdapter
            // 
            this.SPGetFacturasConsolidadoByFechaTableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1019, 595);
            this.ControlBox = false;
            this.Controls.Add(this.tabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maxiconfort - Facturación";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.tabPanel.ResumeLayout(false);
            this.tabPageFacturacion.ResumeLayout(false);
            this.tabPageFacturacion.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPageReportes.ResumeLayout(false);
            this.tabPageReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGetFacturasConsolidadoByFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxiconfortDataSetConsolidado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabPageFacturacion;
        private System.Windows.Forms.TabPage tabPageReportes;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblCodigoFactura;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblTotalTotal;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.ComboBox cboPeriodos;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.LinkLabel lklCerrarSesion;
        private System.Windows.Forms.Label lblCerrarReporte;
        private System.Windows.Forms.Label lblMinimizarReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rpvFacturasConsolidadas;
        private System.Windows.Forms.BindingSource SPGetFacturasConsolidadoByFechaBindingSource;
        private MaxiconfortDataSetConsolidado MaxiconfortDataSetConsolidado;
        private MaxiconfortDataSetConsolidadoTableAdapters.SPGetFacturasConsolidadoByFechaTableAdapter SPGetFacturasConsolidadoByFechaTableAdapter;

    }
}