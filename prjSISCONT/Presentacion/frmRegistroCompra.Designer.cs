namespace Presentacion
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
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdpNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGravada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstanciaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistroCompras
            // 
            this.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mes,
            this.nReg,
            this.fechaEmision,
            this.fechaPago,
            this.cdpTipo,
            this.cdpSerie,
            this.cdpNumeroDocumento,
            this.proveedorTipo,
            this.proveedorNumeroDocumento,
            this.proveedorTipoDocumento,
            this.proveedorRazonSocial,
            this.cuenta,
            this.descripcion,
            this.baseImponible,
            this.igv,
            this.noGravada,
            this.descuento,
            this.importeTotal,
            this.dolares,
            this.tipoCambio,
            this.percepcion,
            this.destino,
            this.descripcionDestino,
            this.cuentaDestino,
            this.pago,
            this.codigo,
            this.constanciaNumero,
            this.constanciaFechaPago,
            this.ConstanciaMonto,
            this.constanciaReferencia});
            this.dgvRegistroCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroCompras.Location = new System.Drawing.Point(3, 3);
            this.dgvRegistroCompras.Name = "dgvRegistroCompras";
            this.dgvRegistroCompras.Size = new System.Drawing.Size(1094, 454);
            this.dgvRegistroCompras.TabIndex = 0;
            this.dgvRegistroCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellContentClickEvent);
            this.dgvRegistroCompras.TabIndexChanged += new System.EventHandler(this.tabIndexChangedEvent);
            // 
            // mes
            // 
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            // 
            // nReg
            // 
            this.nReg.HeaderText = "N° Registro";
            this.nReg.Name = "nReg";
            // 
            // fechaEmision
            // 
            this.fechaEmision.HeaderText = "Fecha de Emisión";
            this.fechaEmision.Name = "fechaEmision";
            // 
            // fechaPago
            // 
            this.fechaPago.HeaderText = "Fecha de Pago";
            this.fechaPago.Name = "fechaPago";
            // 
            // cdpTipo
            // 
            this.cdpTipo.HeaderText = "Comprobante Tipo";
            this.cdpTipo.Name = "cdpTipo";
            // 
            // cdpSerie
            // 
            this.cdpSerie.HeaderText = "Comprobante Serie";
            this.cdpSerie.Name = "cdpSerie";
            // 
            // cdpNumeroDocumento
            // 
            this.cdpNumeroDocumento.HeaderText = "Comprobante Número Documento";
            this.cdpNumeroDocumento.Name = "cdpNumeroDocumento";
            // 
            // proveedorTipo
            // 
            this.proveedorTipo.HeaderText = "Proveedor Tipo Documento";
            this.proveedorTipo.Name = "proveedorTipo";
            // 
            // proveedorNumeroDocumento
            // 
            this.proveedorNumeroDocumento.HeaderText = "Proveedor Numero Documento";
            this.proveedorNumeroDocumento.Name = "proveedorNumeroDocumento";
            // 
            // proveedorTipoDocumento
            // 
            this.proveedorTipoDocumento.HeaderText = "Proveedor Tipo Documento";
            this.proveedorTipoDocumento.Name = "proveedorTipoDocumento";
            // 
            // proveedorRazonSocial
            // 
            this.proveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.proveedorRazonSocial.Name = "proveedorRazonSocial";
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "Cuenta";
            this.cuenta.Name = "cuenta";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // baseImponible
            // 
            this.baseImponible.HeaderText = "Base Imponible";
            this.baseImponible.Name = "baseImponible";
            // 
            // igv
            // 
            this.igv.HeaderText = "IGV";
            this.igv.Name = "igv";
            // 
            // noGravada
            // 
            this.noGravada.HeaderText = "No Gravada";
            this.noGravada.Name = "noGravada";
            // 
            // descuento
            // 
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            // 
            // importeTotal
            // 
            this.importeTotal.HeaderText = "Importe Total";
            this.importeTotal.Name = "importeTotal";
            // 
            // dolares
            // 
            this.dolares.HeaderText = "Dolares";
            this.dolares.Name = "dolares";
            // 
            // tipoCambio
            // 
            this.tipoCambio.HeaderText = "Tipo de Cambio";
            this.tipoCambio.Name = "tipoCambio";
            // 
            // percepcion
            // 
            this.percepcion.HeaderText = "Percepción";
            this.percepcion.Name = "percepcion";
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            // 
            // descripcionDestino
            // 
            this.descripcionDestino.HeaderText = "Descripción Destino";
            this.descripcionDestino.Name = "descripcionDestino";
            // 
            // cuentaDestino
            // 
            this.cuentaDestino.HeaderText = "Cuenta Destino";
            this.cuentaDestino.Name = "cuentaDestino";
            // 
            // pago
            // 
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // constanciaNumero
            // 
            this.constanciaNumero.HeaderText = "Constancia Número";
            this.constanciaNumero.Name = "constanciaNumero";
            // 
            // constanciaFechaPago
            // 
            this.constanciaFechaPago.HeaderText = "Constancia de Fecha de Pago";
            this.constanciaFechaPago.Name = "constanciaFechaPago";
            // 
            // ConstanciaMonto
            // 
            this.ConstanciaMonto.HeaderText = "Constancia Monto";
            this.ConstanciaMonto.Name = "ConstanciaMonto";
            // 
            // constanciaReferencia
            // 
            this.constanciaReferencia.HeaderText = "Constancia Referencia";
            this.constanciaReferencia.Name = "constanciaReferencia";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 87);
            this.panel1.TabIndex = 2;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(921, 49);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdpNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGravada;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstanciaMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaReferencia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.Button btnGuardar;
    }
}

