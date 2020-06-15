using HTGBodega.Entity;
using HTGBodega.Login;
using HTGBodega.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTGBodega.UI
{
    public partial class ProveedorDetalleUI : Form
    {
        public byte operacion { get; set; }

        public ProveedorDetalleUI()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EProveedor obj = new EProveedor
            {

                ID = lblID.Text.Length == 0 ? 0 : int.Parse(lblID.Text),
                Razon_social = txtRazonSocial.Text.Trim().ToUpper(),
                RUC = txtRUC.Text.Trim().ToUpper(),
                Direccion = txtDireccion.Text.Trim().ToUpper(),
                Telefono = txtTelefono.Text.Trim().ToUpper(),
                Mail = txtMail.Text.Trim().ToUpper(),               
                Estado = chkEstado.Checked



            };

            int rpta = 0;
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LProveedor().Create(obj);

            }
            else
            {
                rpta = new LProveedor().Update(obj);
            }

            if (rpta > 0)
            {

                MessageBox.Show("operacion realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("la categoria ya existe");
            }

        }

        private void ProveedorDetalleUI_Load(object sender, EventArgs e)
        {
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                chkEstado.Checked = true;
            }

            if (operacion == (byte)MisConstantes.OPERACION.Modificacion)
            {

            }

        }
    }
}
