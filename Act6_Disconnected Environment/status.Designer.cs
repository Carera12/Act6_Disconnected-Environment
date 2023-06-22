
namespace Act6_Disconnected_Environment
{
    partial class status
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.statusmahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.act6DataSet = new Act6_Disconnected_Environment.Act6DataSet();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.mahasiswaTableAdapter = new Act6_Disconnected_Environment.Act6DataSetTableAdapters.mahasiswaTableAdapter();
            this.status_mahasiswaTableAdapter = new Act6_Disconnected_Environment.Act6DataSetTableAdapters.status_mahasiswaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(497, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Mahasiswa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomor Induk Mahasiswa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status Mahasiswa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tahun Masuk";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusmahasiswaBindingSource, "tahun_masuk", true));
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(290, 312);
            this.cbxTahunMasuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(167, 24);
            this.cbxTahunMasuk.TabIndex = 5;
            this.cbxTahunMasuk.SelectedIndexChanged += new System.EventHandler(this.cbxTahunMasuk_SelectedIndexChanged);
            // 
            // statusmahasiswaBindingSource
            // 
            this.statusmahasiswaBindingSource.DataMember = "status_mahasiswa";
            this.statusmahasiswaBindingSource.DataSource = this.act6DataSet;
            // 
            // act6DataSet
            // 
            this.act6DataSet.DataSetName = "Act6DataSet";
            this.act6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusmahasiswaBindingSource, "status_mahasiswa", true));
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(290, 274);
            this.cbxStatusMahasiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(167, 24);
            this.cbxStatusMahasiswa.TabIndex = 6;
            this.cbxStatusMahasiswa.SelectedIndexChanged += new System.EventHandler(this.cbxStatusMahasiswa_SelectedIndexChanged);
            // 
            // cbxNama
            // 
            this.cbxNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "nama_mahasiswa", true));
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(290, 218);
            this.cbxNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(167, 24);
            this.cbxNama.TabIndex = 7;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.act6DataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(476, 213);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(476, 271);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(476, 310);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "nim", true));
            this.txtNIM.Location = new System.Drawing.Point(286, 249);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 11;
            this.txtNIM.Text = "txtNIM";
            this.txtNIM.Click += new System.EventHandler(this.txtNIM_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(590, 29);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 30);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // status_mahasiswaTableAdapter
            // 
            this.status_mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "status";
            this.Text = "status";
            this.Load += new System.EventHandler(this.status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.Button btnOpen;
        private Act6DataSet act6DataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private Act6DataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource statusmahasiswaBindingSource;
        private Act6DataSetTableAdapters.status_mahasiswaTableAdapter status_mahasiswaTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}