﻿namespace Presentacion
{
    partial class frmRegistroCompra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRegistroCompras = new System.Windows.Forms.DataGridView();
            this.comprasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comprasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNoGravada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPercepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRegistroVentas = new System.Windows.Forms.DataGridView();
            this.ventasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasValorExportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalExonerada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalInafecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgvRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDetraccionSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.testlabel = new System.Windows.Forms.Label();
            this.btnGuardarVentas = new System.Windows.Forms.Button();
            this.btnGuardarCompras = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistroCompras
            // 
            this.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprasMes,
            this.comprasNumeroRegistro,
            this.comprasFechaEmision,
            this.comprasFechaPago,
            this.comprasCdpTipo,
            this.comprasCdpSerie,
            this.comprasCdpNumeroDocumento,
            this.comprasProveedorTipo,
            this.comprasProveedorNumeroDocumento,
            this.comprasProveedorTipoDocumento,
            this.comprasProveedorRazonSocial,
            this.comprasCuenta,
            this.comprasDescripcion,
            this.comprasBaseImponible,
            this.comprasIgv,
            this.comprasNoGravada,
            this.comprasDescuento,
            this.comprasImporteTotal,
            this.comprasDolares,
            this.comprasTipoCambio,
            this.comprasPercepcion,
            this.comprasDestino,
            this.comprasDescripcionDestino,
            this.comprasCuentaDestino,
            this.comprasPago,
            this.comprasCodigo,
            this.comprasConstanciaNumero,
            this.comprasConstanciaFechaPago,
            this.comprasConstanciaMonto,
            this.comprasConstanciaReferencia});
            this.dgvRegistroCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroCompras.Location = new System.Drawing.Point(3, 3);
            this.dgvRegistroCompras.Name = "dgvRegistroCompras";
            this.dgvRegistroCompras.Size = new System.Drawing.Size(1094, 454);
            this.dgvRegistroCompras.TabIndex = 0;
            this.dgvRegistroCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellContentClickEvent);
            this.dgvRegistroCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCompras_CellEndEdit);
            this.dgvRegistroCompras.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCompras_CellLeave_1);
            this.dgvRegistroCompras.TabIndexChanged += new System.EventHandler(this.tabIndexChangedEvent);
            this.dgvRegistroCompras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRegistroCompras_KeyDown);
            // 
            // comprasMes
            // 
            this.comprasMes.HeaderText = "Mes";
            this.comprasMes.Name = "comprasMes";
            // 
            // comprasNumeroRegistro
            // 
            this.comprasNumeroRegistro.HeaderText = "N° Registro";
            this.comprasNumeroRegistro.Name = "comprasNumeroRegistro";
            // 
            // comprasFechaEmision
            // 
            this.comprasFechaEmision.HeaderText = "Fecha de Emisión";
            this.comprasFechaEmision.Name = "comprasFechaEmision";
            // 
            // comprasFechaPago
            // 
            this.comprasFechaPago.HeaderText = "Fecha de Pago";
            this.comprasFechaPago.Name = "comprasFechaPago";
            // 
            // comprasCdpTipo
            // 
            this.comprasCdpTipo.HeaderText = "Comprobante Tipo";
            this.comprasCdpTipo.Name = "comprasCdpTipo";
            this.comprasCdpTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // comprasCdpSerie
            // 
            this.comprasCdpSerie.HeaderText = "Comprobante Serie";
            this.comprasCdpSerie.Name = "comprasCdpSerie";
            // 
            // comprasCdpNumeroDocumento
            // 
            this.comprasCdpNumeroDocumento.HeaderText = "Comprobante Número Documento";
            this.comprasCdpNumeroDocumento.Name = "comprasCdpNumeroDocumento";
            // 
            // comprasProveedorTipo
            // 
            this.comprasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.comprasProveedorTipo.Name = "comprasProveedorTipo";
            // 
            // comprasProveedorNumeroDocumento
            // 
            this.comprasProveedorNumeroDocumento.HeaderText = "Proveedor Numero Documento";
            this.comprasProveedorNumeroDocumento.Name = "comprasProveedorNumeroDocumento";
            // 
            // comprasProveedorTipoDocumento
            // 
            this.comprasProveedorTipoDocumento.HeaderText = "Proveedor Tipo Documento";
            this.comprasProveedorTipoDocumento.Name = "comprasProveedorTipoDocumento";
            // 
            // comprasProveedorRazonSocial
            // 
            this.comprasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.comprasProveedorRazonSocial.Name = "comprasProveedorRazonSocial";
            // 
            // comprasCuenta
            // 
            this.comprasCuenta.HeaderText = "Cuenta";
            this.comprasCuenta.Name = "comprasCuenta";
            // 
            // comprasDescripcion
            // 
            this.comprasDescripcion.HeaderText = "Descripción";
            this.comprasDescripcion.Name = "comprasDescripcion";
            // 
            // comprasBaseImponible
            // 
            this.comprasBaseImponible.HeaderText = "Base Imponible";
            this.comprasBaseImponible.Name = "comprasBaseImponible";
            // 
            // comprasIgv
            // 
            this.comprasIgv.HeaderText = "IGV";
            this.comprasIgv.Name = "comprasIgv";
            // 
            // comprasNoGravada
            // 
            this.comprasNoGravada.HeaderText = "No Gravada";
            this.comprasNoGravada.Name = "comprasNoGravada";
            // 
            // comprasDescuento
            // 
            this.comprasDescuento.HeaderText = "Descuento";
            this.comprasDescuento.Name = "comprasDescuento";
            // 
            // comprasImporteTotal
            // 
            this.comprasImporteTotal.HeaderText = "Importe Total";
            this.comprasImporteTotal.Name = "comprasImporteTotal";
            // 
            // comprasDolares
            // 
            this.comprasDolares.HeaderText = "Dolares";
            this.comprasDolares.Name = "comprasDolares";
            // 
            // comprasTipoCambio
            // 
            this.comprasTipoCambio.HeaderText = "Tipo de Cambio";
            this.comprasTipoCambio.Name = "comprasTipoCambio";
            // 
            // comprasPercepcion
            // 
            this.comprasPercepcion.HeaderText = "Percepción";
            this.comprasPercepcion.Name = "comprasPercepcion";
            // 
            // comprasDestino
            // 
            this.comprasDestino.HeaderText = "Destino";
            this.comprasDestino.Name = "comprasDestino";
            // 
            // comprasDescripcionDestino
            // 
            this.comprasDescripcionDestino.HeaderText = "Descripción Destino";
            this.comprasDescripcionDestino.Name = "comprasDescripcionDestino";
            // 
            // comprasCuentaDestino
            // 
            this.comprasCuentaDestino.HeaderText = "Cuenta Destino";
            this.comprasCuentaDestino.Name = "comprasCuentaDestino";
            // 
            // comprasPago
            // 
            this.comprasPago.HeaderText = "Pago";
            this.comprasPago.Name = "comprasPago";
            // 
            // comprasCodigo
            // 
            this.comprasCodigo.HeaderText = "Código";
            this.comprasCodigo.Name = "comprasCodigo";
            // 
            // comprasConstanciaNumero
            // 
            this.comprasConstanciaNumero.HeaderText = "Constancia Número";
            this.comprasConstanciaNumero.Name = "comprasConstanciaNumero";
            // 
            // comprasConstanciaFechaPago
            // 
            this.comprasConstanciaFechaPago.HeaderText = "Constancia de Fecha de Pago";
            this.comprasConstanciaFechaPago.Name = "comprasConstanciaFechaPago";
            // 
            // comprasConstanciaMonto
            // 
            this.comprasConstanciaMonto.HeaderText = "Constancia Monto";
            this.comprasConstanciaMonto.Name = "comprasConstanciaMonto";
            // 
            // comprasConstanciaReferencia
            // 
            this.comprasConstanciaReferencia.HeaderText = "Constancia Referencia";
            this.comprasConstanciaReferencia.Name = "comprasConstanciaReferencia";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 486);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRegistroCompras);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRegistroVentas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRegistroVentas
            // 
            this.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventasMes,
            this.ventasNumeroRegistro,
            this.ventasFechaEmision,
            this.ventasFechapago,
            this.ventasCdpTipo,
            this.ventasCdpSerie,
            this.ventasCdpNumero,
            this.ventasProveedorTipo,
            this.ventasProveedorNumero,
            this.ventasProveedorRazonSocial,
            this.ventasCuenta,
            this.ventasDescripcion,
            this.ventasValorExportacion,
            this.ventasBaseImponible,
            this.ventasImporteTotalExonerada,
            this.ventasImporteTotalInafecta,
            this.ventasIgv,
            this.ventasImporteTotal,
            this.ventasTipoCambio,
            this.ventasDolares,
            this.ventasIgvRetencion,
            this.ventasCuentaDestino,
            this.ventasPago,
            this.ventasReferenciaFecha,
            this.ventasReferenciaTipo,
            this.ventasReferenciaSerie,
            this.ventasReferenciaNumero,
            this.ventasCodigo,
            this.ventasConstanciaNumero,
            this.ventasConstanciaFechaPago,
            this.ventasDetraccionSoles,
            this.ventasReferencia,
            this.ventasObservacion});
            this.dgvRegistroVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroVentas.Location = new System.Drawing.Point(3, 3);
            this.dgvRegistroVentas.Name = "dgvRegistroVentas";
            this.dgvRegistroVentas.Size = new System.Drawing.Size(1094, 454);
            this.dgvRegistroVentas.TabIndex = 1;
            // 
            // ventasMes
            // 
            this.ventasMes.HeaderText = "Mes";
            this.ventasMes.Name = "ventasMes";
            // 
            // ventasNumeroRegistro
            // 
            this.ventasNumeroRegistro.HeaderText = "N° Registro";
            this.ventasNumeroRegistro.Name = "ventasNumeroRegistro";
            // 
            // ventasFechaEmision
            // 
            this.ventasFechaEmision.HeaderText = "Fecha de Emisión";
            this.ventasFechaEmision.Name = "ventasFechaEmision";
            // 
            // ventasFechapago
            // 
            this.ventasFechapago.HeaderText = "Fecha de Pago";
            this.ventasFechapago.Name = "ventasFechapago";
            // 
            // ventasCdpTipo
            // 
            this.ventasCdpTipo.HeaderText = "Comprobante Tipo";
            this.ventasCdpTipo.Name = "ventasCdpTipo";
            // 
            // ventasCdpSerie
            // 
            this.ventasCdpSerie.HeaderText = "Comprobante Serie";
            this.ventasCdpSerie.Name = "ventasCdpSerie";
            // 
            // ventasCdpNumero
            // 
            this.ventasCdpNumero.HeaderText = "Comprobante Número Documento";
            this.ventasCdpNumero.Name = "ventasCdpNumero";
            // 
            // ventasProveedorTipo
            // 
            this.ventasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.ventasProveedorTipo.Name = "ventasProveedorTipo";
            // 
            // ventasProveedorNumero
            // 
            this.ventasProveedorNumero.HeaderText = "Proveedor Numero Documento";
            this.ventasProveedorNumero.Name = "ventasProveedorNumero";
            // 
            // ventasProveedorRazonSocial
            // 
            this.ventasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.ventasProveedorRazonSocial.Name = "ventasProveedorRazonSocial";
            // 
            // ventasCuenta
            // 
            this.ventasCuenta.HeaderText = "Cuenta";
            this.ventasCuenta.Name = "ventasCuenta";
            // 
            // ventasDescripcion
            // 
            this.ventasDescripcion.HeaderText = "Descripción";
            this.ventasDescripcion.Name = "ventasDescripcion";
            // 
            // ventasValorExportacion
            // 
            this.ventasValorExportacion.HeaderText = "Valor de Exportación";
            this.ventasValorExportacion.Name = "ventasValorExportacion";
            // 
            // ventasBaseImponible
            // 
            this.ventasBaseImponible.HeaderText = "Base Imponible";
            this.ventasBaseImponible.Name = "ventasBaseImponible";
            // 
            // ventasImporteTotalExonerada
            // 
            this.ventasImporteTotalExonerada.HeaderText = "Importe Total Exonerada";
            this.ventasImporteTotalExonerada.Name = "ventasImporteTotalExonerada";
            // 
            // ventasImporteTotalInafecta
            // 
            this.ventasImporteTotalInafecta.HeaderText = "Importe Total Inafecta";
            this.ventasImporteTotalInafecta.Name = "ventasImporteTotalInafecta";
            // 
            // ventasIgv
            // 
            this.ventasIgv.HeaderText = "IGV";
            this.ventasIgv.Name = "ventasIgv";
            // 
            // ventasImporteTotal
            // 
            this.ventasImporteTotal.HeaderText = "Importe Total";
            this.ventasImporteTotal.Name = "ventasImporteTotal";
            // 
            // ventasTipoCambio
            // 
            this.ventasTipoCambio.HeaderText = "Tipo de Cambio";
            this.ventasTipoCambio.Name = "ventasTipoCambio";
            // 
            // ventasDolares
            // 
            this.ventasDolares.HeaderText = "Dólares";
            this.ventasDolares.Name = "ventasDolares";
            // 
            // ventasIgvRetencion
            // 
            this.ventasIgvRetencion.HeaderText = "IGV Retención";
            this.ventasIgvRetencion.Name = "ventasIgvRetencion";
            // 
            // ventasCuentaDestino
            // 
            this.ventasCuentaDestino.HeaderText = "Cuenta Destino";
            this.ventasCuentaDestino.Name = "ventasCuentaDestino";
            // 
            // ventasPago
            // 
            this.ventasPago.HeaderText = "Pago";
            this.ventasPago.Name = "ventasPago";
            // 
            // ventasReferenciaFecha
            // 
            this.ventasReferenciaFecha.HeaderText = "Referencia Fecha";
            this.ventasReferenciaFecha.Name = "ventasReferenciaFecha";
            // 
            // ventasReferenciaTipo
            // 
            this.ventasReferenciaTipo.HeaderText = "Referencia Tipo";
            this.ventasReferenciaTipo.Name = "ventasReferenciaTipo";
            // 
            // ventasReferenciaSerie
            // 
            this.ventasReferenciaSerie.HeaderText = "Referencia Serie";
            this.ventasReferenciaSerie.Name = "ventasReferenciaSerie";
            // 
            // ventasReferenciaNumero
            // 
            this.ventasReferenciaNumero.HeaderText = "Referencia Número";
            this.ventasReferenciaNumero.Name = "ventasReferenciaNumero";
            // 
            // ventasCodigo
            // 
            this.ventasCodigo.HeaderText = "Código";
            this.ventasCodigo.Name = "ventasCodigo";
            // 
            // ventasConstanciaNumero
            // 
            this.ventasConstanciaNumero.HeaderText = "Constancia Número";
            this.ventasConstanciaNumero.Name = "ventasConstanciaNumero";
            // 
            // ventasConstanciaFechaPago
            // 
            this.ventasConstanciaFechaPago.HeaderText = "Constancia Fecha Pago";
            this.ventasConstanciaFechaPago.Name = "ventasConstanciaFechaPago";
            // 
            // ventasDetraccionSoles
            // 
            this.ventasDetraccionSoles.HeaderText = "Detracción en Soles";
            this.ventasDetraccionSoles.Name = "ventasDetraccionSoles";
            // 
            // ventasReferencia
            // 
            this.ventasReferencia.HeaderText = "Referencia";
            this.ventasReferencia.Name = "ventasReferencia";
            // 
            // ventasObservacion
            // 
            this.ventasObservacion.HeaderText = "Observación";
            this.ventasObservacion.Name = "ventasObservacion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscarProveedor);
            this.panel1.Controls.Add(this.btnBuscarProveedor);
            this.panel1.Controls.Add(this.testlabel);
            this.panel1.Controls.Add(this.btnGuardarVentas);
            this.panel1.Controls.Add(this.btnGuardarCompras);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 87);
            this.panel1.TabIndex = 2;
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(140, 39);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarProveedor.TabIndex = 4;
            this.txtBuscarProveedor.Text = "20448484816";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(59, 36);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(255, 42);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(35, 13);
            this.testlabel.TabIndex = 2;
            this.testlabel.Text = "label1";
            // 
            // btnGuardarVentas
            // 
            this.btnGuardarVentas.Location = new System.Drawing.Point(857, 25);
            this.btnGuardarVentas.Name = "btnGuardarVentas";
            this.btnGuardarVentas.Size = new System.Drawing.Size(119, 23);
            this.btnGuardarVentas.TabIndex = 1;
            this.btnGuardarVentas.Text = "Guardar Ventas";
            this.btnGuardarVentas.UseVisualStyleBackColor = true;
            this.btnGuardarVentas.Click += new System.EventHandler(this.btnGuardarVentas_Click);
            // 
            // btnGuardarCompras
            // 
            this.btnGuardarCompras.Location = new System.Drawing.Point(721, 25);
            this.btnGuardarCompras.Name = "btnGuardarCompras";
            this.btnGuardarCompras.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarCompras.TabIndex = 0;
            this.btnGuardarCompras.Text = "Guardar Compras";
            this.btnGuardarCompras.UseVisualStyleBackColor = true;
            this.btnGuardarCompras.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.librosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // frmRegistroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegistroCompra";
            this.Text = "Formato 8.1 .::. Registro de Compra";
            this.Load += new System.EventHandler(this.frmRegistroCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroCompras;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.Button btnGuardarCompras;
        private System.Windows.Forms.DataGridView dgvRegistroVentas;
        private System.Windows.Forms.Button btnGuardarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechapago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasValorExportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalExonerada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalInafecta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgvRetencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDetraccionSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaPago;
        private System.Windows.Forms.DataGridViewComboBoxColumn comprasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNoGravada;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPercepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaReferencia;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
    }
}

