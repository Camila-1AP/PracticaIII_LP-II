namespace Unidad3LP2
{
    partial class Clientes
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
            label5 = new Label();
            btnDelete = new Button();
            txtIDcli = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreCli = new TextBox();
            btnAdd = new Button();
            txtEmailCli = new TextBox();
            label10 = new Label();
            txtDirCli = new TextBox();
            groupBox1 = new GroupBox();
            maskTelCli = new MaskedTextBox();
            btnView = new Button();
            groupBox4 = new GroupBox();
            label6 = new Label();
            btnUpdate = new Button();
            txtIDCliUp = new TextBox();
            groupBox3 = new GroupBox();
            maskTelCliUp = new MaskedTextBox();
            txtDirCliUp = new TextBox();
            label7 = new Label();
            txtEmailCliUp = new TextBox();
            txtNombreCliUp = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            dgvClientes = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 49, 49);
            label1.Location = new Point(1265, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-1, -4);
            button1.Name = "button1";
            button1.Size = new Size(1350, 10);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
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
            // txtIDcli
            // 
            txtIDcli.BackColor = Color.FromArgb(49, 49, 49);
            txtIDcli.BorderStyle = BorderStyle.FixedSingle;
            txtIDcli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDcli.ForeColor = SystemColors.Control;
            txtIDcli.Location = new Point(18, 119);
            txtIDcli.Name = "txtIDcli";
            txtIDcli.Size = new Size(193, 29);
            txtIDcli.TabIndex = 10;
            txtIDcli.KeyPress += txtIDcli_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txtIDcli);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(482, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 396);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 127);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 1;
            label3.Text = "Correro Electrónico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 202);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 2;
            label4.Text = "Teléfono";
            // 
            // txtNombreCli
            // 
            txtNombreCli.BackColor = Color.FromArgb(49, 49, 49);
            txtNombreCli.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCli.ForeColor = SystemColors.Control;
            txtNombreCli.Location = new Point(18, 84);
            txtNombreCli.Name = "txtNombreCli";
            txtNombreCli.Size = new Size(355, 29);
            txtNombreCli.TabIndex = 3;
            txtNombreCli.TextChanged += txtNombreCli_TextChanged;
            txtNombreCli.KeyPress += txtNombreCli_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 49, 49);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Gray;
            btnAdd.Location = new Point(379, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 239);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmailCli
            // 
            txtEmailCli.BackColor = Color.FromArgb(49, 49, 49);
            txtEmailCli.BorderStyle = BorderStyle.FixedSingle;
            txtEmailCli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailCli.ForeColor = SystemColors.Control;
            txtEmailCli.Location = new Point(18, 160);
            txtEmailCli.Name = "txtEmailCli";
            txtEmailCli.Size = new Size(355, 29);
            txtEmailCli.TabIndex = 9;
            txtEmailCli.TextChanged += txtEmailCli_TextChanged;
            txtEmailCli.KeyPress += txtEmailCli_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 266);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 11;
            label10.Text = "Dirección";
            // 
            // txtDirCli
            // 
            txtDirCli.BackColor = Color.FromArgb(49, 49, 49);
            txtDirCli.BorderStyle = BorderStyle.FixedSingle;
            txtDirCli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDirCli.ForeColor = SystemColors.Control;
            txtDirCli.Location = new Point(18, 294);
            txtDirCli.Name = "txtDirCli";
            txtDirCli.Size = new Size(355, 29);
            txtDirCli.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskTelCli);
            groupBox1.Controls.Add(txtDirCli);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtEmailCli);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtNombreCli);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 396);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add";
            // 
            // maskTelCli
            // 
            maskTelCli.BackColor = Color.FromArgb(49, 49, 49);
            maskTelCli.BorderStyle = BorderStyle.FixedSingle;
            maskTelCli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskTelCli.ForeColor = SystemColors.Control;
            maskTelCli.Location = new Point(18, 234);
            maskTelCli.Mask = "000-000-0000";
            maskTelCli.Name = "maskTelCli";
            maskTelCli.Size = new Size(355, 29);
            maskTelCli.TabIndex = 13;
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
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(btnView);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(1205, 37);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(124, 371);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "View";
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
            // txtIDCliUp
            // 
            txtIDCliUp.BackColor = Color.FromArgb(49, 49, 49);
            txtIDCliUp.BorderStyle = BorderStyle.FixedSingle;
            txtIDCliUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDCliUp.ForeColor = SystemColors.Control;
            txtIDCliUp.Location = new Point(16, 52);
            txtIDCliUp.Name = "txtIDCliUp";
            txtIDCliUp.Size = new Size(187, 29);
            txtIDCliUp.TabIndex = 11;
            txtIDCliUp.KeyPress += txtIDCliUp_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(maskTelCliUp);
            groupBox3.Controls.Add(txtDirCliUp);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtEmailCliUp);
            groupBox3.Controls.Add(txtNombreCliUp);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtIDCliUp);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(732, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(458, 396);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // maskTelCliUp
            // 
            maskTelCliUp.BackColor = Color.FromArgb(49, 49, 49);
            maskTelCliUp.BorderStyle = BorderStyle.FixedSingle;
            maskTelCliUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskTelCliUp.ForeColor = SystemColors.Control;
            maskTelCliUp.Location = new Point(16, 286);
            maskTelCliUp.Mask = "000-000-0000";
            maskTelCliUp.Name = "maskTelCliUp";
            maskTelCliUp.Size = new Size(424, 29);
            maskTelCliUp.TabIndex = 14;
            // 
            // txtDirCliUp
            // 
            txtDirCliUp.BackColor = Color.FromArgb(49, 49, 49);
            txtDirCliUp.BorderStyle = BorderStyle.FixedSingle;
            txtDirCliUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDirCliUp.ForeColor = SystemColors.Control;
            txtDirCliUp.Location = new Point(16, 346);
            txtDirCliUp.Name = "txtDirCliUp";
            txtDirCliUp.Size = new Size(424, 29);
            txtDirCliUp.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 318);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 19;
            label7.Text = "Dirección";
            // 
            // txtEmailCliUp
            // 
            txtEmailCliUp.BackColor = Color.FromArgb(49, 49, 49);
            txtEmailCliUp.BorderStyle = BorderStyle.FixedSingle;
            txtEmailCliUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailCliUp.ForeColor = SystemColors.Control;
            txtEmailCliUp.Location = new Point(16, 212);
            txtEmailCliUp.Name = "txtEmailCliUp";
            txtEmailCliUp.Size = new Size(424, 29);
            txtEmailCliUp.TabIndex = 17;
            txtEmailCliUp.KeyPress += txtEmailCliUp_KeyPress;
            // 
            // txtNombreCliUp
            // 
            txtNombreCliUp.BackColor = Color.FromArgb(49, 49, 49);
            txtNombreCliUp.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCliUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCliUp.ForeColor = SystemColors.Control;
            txtNombreCliUp.Location = new Point(16, 136);
            txtNombreCliUp.Name = "txtNombreCliUp";
            txtNombreCliUp.Size = new Size(424, 29);
            txtNombreCliUp.TabIndex = 16;
            txtNombreCliUp.TextChanged += txtNombreCliUp_TextChanged;
            txtNombreCliUp.KeyPress += txtNombreCliUp_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 254);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 15;
            label8.Text = "Teléfono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 179);
            label9.Name = "label9";
            label9.Size = new Size(157, 21);
            label9.TabIndex = 14;
            label9.Text = "Correro Electrónico";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 103);
            label11.Name = "label11";
            label11.Size = new Size(152, 21);
            label11.TabIndex = 13;
            label11.Text = "Nombre Completo";
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(8, 427);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(1321, 91);
            dgvClientes.TabIndex = 17;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 49, 49);
            ClientSize = new Size(1345, 530);
            ControlBox = false;
            Controls.Add(dgvClientes);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label5;
        private Button btnDelete;
        private TextBox txtIDcli;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreCli;
        private Button btnAdd;
        private TextBox txtEmailCli;
        private Label label10;
        private TextBox txtDirCli;
        private GroupBox groupBox1;
        private Button btnView;
        private GroupBox groupBox4;
        private Label label6;
        private Button btnUpdate;
        private TextBox txtIDCliUp;
        private GroupBox groupBox3;
        private DataGridView dgvClientes;
        private TextBox txtDirCliUp;
        private Label label7;
        private TextBox txtEmailCliUp;
        private TextBox txtNombreCliUp;
        private Label label8;
        private Label label9;
        private Label label11;
        private MaskedTextBox maskTelCli;
        private MaskedTextBox maskTelCliUp;
    }
}