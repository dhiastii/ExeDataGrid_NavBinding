namespace ExeDataGrid_NavBinding
{
    partial class bindingnav2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bindingnav2));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tlpmhs = new System.Windows.Forms.Label();
            this.sexmhs = new System.Windows.Forms.Label();
            this.alamatmhs = new System.Windows.Forms.Label();
            this.namamhs = new System.Windows.Forms.Label();
            this.nimmhs = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.nim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prodiTIDataSet1 = new ExeDataGrid_NavBinding.ProdiTIDataSet1();
            this.mahasiswa1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa1TableAdapter = new ExeDataGrid_NavBinding.ProdiTIDataSet1TableAdapters.Mahasiswa1TableAdapter();
            this.mahasiswa1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswa1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.BindingSource = this.mahasiswa1BindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(351, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tlpmhs
            // 
            this.tlpmhs.AutoSize = true;
            this.tlpmhs.BackColor = System.Drawing.Color.Transparent;
            this.tlpmhs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswa1BindingSource, "PhoneMhs", true));
            this.tlpmhs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpmhs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpmhs.Location = new System.Drawing.Point(200, 275);
            this.tlpmhs.Name = "tlpmhs";
            this.tlpmhs.Size = new System.Drawing.Size(101, 14);
            this.tlpmhs.TabIndex = 22;
            this.tlpmhs.Text = "Nomor Telepon";
            // 
            // sexmhs
            // 
            this.sexmhs.AutoSize = true;
            this.sexmhs.BackColor = System.Drawing.Color.Transparent;
            this.sexmhs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswa1BindingSource, "Sex", true));
            this.sexmhs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexmhs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sexmhs.Location = new System.Drawing.Point(200, 235);
            this.sexmhs.Name = "sexmhs";
            this.sexmhs.Size = new System.Drawing.Size(91, 14);
            this.sexmhs.TabIndex = 21;
            this.sexmhs.Text = "Jenis Kelamin";
            // 
            // alamatmhs
            // 
            this.alamatmhs.AutoSize = true;
            this.alamatmhs.BackColor = System.Drawing.Color.Transparent;
            this.alamatmhs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswa1BindingSource, "AlamatMhs", true));
            this.alamatmhs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatmhs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alamatmhs.Location = new System.Drawing.Point(200, 191);
            this.alamatmhs.Name = "alamatmhs";
            this.alamatmhs.Size = new System.Drawing.Size(124, 14);
            this.alamatmhs.TabIndex = 20;
            this.alamatmhs.Text = "Alamat Mahasiswa";
            // 
            // namamhs
            // 
            this.namamhs.AutoSize = true;
            this.namamhs.BackColor = System.Drawing.Color.Transparent;
            this.namamhs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswa1BindingSource, "NamaMhs", true));
            this.namamhs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namamhs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.namamhs.Location = new System.Drawing.Point(200, 145);
            this.namamhs.Name = "namamhs";
            this.namamhs.Size = new System.Drawing.Size(117, 14);
            this.namamhs.TabIndex = 19;
            this.namamhs.Text = "Nama Mahasiswa";
            // 
            // nimmhs
            // 
            this.nimmhs.AutoSize = true;
            this.nimmhs.BackColor = System.Drawing.Color.Transparent;
            this.nimmhs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswa1BindingSource, "NIM", true));
            this.nimmhs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimmhs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nimmhs.Location = new System.Drawing.Point(200, 102);
            this.nimmhs.Name = "nimmhs";
            this.nimmhs.Size = new System.Drawing.Size(105, 14);
            this.nimmhs.TabIndex = 18;
            this.nimmhs.Text = "NIM Mahasiswa";
            // 
            // tlp
            // 
            this.tlp.AutoSize = true;
            this.tlp.BackColor = System.Drawing.Color.Transparent;
            this.tlp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlp.Location = new System.Drawing.Point(27, 275);
            this.tlp.Name = "tlp";
            this.tlp.Size = new System.Drawing.Size(101, 14);
            this.tlp.TabIndex = 17;
            this.tlp.Text = "Nomor Telepon";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.BackColor = System.Drawing.Color.Transparent;
            this.sex.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sex.Location = new System.Drawing.Point(27, 235);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(91, 14);
            this.sex.TabIndex = 16;
            this.sex.Text = "Jenis Kelamin";
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.BackColor = System.Drawing.Color.Transparent;
            this.alamat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alamat.Location = new System.Drawing.Point(27, 191);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(124, 14);
            this.alamat.TabIndex = 15;
            this.alamat.Text = "Alamat Mahasiswa";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.BackColor = System.Drawing.Color.Transparent;
            this.nama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nama.Location = new System.Drawing.Point(27, 145);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(117, 14);
            this.nama.TabIndex = 14;
            this.nama.Text = "Nama Mahasiswa";
            // 
            // nim
            // 
            this.nim.AutoSize = true;
            this.nim.BackColor = System.Drawing.Color.Transparent;
            this.nim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nim.Location = new System.Drawing.Point(27, 102);
            this.nim.Name = "nim";
            this.nim.Size = new System.Drawing.Size(105, 14);
            this.nim.TabIndex = 13;
            this.nim.Text = "NIM Mahasiswa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExeDataGrid_NavBinding.Properties.Resources.previous;
            this.pictureBox1.Location = new System.Drawing.Point(12, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // prodiTIDataSet1
            // 
            this.prodiTIDataSet1.DataSetName = "ProdiTIDataSet1";
            this.prodiTIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswa1BindingSource
            // 
            this.mahasiswa1BindingSource.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource.DataSource = this.prodiTIDataSet1;
            // 
            // mahasiswa1TableAdapter
            // 
            this.mahasiswa1TableAdapter.ClearBeforeFill = true;
            // 
            // mahasiswa1BindingSource1
            // 
            this.mahasiswa1BindingSource1.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource1.DataSource = this.prodiTIDataSet1;
            // 
            // mahasiswa1BindingSource2
            // 
            this.mahasiswa1BindingSource2.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource2.DataSource = this.prodiTIDataSet1;
            // 
            // mahasiswa1BindingSource3
            // 
            this.mahasiswa1BindingSource3.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource3.DataSource = this.prodiTIDataSet1;
            // 
            // mahasiswa1BindingSource4
            // 
            this.mahasiswa1BindingSource4.DataMember = "Mahasiswa1";
            this.mahasiswa1BindingSource4.DataSource = this.prodiTIDataSet1;
            // 
            // bindingnav2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(351, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tlpmhs);
            this.Controls.Add(this.sexmhs);
            this.Controls.Add(this.alamatmhs);
            this.Controls.Add(this.namamhs);
            this.Controls.Add(this.nimmhs);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.nim);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "bindingnav2";
            this.Text = "bindingnav2";
            this.Load += new System.EventHandler(this.bindingnav2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswa1BindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.Label tlpmhs;
        public System.Windows.Forms.Label sexmhs;
        public System.Windows.Forms.Label alamatmhs;
        public System.Windows.Forms.Label namamhs;
        public System.Windows.Forms.Label nimmhs;
        public System.Windows.Forms.Label tlp;
        public System.Windows.Forms.Label sex;
        public System.Windows.Forms.Label alamat;
        public System.Windows.Forms.Label nama;
        public System.Windows.Forms.Label nim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ProdiTIDataSet1 prodiTIDataSet1;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource;
        private ProdiTIDataSet1TableAdapters.Mahasiswa1TableAdapter mahasiswa1TableAdapter;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource4;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource3;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource2;
        private System.Windows.Forms.BindingSource mahasiswa1BindingSource1;
    }
}