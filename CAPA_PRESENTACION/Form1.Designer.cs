using CAPA_DOMINIO;

namespace CAPA_PRESENTACION
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            txtDesc = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 304);
            dataGridView1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.AccessibleDescription = "";
            txtNombre.Location = new Point(585, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(256, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(585, 68);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Descripción";
            txtDesc.Size = new Size(256, 23);
            txtDesc.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(585, 117);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(256, 23);
            txtMarca.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(585, 169);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(256, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(585, 225);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Stock";
            txtStock.Size = new Size(256, 23);
            txtStock.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(585, 284);
            button1.Name = "button1";
            button1.Size = new Size(256, 23);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 347);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 7;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 347);
            button3.Name = "button3";
            button3.Size = new Size(110, 23);
            button3.TabIndex = 8;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtDesc);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNombre; //nombre
        private TextBox txtDesc; //desc
        private TextBox txtMarca; //marca
        private TextBox txtPrecio; //precio
        private TextBox txtStock; //stock
        private Button button1; //guardar
        private Button button2; //editar
        private Button button3; //eliminar



    }
}
