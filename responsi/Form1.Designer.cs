namespace responsi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbLogo = new PictureBox();
            lblNamaKaryawan = new Label();
            lblDepKaryawan = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lbDepartemen = new ListBox();
            tbNamaKaryawan = new TextBox();
            cbDepKaryawan = new ComboBox();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(21, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(109, 87);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblNamaKaryawan
            // 
            lblNamaKaryawan.AutoSize = true;
            lblNamaKaryawan.Location = new Point(33, 122);
            lblNamaKaryawan.Name = "lblNamaKaryawan";
            lblNamaKaryawan.Size = new Size(99, 15);
            lblNamaKaryawan.TabIndex = 1;
            lblNamaKaryawan.Text = "Nama Karyawan :";
            lblNamaKaryawan.Click += label1_Click;
            // 
            // lblDepKaryawan
            // 
            lblDepKaryawan.AutoSize = true;
            lblDepKaryawan.Location = new Point(33, 157);
            lblDepKaryawan.Name = "lblDepKaryawan";
            lblDepKaryawan.Size = new Size(91, 15);
            lblDepKaryawan.TabIndex = 2;
            lblDepKaryawan.Text = "Dep. Karyawan :";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(33, 201);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(131, 42);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(206, 201);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 42);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(391, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 42);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbDepartemen
            // 
            lbDepartemen.FormattingEnabled = true;
            lbDepartemen.ItemHeight = 15;
            lbDepartemen.Items.AddRange(new object[] { "ID Departemene:", "1. HR: HR", "2. ENG: Engineer", "3. DEV: Developer", "4. PM: Product M", "5. FIN: Finance" });
            lbDepartemen.Location = new Point(373, 16);
            lbDepartemen.Name = "lbDepartemen";
            lbDepartemen.Size = new Size(140, 109);
            lbDepartemen.TabIndex = 6;
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(169, 122);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(157, 23);
            tbNamaKaryawan.TabIndex = 7;
            // 
            // cbDepKaryawan
            // 
            cbDepKaryawan.FormattingEnabled = true;
            cbDepKaryawan.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbDepKaryawan.Location = new Point(169, 157);
            cbDepKaryawan.Name = "cbDepKaryawan";
            cbDepKaryawan.Size = new Size(157, 23);
            cbDepKaryawan.TabIndex = 8;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(33, 260);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(480, 150);
            dgvData.TabIndex = 9;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(dgvData);
            Controls.Add(cbDepKaryawan);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(lbDepartemen);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(lblDepKaryawan);
            Controls.Add(lblNamaKaryawan);
            Controls.Add(pbLogo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblNamaKaryawan;
        private Label lblDepKaryawan;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox lbDepartemen;
        private TextBox tbNamaKaryawan;
        private ComboBox cbDepKaryawan;
        private DataGridView dgvData;
    }
}
