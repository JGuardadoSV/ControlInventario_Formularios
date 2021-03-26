
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioLabel;
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.existenciasTextBox = new System.Windows.Forms.TextBox();
            this.idLinea_FKComboBox = new System.Windows.Forms.ComboBox();
            this.lineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            existenciasLabel = new System.Windows.Forms.Label();
            idLinea_FKLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // existenciasLabel
            // 
            existenciasLabel.AutoSize = true;
            existenciasLabel.Location = new System.Drawing.Point(82, 195);
            existenciasLabel.Name = "existenciasLabel";
            existenciasLabel.Size = new System.Drawing.Size(63, 13);
            existenciasLabel.TabIndex = 7;
            existenciasLabel.Text = "Existencias:";
            // 
            // idLinea_FKLabel
            // 
            idLinea_FKLabel.AutoSize = true;
            idLinea_FKLabel.Location = new System.Drawing.Point(56, 142);
            idLinea_FKLabel.Name = "idLinea_FKLabel";
            idLinea_FKLabel.Size = new System.Drawing.Size(89, 13);
            idLinea_FKLabel.TabIndex = 3;
            idLinea_FKLabel.Text = "Linea / Categoria";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(98, 116);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(105, 169);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 5;
            precioLabel.Text = "Precio:";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(ControlInventario.Entidades.Producto);
            // 
            // existenciasTextBox
            // 
            this.existenciasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Existencias", true));
            this.existenciasTextBox.Location = new System.Drawing.Point(153, 192);
            this.existenciasTextBox.Name = "existenciasTextBox";
            this.existenciasTextBox.Size = new System.Drawing.Size(121, 20);
            this.existenciasTextBox.TabIndex = 8;
            // 
            // idLinea_FKComboBox
            // 
            this.idLinea_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IdLinea_FK", true));
            this.idLinea_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IdLinea_FK", true));
            this.idLinea_FKComboBox.DataSource = this.lineaBindingSource;
            this.idLinea_FKComboBox.DisplayMember = "Nombre";
            this.idLinea_FKComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idLinea_FKComboBox.FormattingEnabled = true;
            this.idLinea_FKComboBox.Location = new System.Drawing.Point(153, 139);
            this.idLinea_FKComboBox.Name = "idLinea_FKComboBox";
            this.idLinea_FKComboBox.Size = new System.Drawing.Size(250, 21);
            this.idLinea_FKComboBox.TabIndex = 4;
            this.idLinea_FKComboBox.ValueMember = "IdLinea";
            // 
            // lineaBindingSource
            // 
            this.lineaBindingSource.DataSource = typeof(ControlInventario.Entidades.Linea);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(153, 113);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(153, 166);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 20);
            this.precioTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administracion de productos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(existenciasLabel);
            this.Controls.Add(this.existenciasTextBox);
            this.Controls.Add(idLinea_FKLabel);
            this.Controls.Add(this.idLinea_FKComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Name = "FRegistroProductos";
            this.Text = "FRegistroProductos";
            this.Load += new System.EventHandler(this.FRegistroProductos_Load);
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
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}