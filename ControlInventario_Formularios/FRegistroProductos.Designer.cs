
namespace ControlInventario_Formularios
{
    partial class FRegistroProductos
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
            System.Windows.Forms.Label existenciasLabel;
            System.Windows.Forms.Label idLinea_FKLabel;
            System.Windows.Forms.Label idProductoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioLabel;
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.existenciasTextBox = new System.Windows.Forms.TextBox();
            this.idLinea_FKComboBox = new System.Windows.Forms.ComboBox();
            this.idProductoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            existenciasLabel = new System.Windows.Forms.Label();
            idLinea_FKLabel = new System.Windows.Forms.Label();
            idProductoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(ControlInventario.Entidades.Producto);
            // 
            // existenciasLabel
            // 
            existenciasLabel.AutoSize = true;
            existenciasLabel.Location = new System.Drawing.Point(118, 98);
            existenciasLabel.Name = "existenciasLabel";
            existenciasLabel.Size = new System.Drawing.Size(63, 13);
            existenciasLabel.TabIndex = 1;
            existenciasLabel.Text = "Existencias:";
            // 
            // existenciasTextBox
            // 
            this.existenciasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Existencias", true));
            this.existenciasTextBox.Location = new System.Drawing.Point(189, 95);
            this.existenciasTextBox.Name = "existenciasTextBox";
            this.existenciasTextBox.Size = new System.Drawing.Size(121, 20);
            this.existenciasTextBox.TabIndex = 2;
            // 
            // idLinea_FKLabel
            // 
            idLinea_FKLabel.AutoSize = true;
            idLinea_FKLabel.Location = new System.Drawing.Point(118, 124);
            idLinea_FKLabel.Name = "idLinea_FKLabel";
            idLinea_FKLabel.Size = new System.Drawing.Size(64, 13);
            idLinea_FKLabel.TabIndex = 3;
            idLinea_FKLabel.Text = "Id Linea FK:";
            // 
            // idLinea_FKComboBox
            // 
            this.idLinea_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IdLinea_FK", true));
            this.idLinea_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IdLinea_FK", true));
            this.idLinea_FKComboBox.DataSource = this.lineaBindingSource;
            this.idLinea_FKComboBox.DisplayMember = "Nombre";
            this.idLinea_FKComboBox.FormattingEnabled = true;
            this.idLinea_FKComboBox.Location = new System.Drawing.Point(189, 121);
            this.idLinea_FKComboBox.Name = "idLinea_FKComboBox";
            this.idLinea_FKComboBox.Size = new System.Drawing.Size(250, 21);
            this.idLinea_FKComboBox.TabIndex = 4;
            this.idLinea_FKComboBox.ValueMember = "IdLinea";
            // 
            // idProductoLabel
            // 
            idProductoLabel.AutoSize = true;
            idProductoLabel.Location = new System.Drawing.Point(118, 151);
            idProductoLabel.Name = "idProductoLabel";
            idProductoLabel.Size = new System.Drawing.Size(65, 13);
            idProductoLabel.TabIndex = 5;
            idProductoLabel.Text = "Id Producto:";
            // 
            // idProductoTextBox
            // 
            this.idProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IdProducto", true));
            this.idProductoTextBox.Location = new System.Drawing.Point(189, 148);
            this.idProductoTextBox.Name = "idProductoTextBox";
            this.idProductoTextBox.Size = new System.Drawing.Size(121, 20);
            this.idProductoTextBox.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(118, 177);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(189, 174);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(118, 203);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(189, 200);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioTextBox.TabIndex = 10;
            // 
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(ControlInventario.Entidades.Linea);
            // 
            // FRegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(existenciasLabel);
            this.Controls.Add(this.existenciasTextBox);
            this.Controls.Add(idLinea_FKLabel);
            this.Controls.Add(this.idLinea_FKComboBox);
            this.Controls.Add(idProductoLabel);
            this.Controls.Add(this.idProductoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Name = "FRegistroProductos";
            this.Text = "FRegistroProductos";
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox existenciasTextBox;
        private System.Windows.Forms.ComboBox idLinea_FKComboBox;
        private System.Windows.Forms.BindingSource lineaBindingSource;
        private System.Windows.Forms.TextBox idProductoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
    }
}