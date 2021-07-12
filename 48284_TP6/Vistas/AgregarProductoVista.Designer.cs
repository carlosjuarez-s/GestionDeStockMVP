
namespace _48284_TP6.Vistas
{
    partial class AgregarProductoVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProductoVista));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.bsAgregarProducto = new System.Windows.Forms.BindingSource(this.components);
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCostoSinIva = new System.Windows.Forms.TextBox();
            this.lblCostoSinIva = new System.Windows.Forms.Label();
            this.txtPorcentajeIva = new System.Windows.Forms.TextBox();
            this.lblPorcentajeIva = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtCostoConIva = new System.Windows.Forms.TextBox();
            this.lblCostoConIva = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblMargenGanancia = new System.Windows.Forms.Label();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.txtMargenDeGanacia = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCamposRequeridos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(32, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo *";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "Codigo", true));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(173, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(530, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // bsAgregarProducto
            // 
            this.bsAgregarProducto.DataSource = typeof(_48284_TP6__Dominio.Producto);
            this.bsAgregarProducto.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.Location = new System.Drawing.Point(567, 490);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(154, 35);
            this.btnCrearProducto.TabIndex = 10;
            this.btnCrearProducto.Text = "Crear";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "Descripcion", true));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(173, 89);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(530, 26);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(32, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 20);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion *";
            // 
            // txtCostoSinIva
            // 
            this.txtCostoSinIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "CostoSinIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.txtCostoSinIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoSinIva.Location = new System.Drawing.Point(173, 134);
            this.txtCostoSinIva.Name = "txtCostoSinIva";
            this.txtCostoSinIva.Size = new System.Drawing.Size(530, 26);
            this.txtCostoSinIva.TabIndex = 3;
            this.txtCostoSinIva.TabIndexChanged += new System.EventHandler(this.txtCostoSinIva_TabIndexChanged);
            this.txtCostoSinIva.TextChanged += new System.EventHandler(this.txtCostoSinIva_TextChanged);
            // 
            // lblCostoSinIva
            // 
            this.lblCostoSinIva.AutoSize = true;
            this.lblCostoSinIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoSinIva.Location = new System.Drawing.Point(32, 137);
            this.lblCostoSinIva.Name = "lblCostoSinIva";
            this.lblCostoSinIva.Size = new System.Drawing.Size(112, 20);
            this.lblCostoSinIva.TabIndex = 5;
            this.lblCostoSinIva.Text = "Precio sin Iva *";
            // 
            // txtPorcentajeIva
            // 
            this.txtPorcentajeIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "PorcentajeIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPorcentajeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeIva.Location = new System.Drawing.Point(173, 179);
            this.txtPorcentajeIva.Name = "txtPorcentajeIva";
            this.txtPorcentajeIva.Size = new System.Drawing.Size(530, 26);
            this.txtPorcentajeIva.TabIndex = 4;
            // 
            // lblPorcentajeIva
            // 
            this.lblPorcentajeIva.AutoSize = true;
            this.lblPorcentajeIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeIva.Location = new System.Drawing.Point(32, 182);
            this.lblPorcentajeIva.Name = "lblPorcentajeIva";
            this.lblPorcentajeIva.Size = new System.Drawing.Size(142, 20);
            this.lblPorcentajeIva.TabIndex = 7;
            this.lblPorcentajeIva.Text = "Porcentaje de Iva *";
            // 
            // txtExistencia
            // 
            this.txtExistencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "Existencia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Location = new System.Drawing.Point(173, 226);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(530, 26);
            this.txtExistencia.TabIndex = 5;
            this.txtExistencia.TextChanged += new System.EventHandler(this.txtExistencia_TextChanged);
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.Location = new System.Drawing.Point(32, 229);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(91, 20);
            this.lblExistencia.TabIndex = 9;
            this.lblExistencia.Text = "Existencia *";
            // 
            // txtCostoConIva
            // 
            this.txtCostoConIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "CostoConIva", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtCostoConIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoConIva.Location = new System.Drawing.Point(173, 274);
            this.txtCostoConIva.Name = "txtCostoConIva";
            this.txtCostoConIva.ReadOnly = true;
            this.txtCostoConIva.Size = new System.Drawing.Size(530, 26);
            this.txtCostoConIva.TabIndex = 12;
            // 
            // lblCostoConIva
            // 
            this.lblCostoConIva.AutoSize = true;
            this.lblCostoConIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoConIva.Location = new System.Drawing.Point(32, 274);
            this.lblCostoConIva.Name = "lblCostoConIva";
            this.lblCostoConIva.Size = new System.Drawing.Size(111, 20);
            this.lblCostoConIva.TabIndex = 11;
            this.lblCostoConIva.Text = "Precio Con Iva";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.Location = new System.Drawing.Point(32, 325);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(91, 20);
            this.lblPrecioFinal.TabIndex = 14;
            this.lblPrecioFinal.Text = "Precio Final";
            // 
            // lblMargenGanancia
            // 
            this.lblMargenGanancia.AutoSize = true;
            this.lblMargenGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargenGanancia.Location = new System.Drawing.Point(32, 370);
            this.lblMargenGanancia.Name = "lblMargenGanancia";
            this.lblMargenGanancia.Size = new System.Drawing.Size(89, 40);
            this.lblMargenGanancia.TabIndex = 15;
            this.lblMargenGanancia.Text = "Margen de \r\nGanancia";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "PrecioFinal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.txtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioFinal.Location = new System.Drawing.Point(173, 325);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(530, 26);
            this.txtPrecioFinal.TabIndex = 6;
            // 
            // txtMargenDeGanacia
            // 
            this.txtMargenDeGanacia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "MargenGanancia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMargenDeGanacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenDeGanacia.Location = new System.Drawing.Point(173, 377);
            this.txtMargenDeGanacia.Name = "txtMargenDeGanacia";
            this.txtMargenDeGanacia.Size = new System.Drawing.Size(530, 26);
            this.txtMargenDeGanacia.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(394, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 35);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(32, 497);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Visible = false;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAgregarProducto, "Estado", true));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(98, 499);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEstado.TabIndex = 18;
            this.comboBoxEstado.Visible = false;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(706, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // lblCamposRequeridos
            // 
            this.lblCamposRequeridos.AutoSize = true;
            this.lblCamposRequeridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposRequeridos.ForeColor = System.Drawing.Color.Red;
            this.lblCamposRequeridos.Location = new System.Drawing.Point(541, 9);
            this.lblCamposRequeridos.Name = "lblCamposRequeridos";
            this.lblCamposRequeridos.Size = new System.Drawing.Size(162, 20);
            this.lblCamposRequeridos.TabIndex = 22;
            this.lblCamposRequeridos.Text = "*Campos Obligatorios";
            // 
            // AgregarProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(754, 537);
            this.ControlBox = false;
            this.Controls.Add(this.lblCamposRequeridos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "AgregarProductoVista";
            this.Text = "AgregarProductoVista";
            ((System.ComponentModel.ISupportInitialize)(this.bsAgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAgregarProducto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCostoSinIva;
        private System.Windows.Forms.Label lblCostoSinIva;
        private System.Windows.Forms.TextBox txtPorcentajeIva;
        private System.Windows.Forms.Label lblPorcentajeIva;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.TextBox txtCostoConIva;
        private System.Windows.Forms.Label lblCostoConIva;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblMargenGanancia;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.TextBox txtMargenDeGanacia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCamposRequeridos;
    }
}