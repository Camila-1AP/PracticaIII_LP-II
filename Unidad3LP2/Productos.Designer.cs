namespace Unidad3LP2
{
    partial class Productos
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
            label1 = new Label();
            button1 = new Button();
            groupBox4 = new GroupBox();
            btnView = new Button();
            groupBox3 = new GroupBox();
            cmbCategoriaProdUp = new ComboBox();
            label7 = new Label();
            txtStockProdUp = new TextBox();
            label8 = new Label();
            txtPrecioProdUp = new TextBox();
            txtDescProdUp = new TextBox();
            txtNombreProdUp = new TextBox();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtIDprodUp = new TextBox();
            btnUpdate = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtIDProd = new TextBox();
            btnDelete = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cmbCategoriaProd = new ComboBox();
            label11 = new Label();
            txtStockProd = new TextBox();
            label10 = new Label();
            txtPrecioProd = new TextBox();
            txtDescProd = new TextBox();
            btnAdd = new Button();
            txtNombreProd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvProductos = new DataGridView();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 49, 49);
            label1.Location = new Point(1242, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-1, -4);
            button1.Name = "button1";
            button1.Size = new Size(1347, 10);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(btnView);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(1205, 37);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(124, 371);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "View";
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(49, 49, 49);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.ForeColor = Color.Gray;
            btnView.Location = new Point(23, 94);
            btnView.Name = "btnView";
            btnView.Size = new Size(80, 191);
            btnView.TabIndex = 11;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(cmbCategoriaProdUp);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtStockProdUp);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtPrecioProdUp);
            groupBox3.Controls.Add(txtDescProdUp);
            groupBox3.Controls.Add(txtNombreProdUp);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtIDprodUp);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(732, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(458, 396);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // cmbCategoriaProdUp
            // 
            cmbCategoriaProdUp.BackColor = Color.FromArgb(49, 49, 49);
            cmbCategoriaProdUp.FlatStyle = FlatStyle.Popup;
            cmbCategoriaProdUp.ForeColor = SystemColors.Control;
            cmbCategoriaProdUp.FormattingEnabled = true;
            cmbCategoriaProdUp.Location = new Point(16, 353);
            cmbCategoriaProdUp.Name = "cmbCategoriaProdUp";
            cmbCategoriaProdUp.Size = new Size(424, 29);
            cmbCategoriaProdUp.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 329);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 23;
            label7.Text = "Categoría";
            // 
            // txtStockProdUp
            // 
            txtStockProdUp.BackColor = Color.FromArgb(49, 49, 49);
            txtStockProdUp.BorderStyle = BorderStyle.FixedSingle;
            txtStockProdUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockProdUp.ForeColor = SystemColors.Control;
            txtStockProdUp.Location = new Point(16, 294);
            txtStockProdUp.Name = "txtStockProdUp";
            txtStockProdUp.Size = new Size(424, 29);
            txtStockProdUp.TabIndex = 22;
            txtStockProdUp.KeyPress += txtStockProdUp_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 266);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 21;
            label8.Text = "Stock";
            // 
            // txtPrecioProdUp
            // 
            txtPrecioProdUp.BackColor = Color.FromArgb(49, 49, 49);
            txtPrecioProdUp.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioProdUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioProdUp.ForeColor = SystemColors.Control;
            txtPrecioProdUp.Location = new Point(16, 228);
            txtPrecioProdUp.Name = "txtPrecioProdUp";
            txtPrecioProdUp.Size = new Size(424, 29);
            txtPrecioProdUp.TabIndex = 20;
            txtPrecioProdUp.KeyPress += txtPrecioProdUp_KeyPress;
            // 
            // txtDescProdUp
            // 
            txtDescProdUp.BackColor = Color.FromArgb(49, 49, 49);
            txtDescProdUp.BorderStyle = BorderStyle.FixedSingle;
            txtDescProdUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescProdUp.ForeColor = SystemColors.Control;
            txtDescProdUp.Location = new Point(16, 164);
            txtDescProdUp.Name = "txtDescProdUp";
            txtDescProdUp.Size = new Size(424, 29);
            txtDescProdUp.TabIndex = 19;
            // 
            // txtNombreProdUp
            // 
            txtNombreProdUp.BackColor = Color.FromArgb(49, 49, 49);
            txtNombreProdUp.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProdUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProdUp.ForeColor = SystemColors.Control;
            txtNombreProdUp.Location = new Point(16, 108);
            txtNombreProdUp.Name = "txtNombreProdUp";
            txtNombreProdUp.Size = new Size(424, 29);
            txtNombreProdUp.TabIndex = 18;
            txtNombreProdUp.TextChanged += txtNombreProdUp_TextChanged;
            txtNombreProdUp.KeyPress += txtNombreProdUp_KeyPress;
            txtNombreProdUp.MouseEnter += txtNombreProdUp_MouseEnter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 204);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 17;
            label9.Text = "Precio";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 140);
            label12.Name = "label12";
            label12.Size = new Size(100, 21);
            label12.TabIndex = 16;
            label12.Text = "Descripción";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 84);
            label13.Name = "label13";
            label13.Size = new Size(73, 21);
            label13.TabIndex = 15;
            label13.Text = "Nombre";
            // 
            // txtIDprodUp
            // 
            txtIDprodUp.BackColor = Color.FromArgb(49, 49, 49);
            txtIDprodUp.BorderStyle = BorderStyle.FixedSingle;
            txtIDprodUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDprodUp.ForeColor = SystemColors.Control;
            txtIDprodUp.Location = new Point(16, 52);
            txtIDprodUp.Name = "txtIDprodUp";
            txtIDprodUp.Size = new Size(187, 29);
            txtIDprodUp.TabIndex = 11;
            txtIDprodUp.KeyPress += txtIDprodUp_KeyPress;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(49, 49, 49);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Gray;
            btnUpdate.Location = new Point(220, 42);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(220, 39);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 28);
            label6.Name = "label6";
            label6.Size = new Size(27, 21);
            label6.TabIndex = 3;
            label6.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txtIDProd);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(482, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 396);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // txtIDProd
            // 
            txtIDProd.BackColor = Color.FromArgb(49, 49, 49);
            txtIDProd.BorderStyle = BorderStyle.FixedSingle;
            txtIDProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDProd.ForeColor = SystemColors.Control;
            txtIDProd.Location = new Point(18, 119);
            txtIDProd.Name = "txtIDProd";
            txtIDProd.Size = new Size(193, 29);
            txtIDProd.TabIndex = 10;
            txtIDProd.KeyPress += txtIDProd_KeyPress;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(49, 49, 49);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Gray;
            btnDelete.Location = new Point(20, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 83);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 75);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 3;
            label5.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCategoriaProd);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtStockProd);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtPrecioProd);
            groupBox1.Controls.Add(txtDescProd);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtNombreProd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 396);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add";
            // 
            // cmbCategoriaProd
            // 
            cmbCategoriaProd.BackColor = Color.FromArgb(49, 49, 49);
            cmbCategoriaProd.FlatStyle = FlatStyle.Popup;
            cmbCategoriaProd.ForeColor = SystemColors.Control;
            cmbCategoriaProd.FormattingEnabled = true;
            cmbCategoriaProd.Location = new Point(18, 340);
            cmbCategoriaProd.Name = "cmbCategoriaProd";
            cmbCategoriaProd.Size = new Size(355, 29);
            cmbCategoriaProd.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 302);
            label11.Name = "label11";
            label11.Size = new Size(84, 21);
            label11.TabIndex = 13;
            label11.Text = "Categoría";
            label11.Click += label11_Click;
            // 
            // txtStockProd
            // 
            txtStockProd.BackColor = Color.FromArgb(49, 49, 49);
            txtStockProd.BorderStyle = BorderStyle.FixedSingle;
            txtStockProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockProd.ForeColor = SystemColors.Control;
            txtStockProd.Location = new Point(18, 266);
            txtStockProd.Name = "txtStockProd";
            txtStockProd.Size = new Size(355, 29);
            txtStockProd.TabIndex = 12;
            txtStockProd.TextChanged += textBox1_TextChanged;
            txtStockProd.KeyPress += txtStockProd_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 234);
            label10.Name = "label10";
            label10.Size = new Size(52, 21);
            label10.TabIndex = 11;
            label10.Text = "Stock";
            // 
            // txtPrecioProd
            // 
            txtPrecioProd.BackColor = Color.FromArgb(49, 49, 49);
            txtPrecioProd.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioProd.ForeColor = SystemColors.Control;
            txtPrecioProd.Location = new Point(18, 196);
            txtPrecioProd.Name = "txtPrecioProd";
            txtPrecioProd.Size = new Size(355, 29);
            txtPrecioProd.TabIndex = 10;
            txtPrecioProd.KeyPress += txtPrecioProd_KeyPress;
            // 
            // txtDescProd
            // 
            txtDescProd.BackColor = Color.FromArgb(49, 49, 49);
            txtDescProd.BorderStyle = BorderStyle.FixedSingle;
            txtDescProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescProd.ForeColor = SystemColors.Control;
            txtDescProd.Location = new Point(18, 128);
            txtDescProd.Name = "txtDescProd";
            txtDescProd.Size = new Size(355, 29);
            txtDescProd.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 49, 49);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Gray;
            btnAdd.Location = new Point(379, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 306);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNombreProd
            // 
            txtNombreProd.BackColor = Color.FromArgb(49, 49, 49);
            txtNombreProd.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProd.ForeColor = SystemColors.Control;
            txtNombreProd.Location = new Point(18, 63);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(355, 29);
            txtNombreProd.TabIndex = 3;
            txtNombreProd.TextChanged += txtNombrePro_TextChanged;
            txtNombreProd.KeyPress += txtNombreProd_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 170);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 2;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 1;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(8, 414);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(1321, 104);
            dgvProductos.TabIndex = 12;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 49, 49);
            ClientSize = new Size(1345, 530);
            ControlBox = false;
            Controls.Add(dgvProductos);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(49, 49, 49);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private GroupBox groupBox4;
        private Button btnView;
        private GroupBox groupBox3;
        private TextBox txtIDprodUp;
        private Button btnUpdate;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtIDProd;
        private Button btnDelete;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtPrecioProd;
        private TextBox txtDescProd;
        private Button btnAdd;
        private TextBox txtNombreProd;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvProductos;
        private TextBox txtStockProd;
        private Label label10;
        private Label label11;
        private Label label7;
        private TextBox txtStockProdUp;
        private Label label8;
        private TextBox txtPrecioProdUp;
        private TextBox txtDescProdUp;
        private TextBox txtNombreProdUp;
        private Label label9;
        private Label label12;
        private Label label13;
        private ComboBox cmbCategoriaProd;
        private ComboBox cmbCategoriaProdUp;
    }
}