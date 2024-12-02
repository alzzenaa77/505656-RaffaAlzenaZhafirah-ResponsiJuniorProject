namespace ResponsiRaffa
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
            label1 = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            ComboBoxKaryawan = new ComboBox();
            txtNama = new TextBox();
            btnLoadData = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 49);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 102);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Dept.Karyawan";
            label2.Click += label2_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(58, 169);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(115, 31);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Info;
            btnEdit.Location = new Point(213, 169);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 31);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Location = new Point(376, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 31);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(24, 227);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(679, 169);
            dgvData.TabIndex = 5;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // ComboBoxKaryawan
            // 
            ComboBoxKaryawan.FormattingEnabled = true;
            ComboBoxKaryawan.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            ComboBoxKaryawan.Location = new Point(241, 94);
            ComboBoxKaryawan.Name = "ComboBoxKaryawan";
            ComboBoxKaryawan.Size = new Size(174, 23);
            ComboBoxKaryawan.TabIndex = 6;
            ComboBoxKaryawan.SelectedIndexChanged += ComboBoxKaryawan_SelectedIndexChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(241, 46);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(174, 23);
            txtNama.TabIndex = 7;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.LimeGreen;
            btnLoadData.Location = new Point(598, 412);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(92, 26);
            btnLoadData.TabIndex = 8;
            btnLoadData.Text = "LoadData";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID DEPARTEMEN:", "HR : HR", "ENG : Engineer", "DEV : Developer", "PM : Product Manager", "FIN : Finance" });
            listBox1.Location = new Point(506, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(184, 139);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lambang_Tokopedia_Transparan;
            pictureBox1.Location = new Point(29, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(btnLoadData);
            Controls.Add(txtNama);
            Controls.Add(ComboBoxKaryawan);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private ComboBox ComboBoxKaryawan;
        private TextBox txtNama;
        private Button btnLoadData;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }
}
