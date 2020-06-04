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
            dataGridView1.DataSource = new LCategorias().GetAll(chkEstado.Checked);
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new LCategorias().GetAll(chkEstado.Checked);
        }

        private void boxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
