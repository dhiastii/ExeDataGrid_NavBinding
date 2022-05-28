namespace ExeDataGrid_NavBinding
{
    partial class MainMenuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuu));
            this.DataGridView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bindnav = new System.Windows.Forms.PictureBox();
            this.gridview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindnav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSize = true;
            this.DataGridView.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.Location = new System.Drawing.Point(34, 242);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(92, 14);
            this.DataGridView.TabIndex = 1;
            this.DataGridView.Text = "DataGridView";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(210, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binding Navigation";
            // 
            // back
            // 
            this.back.Image = global::ExeDataGrid_NavBinding.Properties.Resources.previous;
            this.back.Location = new System.Drawing.Point(12, 354);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(28, 24);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 5;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ExeDataGrid_NavBinding.Properties.Resources.photo1653736281;
            this.pictureBox3.Location = new System.Drawing.Point(24, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(311, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // bindnav
            // 
            this.bindnav.Image = global::ExeDataGrid_NavBinding.Properties.Resources.photo1653735883;
            this.bindnav.Location = new System.Drawing.Point(217, 151);
            this.bindnav.Name = "bindnav";
            this.bindnav.Size = new System.Drawing.Size(98, 79);
            this.bindnav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bindnav.TabIndex = 2;
            this.bindnav.TabStop = false;
            this.bindnav.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gridview
            // 
            this.gridview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridview.Image = global::ExeDataGrid_NavBinding.Properties.Resources.DataGridView;
            this.gridview.Location = new System.Drawing.Point(37, 151);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(87, 79);
            this.gridview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gridview.TabIndex = 0;
            this.gridview.TabStop = false;
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
            // 
            // MainMenuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(351, 390);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bindnav);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.gridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindnav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gridview;
        private System.Windows.Forms.Label DataGridView;
        private System.Windows.Forms.PictureBox bindnav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox back;
    }
}