namespace Unidad3LP2
{
    partial class Proveedores
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
            groupBox1 = new GroupBox();
            maskTelPro = new MaskedTextBox();
            txtEmailPro = new TextBox();
            btnAdd = new Button();
            txtNombrePro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtIDPro = new TextBox();
            btnDelete = new Button();
            label5 = new Label();
            groupBox3 = new GroupBox();
            maskTelProUp = new MaskedTextBox();
            txtEmailProUp = new TextBox();
            txtNombreProUp = new TextBox();
            txtIDproUp = new TextBox();
            btnUpdate = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            btnView = new Button();
            dgvProveedores = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 49, 49);
            label1.Location = new Point(1222, 13);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Proveedores";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-1, 0);
            button1.Name = "button1";
            button1.Size = new Size(1347, 10);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskTelPro);
            groupBox1.Controls.Add(txtEmailPro);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtNombrePro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 308);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add";
            // 
            // maskTelPro
            // 
            maskTelPro.BackColor = Color.FromArgb(49, 49, 49);
            maskTelPro.BorderStyle = BorderStyle.FixedSingle;
            maskTelPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskTelPro.ForeColor = SystemColors.Control;
            maskTelPro.Location = new Point(18, 150);
            maskTelPro.Mask = "000-000-0000";
            maskTelPro.Name = "maskTelPro";
            maskTelPro.Size = new Size(355, 29);
            maskTelPro.TabIndex = 14;
            // 
            // txtEmailPro
            // 
            txtEmailPro.BackColor = Color.FromArgb(49, 49, 49);
            txtEmailPro.BorderStyle = BorderStyle.FixedSingle;
            txtEmailPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailPro.ForeColor = SystemColors.Control;
            txtEmailPro.Location = new Point(18, 226);
            txtEmailPro.Name = "txtEmailPro";
            txtEmailPro.Size = new Size(355, 29);
            txtEmailPro.TabIndex = 10;
            txtEmailPro.TextChanged += txtEmailPro_TextChanged;
            txtEmailPro.KeyPress += txtEmailPro_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 49, 49);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Gray;
            btnAdd.Location = new Point(379, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 268);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNombrePro
            // 
            txtNombrePro.BackColor = Color.FromArgb(49, 49, 49);
            txtNombrePro.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePro.ForeColor = SystemColors.Control;
            txtNombrePro.Location = new Point(18, 76);
            txtNombrePro.Name = "txtNombrePro";
            txtNombrePro.Size = new Size(355, 29);
            txtNombrePro.TabIndex = 3;
            txtNombrePro.TextChanged += txtNombrePro_TextChanged;
            txtNombrePro.KeyPress += txtNombrePro_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 190);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 2;
            label4.Text = "Correo Electrónico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 114);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 1;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 42);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txtIDPro);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(486, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 308);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // txtIDPro
            // 
            txtIDPro.BackColor = Color.FromArgb(49, 49, 49);
            txtIDPro.BorderStyle = BorderStyle.FixedSingle;
            txtIDPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDPro.ForeColor = SystemColors.Control;
            txtIDPro.Location = new Point(20, 76);
            txtIDPro.Name = "txtIDPro";
            txtIDPro.Size = new Size(193, 29);
            txtIDPro.TabIndex = 10;
            txtIDPro.KeyPress += txtIDPro_KeyPress;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(49, 49, 49);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Gray;
            btnDelete.Location = new Point(18, 128);
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
            label5.Location = new Point(18, 42);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 3;
            label5.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(maskTelProUp);
            groupBox3.Controls.Add(txtEmailProUp);
            groupBox3.Controls.Add(txtNombreProUp);
            groupBox3.Controls.Add(txtIDproUp);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(736, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(458, 308);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // maskTelProUp
            // 
            maskTelProUp.BackColor = Color.FromArgb(49, 49, 49);
            maskTelProUp.BorderStyle = BorderStyle.FixedSingle;
            maskTelProUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskTelProUp.ForeColor = SystemColors.Control;
            maskTelProUp.Location = new Point(17, 202);
            maskTelProUp.Mask = "000-000-0000";
            maskTelProUp.Name = "maskTelProUp";
            maskTelProUp.Size = new Size(422, 29);
            maskTelProUp.TabIndex = 15;
            // 
            // txtEmailProUp
            // 
            txtEmailProUp.BackColor = Color.FromArgb(49, 49, 49);
            txtEmailProUp.BorderStyle = BorderStyle.FixedSingle;
            txtEmailProUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailProUp.ForeColor = SystemColors.Control;
            txtEmailProUp.Location = new Point(17, 267);
            txtEmailProUp.Name = "txtEmailProUp";
            txtEmailProUp.Size = new Size(422, 29);
            txtEmailProUp.TabIndex = 14;
            txtEmailProUp.TextChanged += txtEmailProUp_TextChanged;
            txtEmailProUp.KeyPress += txtEmailProUp_KeyPress;
            // 
            // txtNombreProUp
            // 
            txtNombreProUp.BackColor = Color.FromArgb(49, 49, 49);
            txtNombreProUp.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProUp.ForeColor = SystemColors.Control;
            txtNombreProUp.Location = new Point(16, 138);
            txtNombreProUp.Name = "txtNombreProUp";
            txtNombreProUp.Size = new Size(423, 29);
            txtNombreProUp.TabIndex = 12;
            txtNombreProUp.TextChanged += txtNombreProUp_TextChanged;
            txtNombreProUp.KeyPress += txtNombreProUp_KeyPress;
            // 
            // txtIDproUp
            // 
            txtIDproUp.BackColor = Color.FromArgb(49, 49, 49);
            txtIDproUp.BorderStyle = BorderStyle.FixedSingle;
            txtIDproUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDproUp.ForeColor = SystemColors.Control;
            txtIDproUp.Location = new Point(16, 69);
            txtIDproUp.Name = "txtIDproUp";
            txtIDproUp.Size = new Size(187, 29);
            txtIDproUp.TabIndex = 11;
            txtIDproUp.KeyPress += txtIDproUp_KeyPress;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(49, 49, 49);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Gray;
            btnUpdate.Location = new Point(219, 66);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(220, 39);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 234);
            label9.Name = "label9";
            label9.Size = new Size(151, 21);
            label9.TabIndex = 6;
            label9.Text = "Correo Electrónico";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 170);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 5;
            label8.Text = "Teléfono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 101);
            label7.Name = "label7";
            label7.Size = new Size(152, 21);
            label7.TabIndex = 4;
            label7.Text = "Nombre Completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 42);
            label6.Name = "label6";
            label6.Size = new Size(27, 21);
            label6.TabIndex = 3;
            label6.Text = "ID";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(btnView);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(1209, 41);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(124, 283);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "View";
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(49, 49, 49);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.ForeColor = Color.Gray;
            btnView.Location = new Point(22, 51);
            btnView.Name = "btnView";
            btnView.Size = new Size(80, 191);
            btnView.TabIndex = 11;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(12, 342);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.Size = new Size(1321, 176);
            dgvProveedores.TabIndex = 7;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 49, 49);
            ClientSize = new Size(1345, 530);
            ControlBox = false;
            Controls.Add(dgvProveedores);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Proveedores";
            Text = "Proveedores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvProveedores;
        private TextBox txtNombrePro;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnView;
        private TextBox txtEmailPro;
        private TextBox txtIDPro;
        private TextBox txtEmailProUp;
        private TextBox txtNombreProUp;
        private TextBox txtIDproUp;
        private MaskedTextBox maskTelPro;
        private MaskedTextBox maskTelProUp;
    }
}