using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTGBodega.Login;
using HTGBodega.Util;

namespace HTGBodega.UI
{
    public partial class CategoriasUI : Form
    {
        public CategoriasUI()
        {
            InitializeComponent();
        }

        private void CategoriasUI_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void boxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void mostrarDatos()
        {
            dataGridView1.DataSource = new LCategorias().GetAll(chkEstado.Checked);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.Columns["ID"].HeaderText = "ID";
            dataGridView1.Columns["ID"].DataPropertyName = "ID";
            dataGridView1.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//o fill para ocupar todo el ancho
            dataGridView1.Columns["ID"].ReadOnly = true;
            dataGridView1.Columns["Estado"].Visible = false;
            // mostrar columnas o esconderlas -->  visible=false;
            dataGridView1.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//o fill

            //para sellecionar toda la fila

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //para no seleccionar varias filas
            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            CategoriaDetalleIU detalle = new CategoriaDetalleIU();
            detalle.StartPosition = FormStartPosition.CenterScreen;          
            detalle.chkEstado.Checked = true;
            detalle.operacion = (byte) MisConstantes.OPERACION.Insercion;

          DialogResult rpta = detalle.ShowDialog();
           
            if (rpta==DialogResult.OK)
            {
                mostrarDatos();
            }

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {




        }
    }
}
