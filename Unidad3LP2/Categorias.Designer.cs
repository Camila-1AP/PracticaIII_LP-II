namespace Unidad3LP2
{
    partial class Categorias
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
            txtNombreCateUp = new TextBox();
            label11 = new Label();
            txtIDcateUp = new TextBox();
            btnUpdate = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtIDcate = new TextBox();
            btnDelete = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            txtNombreCate = new TextBox();
            label2 = new Label();
            dgvCategorias = new DataGridView();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.MediumPurple;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 49, 49);
            label1.Location = new Point(1240, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "Categorías";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.MediumPurple;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, -3);
            button1.Name = "button1";
            button1.Size = new Size(1346, 10);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(btnView);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(1208, 38);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(124, 208);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "View";
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(49, 49, 49);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.ForeColor = Color.Gray;
            btnView.Location = new Point(23, 41);
            btnView.Name = "btnView";
            btnView.Size = new Size(80, 114);
            btnView.TabIndex = 11;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(txtNombreCateUp);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtIDcateUp);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(725, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 233);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update";
            // 
            // txtNombreCateUp
            // 
            txtNombreCateUp.BackColor = Color.FromArgb(49, 49, 49);
            txtNombreCateUp.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCateUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCateUp.ForeColor = SystemColors.Control;
            txtNombreCateUp.Location = new Point(16, 136);
            txtNombreCateUp.Name = "txtNombreCateUp";
            txtNombreCateUp.Size = new Size(424, 29);
            txtNombreCateUp.TabIndex = 16;
            txtNombreCateUp.KeyPress += txtNombreCateUp_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 103);
            label11.Name = "label11";
            label11.Size = new Size(151, 21);
            label11.TabIndex = 13;
            label11.Text = "Nombre Categoria";
            // 
            // txtIDcateUp
            // 
            txtIDcateUp.BackColor = Color.FromArgb(49, 49, 49);
            txtIDcateUp.BorderStyle = BorderStyle.FixedSingle;
            txtIDcateUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDcateUp.ForeColor = SystemColors.Control;
            txtIDcateUp.Location = new Point(16, 52);
            txtIDcateUp.Name = "txtIDcateUp";
            txtIDcateUp.Size = new Size(424, 29);
            txtIDcateUp.TabIndex = 11;
            txtIDcateUp.KeyPress += txtIDcateUp_KeyPress;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(49, 49, 49);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Gray;
            btnUpdate.Location = new Point(16, 171);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(424, 39);
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
            groupBox2.Controls.Add(txtIDcate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(485, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 233);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // txtIDcate
            // 
            txtIDcate.BackColor = Color.FromArgb(49, 49, 49);
            txtIDcate.BorderStyle = BorderStyle.FixedSingle;
            txtIDcate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDcate.ForeColor = SystemColors.Control;
            txtIDcate.Location = new Point(20, 84);
            txtIDcate.Name = "txtIDcate";
            txtIDcate.Size = new Size(193, 29);
            txtIDcate.TabIndex = 10;
            txtIDcate.KeyPress += txtIDcate_KeyPress;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(49, 49, 49);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Gray;
            btnDelete.Location = new Point(18, 119);
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
            label5.Location = new Point(20, 54);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 3;
            label5.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtNombreCate);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(11, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 233);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(49, 49, 49);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.Gray;
            btnAdd.Location = new Point(18, 119);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(432, 61);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNombreCate
            // 
            txtNombreCate.BackColor = Color.FromArgb(49, 49, 49);
            txtNombreCate.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCate.ForeColor = SystemColors.Control;
            txtNombreCate.Location = new Point(18, 84);
            txtNombreCate.Name = "txtNombreCate";
            txtNombreCate.Size = new Size(432, 29);
            txtNombreCate.TabIndex = 3;
            txtNombreCate.TextChanged += txtNombreCate_TextChanged;
            txtNombreCate.KeyPress += txtNombreCate_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre Categoria";
            // 
            // dgvCategorias
            // 
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(12, 268);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.Size = new Size(1321, 236);
            dgvCategorias.TabIndex = 21;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 49, 49);
            ClientSize = new Size(1345, 516);
            ControlBox = false;
            Controls.Add(dgvCategorias);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Categorias";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Categorias";
            Load += Categorias_Load;
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private GroupBox groupBox4;
        private Button btnView;
        private GroupBox groupBox3;
        private TextBox txtNombreCateUp;
        private Label label11;
        private TextBox txtIDcateUp;
        private Button btnUpdate;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtIDcate;
        private Button btnDelete;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnAdd;
        private TextBox txtNombreCate;
        private Label label2;
        private DataGridView dgvCategorias;
    }
}