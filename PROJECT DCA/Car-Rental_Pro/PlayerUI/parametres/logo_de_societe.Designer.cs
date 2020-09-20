namespace PlayerUI
{
    partial class logo_de_societe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logo_de_societe));
            this.label8 = new System.Windows.Forms.Label();
            this.picture_Logo = new System.Windows.Forms.PictureBox();
            this.btn_ValiderE = new System.Windows.Forms.Button();
            this.text_img = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(95, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 44);
            this.label8.TabIndex = 85;
            this.label8.Text = "Logo de societe";
            // 
            // picture_Logo
            // 
            this.picture_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_Logo.Image")));
            this.picture_Logo.Location = new System.Drawing.Point(71, 122);
            this.picture_Logo.Name = "picture_Logo";
            this.picture_Logo.Size = new System.Drawing.Size(345, 164);
            this.picture_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Logo.TabIndex = 86;
            this.picture_Logo.TabStop = false;
            this.picture_Logo.Click += new System.EventHandler(this.picture_Logo_Click);
            this.picture_Logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_Logo_MouseClick);
            this.picture_Logo.MouseEnter += new System.EventHandler(this.picture_Logo_MouseEnter);
            // 
            // btn_ValiderE
            // 
            this.btn_ValiderE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.btn_ValiderE.FlatAppearance.BorderSize = 0;
            this.btn_ValiderE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ValiderE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValiderE.ForeColor = System.Drawing.Color.Black;
            this.btn_ValiderE.Location = new System.Drawing.Point(141, 346);
            this.btn_ValiderE.Name = "btn_ValiderE";
            this.btn_ValiderE.Size = new System.Drawing.Size(199, 35);
            this.btn_ValiderE.TabIndex = 90;
            this.btn_ValiderE.Text = "Valider";
            this.btn_ValiderE.UseVisualStyleBackColor = false;
            this.btn_ValiderE.Click += new System.EventHandler(this.btn_ValiderE_Click);
            // 
            // text_img
            // 
            this.text_img.Location = new System.Drawing.Point(261, 224);
            this.text_img.Name = "text_img";
            this.text_img.Size = new System.Drawing.Size(100, 20);
            this.text_img.TabIndex = 91;
            this.text_img.TextChanged += new System.EventHandler(this.text_img_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // logo_de_societe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 405);
            this.Controls.Add(this.btn_ValiderE);
            this.Controls.Add(this.picture_Logo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logo_de_societe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logo_de_societe";
            this.Load += new System.EventHandler(this.logo_de_societe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picture_Logo;
        private System.Windows.Forms.Button btn_ValiderE;
        private System.Windows.Forms.TextBox text_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}