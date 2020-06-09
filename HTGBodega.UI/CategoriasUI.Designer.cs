namespace HTGBodega.UI
{
    partial class CategoriasUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriasUI));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkEstado1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnReporte = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.boxCriterio = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(859, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // chkEstado1
            // 
            this.chkEstado1.AutoSize = true;
            this.chkEstado1.Checked = true;
            this.chkEstado1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado1.Location = new System.Drawing.Point(788, 14);
            this.chkEstado1.Name = "chkEstado1";
            this.chkEstado1.Size = new System.Drawing.Size(59, 17);
            this.chkEstado1.TabIndex = 1;
            this.chkEstado1.Text = "Estado";
            this.chkEstado1.UseVisualStyleBackColor = true;
            this.chkEstado1.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnAgregar,
            this.btnModificar,
            this.btnEliminar,
            this.btnReporte,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 48);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(142, 45);
            this.toolStripLabel1.Text = "CATEGORÌAS";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 45);
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(45, 45);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 45);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AutoSize = false;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(105, 45);
            this.btnReporte.Text = "Reportes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(62, 45);
            this.toolStripLabel2.Text = "Bùsqueda:";
            // 
            // boxCriterio
            // 
            this.boxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCriterio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCriterio.FormattingEnabled = true;
            this.boxCriterio.Location = new System.Drawing.Point(464, 7);
            this.boxCriterio.Name = "boxCriterio";
            this.boxCriterio.Size = new System.Drawing.Size(109, 28);
            this.boxCriterio.TabIndex = 3;
            this.boxCriterio.SelectedIndexChanged += new System.EventHandler(this.boxCriterio_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(579, 11);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(157, 22);
            this.txtValor.TabIndex = 5;
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(746, 10);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(32, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "+";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // CategoriasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 415);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.chkEstado1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boxCriterio);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CategoriasUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriasUI";
            this.Load += new System.EventHandler(this.CategoriasUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkEstado1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ComboBox boxCriterio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ToolStripSplitButton btnReporte;
    }
}