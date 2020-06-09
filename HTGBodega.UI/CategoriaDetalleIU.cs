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
    public partial class CategoriaDetalleIU : Form
    {

        public byte operacion { get; set; }

        public CategoriaDetalleIU()
        {

            InitializeComponent();
        }

        private void CategoriaDetalleIU_Load(object sender, EventArgs e)
        {
            if (operacion==(byte)MisConstantes.OPERACION.Insercion)
            {
                chkEstado.Checked = true;
            }

            if (operacion == (byte)MisConstantes.OPERACION.Modificacion)
            {
                
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ECategorias obj = new ECategorias
            {

               ID = lblID.Text.Length == 0 ? 0 : int.Parse(lblID.Text),
                Nombre = txtNombre.Text.Trim().ToUpper(),
                Descripcion = txtDescripcion.Text.Trim().ToUpper(),
                Estado =chkEstado.Checked



            };

            int rpta = 0;
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LCategorias().Create(obj);

            }
            else
            {
                rpta = new LCategorias().Update(obj);
            }

            if (rpta>0)
            {

                MessageBox.Show("operacion realizada correctamente","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("la categoria ya existe");
            }

          

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
