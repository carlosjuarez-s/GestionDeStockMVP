
namespace _48284_TP6.Vistas
{
    partial class ModificarProductoVista
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.txtMargenDeGanacia = new System.Windows.Forms.TextBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.lblMargenGanancia = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCostoConIva = new System.Windows.Forms.TextBox();
            this.lblCostoConIva = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtPorcentajeIva = new System.Windows.Forms.TextBox();
            this.lblPorcentajeIva = new System.Windows.Forms.Label();
            this.txtCostoSinIva = new System.Windows.Forms.TextBox();
            this.lblCostoSinIva = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.bsModificarProducto = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsModificarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(394, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 35);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "Estado", true));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(173, 406);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEstado.TabIndex = 38;
            // 
            // txtMargenDeGanacia
            // 
            this.txtMargenDeGanacia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "MargenGanancia", true));
            this.txtMargenDeGanacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenDeGanacia.Location = new System.Drawing.Point(173, 348);
            this.txtMargenDeGanacia.Name = "txtMargenDeGanacia";
            this.txtMargenDeGanacia.Size = new System.Drawing.Size(530, 26);
            this.txtMargenDeGanacia.TabIndex = 37;
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "PrecioFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioFinal.Location = new System.Drawing.Point(173, 296);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(530, 26);
            this.txtPrecioFinal.TabIndex = 36;
            // 
            // lblMargenGanancia
            // 
            this.lblMargenGanancia.AutoSize = true;
            this.lblMargenGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargenGanancia.Location = new System.Drawing.Point(32, 341);
            this.lblMargenGanancia.Name = "lblMargenGanancia";
            this.lblMargenGanancia.Size = new System.Drawing.Size(89, 40);
            this.lblMargenGanancia.TabIndex = 35;
            this.lblMargenGanancia.Text = "Margen de \r\nGanancia";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.Location = new System.Drawing.Point(32, 296);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(91, 20);
            this.lblPrecioFinal.TabIndex = 34;
            this.lblPrecioFinal.Text = "Precio Final";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(32, 407);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado";
            // 
            // txtCostoConIva
            // 
            this.txtCostoConIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "CostoConIva", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtCostoConIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoConIva.Location = new System.Drawing.Point(173, 245);
            this.txtCostoConIva.Name = "txtCostoConIva";
            this.txtCostoConIva.ReadOnly = true;
            this.txtCostoConIva.Size = new System.Drawing.Size(530, 26);
            this.txtCostoConIva.TabIndex = 32;
            // 
            // lblCostoConIva
            // 
            this.lblCostoConIva.AutoSize = true;
            this.lblCostoConIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoConIva.Location = new System.Drawing.Point(32, 245);
            this.lblCostoConIva.Name = "lblCostoConIva";
            this.lblCostoConIva.Size = new System.Drawing.Size(111, 20);
            this.lblCostoConIva.TabIndex = 31;
            this.lblCostoConIva.Text = "Precio Con Iva";
            // 
            // txtExistencia
            // 
            this.txtExistencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "Existencia", true));
            this.txtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(173, 197);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(530, 26);
            this.txtExistencia.TabIndex = 30;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.Location = new System.Drawing.Point(32, 200);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(81, 20);
            this.lblExistencia.TabIndex = 29;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtPorcentajeIva
            // 
            this.txtPorcentajeIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "PorcentajeIva", true));
            this.txtPorcentajeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeIva.Location = new System.Drawing.Point(173, 150);
            this.txtPorcentajeIva.Name = "txtPorcentajeIva";
            this.txtPorcentajeIva.Size = new System.Drawing.Size(530, 26);
            this.txtPorcentajeIva.TabIndex = 28;
            // 
            // lblPorcentajeIva
            // 
            this.lblPorcentajeIva.AutoSize = true;
            this.lblPorcentajeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeIva.Location = new System.Drawing.Point(32, 153);
            this.lblPorcentajeIva.Name = "lblPorcentajeIva";
            this.lblPorcentajeIva.Size = new System.Drawing.Size(132, 20);
            this.lblPorcentajeIva.TabIndex = 27;
            this.lblPorcentajeIva.Text = "Porcentaje de Iva";
            // 
            // txtCostoSinIva
            // 
            this.txtCostoSinIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "CostoSinIva", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtCostoSinIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoSinIva.Location = new System.Drawing.Point(173, 105);
            this.txtCostoSinIva.Name = "txtCostoSinIva";
            this.txtCostoSinIva.Size = new System.Drawing.Size(530, 26);
            this.txtCostoSinIva.TabIndex = 26;
            this.txtCostoSinIva.TextChanged += new System.EventHandler(this.txtCostoSinIva_TextChanged);
            // 
            // lblCostoSinIva
            // 
            this.lblCostoSinIva.AutoSize = true;
            this.lblCostoSinIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoSinIva.Location = new System.Drawing.Point(32, 108);
            this.lblCostoSinIva.Name = "lblCostoSinIva";
            this.lblCostoSinIva.Size = new System.Drawing.Size(102, 20);
            this.lblCostoSinIva.TabIndex = 25;
            this.lblCostoSinIva.Text = "Precio sin Iva";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "Descripcion", true));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(173, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(530, 26);
            this.txtDescripcion.TabIndex = 24;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(32, 63);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 23;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Location = new System.Drawing.Point(567, 486);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(154, 35);
            this.btnModificarProducto.TabIndex = 22;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsModificarProducto, "Codigo", true));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(173, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(530, 26);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(32, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Codigo";
            // 
            // bsModificarProducto
            // 
            this.bsModificarProducto.DataSource = typeof(_48284_TP6__Dominio.Producto);
            // 
            // ModificarProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 537);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.txtMargenDeGanacia);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.lblMargenGanancia);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCostoConIva);
            this.Controls.Add(this.lblCostoConIva);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.txtPorcentajeIva);
            this.Controls.Add(this.lblPorcentajeIva);
            this.Controls.Add(this.txtCostoSinIva);
            this.Controls.Add(this.lblCostoSinIva);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarProductoVista";
            this.Text = "ModificarProductoVista";
            this.Load += new System.EventHandler(this.ModificarProductoVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsModificarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox txtMargenDeGanacia;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Label lblMargenGanancia;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCostoConIva;
        private System.Windows.Forms.Label lblCostoConIva;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.TextBox txtPorcentajeIva;
        private System.Windows.Forms.Label lblPorcentajeIva;
        private System.Windows.Forms.TextBox txtCostoSinIva;
        private System.Windows.Forms.Label lblCostoSinIva;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.BindingSource bsModificarProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}