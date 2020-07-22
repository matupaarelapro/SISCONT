using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class frmRegistroCompra : Form
    {
        private RegistroCompras bRegistroCompras = new RegistroCompras();
        public frmRegistroCompra()
        {
            InitializeComponent();
        }

        private void cellContentClickEvent(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void tabIndexChangedEvent(object sender, EventArgs e)
        {

        }

        private void guardar()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["mes"].Value)))
                    {
                        bRegistroCompras.save(
                            Convert.ToInt32(row.Cells["mes"].Value),
                            Convert.ToString(row.Cells["nReg"].Value),
                            Convert.ToString(row.Cells["fechaEmision"].Value),
                            Convert.ToString(row.Cells["fechaPago"].Value),
                            Convert.ToString(row.Cells["cdpTipo"].Value),
                            Convert.ToString(row.Cells["cdpSerie"].Value),
                            Convert.ToString(row.Cells["cdpNumeroDocumento"].Value),
                            Convert.ToString(row.Cells["proveedorTipo"].Value),
                            Convert.ToString(row.Cells["proveedorNumeroDocumento"].Value),
                            Convert.ToString(row.Cells["proveedorTipoDocumento"].Value),
                            Convert.ToString(row.Cells["proveedorRazonSocial"].Value),
                            Convert.ToString(row.Cells["cuenta"].Value),
                            Convert.ToString(row.Cells["descripcion"].Value),
                            Convert.ToDouble(row.Cells["baseImponible"].Value),
                            Convert.ToDouble(row.Cells["igv"].Value),
                            Convert.ToDouble(row.Cells["noGravada"].Value),
                            Convert.ToDouble(row.Cells["descuento"].Value),
                            Convert.ToDouble(row.Cells["importeTotal"].Value),
                            Convert.ToDouble(row.Cells["dolares"].Value),
                            Convert.ToDouble(row.Cells["tipoCambio"].Value),
                            Convert.ToDouble(row.Cells["percepcion"].Value),
                            Convert.ToString(row.Cells["destino"].Value),
                            Convert.ToString(row.Cells["descripcion"].Value),
                            Convert.ToString(row.Cells["cuentaDestino"].Value),
                            Convert.ToString(row.Cells["pago"].Value),
                            Convert.ToString(row.Cells["codigo"].Value),
                            Convert.ToString(row.Cells["constanciaNumero"].Value),
                            Convert.ToString(row.Cells["constanciaFechaPago"].Value),
                            Convert.ToDouble(row.Cells["ConstanciaMonto"].Value),
                            Convert.ToString(row.Cells["constanciaReferencia"].Value)
                        );
                    }
                }
                MessageBox.Show("se inserto correctamente los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
