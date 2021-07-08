
namespace _48284_TP6.Vistas
{
    partial class ListaProductosVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductosVista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
            this.IconEliminarProducto = new System.Windows.Forms.ToolStripButton();
            this.IconModificarProducto = new System.Windows.Forms.ToolStripButton();
            this.IconCrearProducto = new System.Windows.Forms.ToolStripButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoConIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.BarraDeHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BarraDeHerramientas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridProductos, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 727);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BarraDeHerramientas
            // 
            this.BarraDeHerramientas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraDeHerramientas.AutoSize = false;
            this.BarraDeHerramientas.Dock = System.Windows.Forms.DockStyle.None;
            this.BarraDeHerramientas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconEliminarProducto,
            this.IconModificarProducto,
            this.IconCrearProducto});
            this.BarraDeHerramientas.Location = new System.Drawing.Point(968, 0);
            this.BarraDeHerramientas.Name = "BarraDeHerramientas";
            this.BarraDeHerramientas.Padding = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.BarraDeHerramientas.Size = new System.Drawing.Size(296, 63);
            this.BarraDeHerramientas.TabIndex = 1;
            this.BarraDeHerramientas.Text = "toolStrip1";
            // 
            // IconEliminarProducto
            // 
            this.IconEliminarProducto.AutoSize = false;
            this.IconEliminarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("IconEliminarProducto.Image")));
            this.IconEliminarProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconEliminarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconEliminarProducto.Name = "IconEliminarProducto";
            this.IconEliminarProducto.Size = new System.Drawing.Size(80, 80);
            this.IconEliminarProducto.Text = "Eliminar";
            this.IconEliminarProducto.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // IconModificarProducto
            // 
            this.IconModificarProducto.AutoSize = false;
            this.IconModificarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("IconModificarProducto.Image")));
            this.IconModificarProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconModificarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconModificarProducto.Name = "IconModificarProducto";
            this.IconModificarProducto.Size = new System.Drawing.Size(80, 80);
            this.IconModificarProducto.Text = "Modificar";
            this.IconModificarProducto.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // IconCrearProducto
            // 
            this.IconCrearProducto.AutoSize = false;
            this.IconCrearProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IconCrearProducto.Image = ((System.Drawing.Image)(resources.GetObject("IconCrearProducto.Image")));
            this.IconCrearProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconCrearProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IconCrearProducto.Name = "IconCrearProducto";
            this.IconCrearProducto.Size = new System.Drawing.Size(80, 80);
            this.IconCrearProducto.Text = "Agregar";
            this.IconCrearProducto.Click += new System.EventHandler(this.IconCrearProducto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AccessibleName = "";
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(3, 66);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(1258, 27);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Tag = "";
            this.txtDescripcion.Text = "Ingrese Aquí un Producto para buscar por su Descripción...";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AllowUserToDeleteRows = false;
            this.dataGridProductos.AutoGenerateColumns = false;
            this.dataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.CostoConIva,
            this.existenciaDataGridViewTextBoxColumn});
            this.dataGridProductos.DataSource = this.productoBindingSource;
            this.dataGridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProductos.Location = new System.Drawing.Point(3, 99);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.Size = new System.Drawing.Size(1258, 768);
            this.dataGridProductos.TabIndex = 3;
            this.dataGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellContentClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CostoConIva
            // 
            this.CostoConIva.DataPropertyName = "CostoConIva";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "C2";
            this.CostoConIva.DefaultCellStyle = dataGridViewCellStyle4;
            this.CostoConIva.HeaderText = "Precio Con Iva";
            this.CostoConIva.Name = "CostoConIva";
            this.CostoConIva.ReadOnly = true;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(_48284_TP6__Dominio.Producto);
            this.productoBindingSource.CurrentChanged += new System.EventHandler(this.productoBindingSource_CurrentChanged);
            // 
            // ListaProductosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 727);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListaProductosVista";
            this.Text = "ListaProductosVista";
            this.Load += new System.EventHandler(this.ListaProductosVista_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.BarraDeHerramientas.ResumeLayout(false);
            this.BarraDeHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip BarraDeHerramientas;
        private System.Windows.Forms.ToolStripButton IconEliminarProducto;
        private System.Windows.Forms.ToolStripButton IconModificarProducto;
        private System.Windows.Forms.ToolStripButton IconCrearProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dataGridProductos;
        public System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoConIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
    }
}