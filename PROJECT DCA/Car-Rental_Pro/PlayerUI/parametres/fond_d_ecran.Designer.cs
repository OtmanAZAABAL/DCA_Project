namespace PlayerUI
{
    partial class fond_d_ecran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fond_d_ecran));
            this.picture_Ecran = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ValiderE = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.text_img = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ecran)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Ecran
            // 
            this.picture_Ecran.Image = ((System.Drawing.Image)(resources.GetObject("picture_Ecran.Image")));
            this.picture_Ecran.Location = new System.Drawing.Point(71, 122);
            this.picture_Ecran.Name = "picture_Ecran";
            this.picture_Ecran.Size = new System.Drawing.Size(345, 164);
            this.picture_Ecran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Ecran.TabIndex = 88;
            this.picture_Ecran.TabStop = false;
            this.picture_Ecran.Click += new System.EventHandler(this.picture_Ecran_Click);
            this.picture_Ecran.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_Ecran_MouseClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(95, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 44);
            this.label8.TabIndex = 87;
            this.label8.Text = "Fond d\'écran";
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
            this.btn_ValiderE.TabIndex = 89;
            this.btn_ValiderE.Text = "Valider";
            this.btn_ValiderE.UseVisualStyleBackColor = false;
            this.btn_ValiderE.Click += new System.EventHandler(this.btn_ValiderE_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // text_img
            // 
            this.text_img.Location = new System.Drawing.Point(260, 254);
            this.text_img.Name = "text_img";
            this.text_img.Size = new System.Drawing.Size(100, 20);
            this.text_img.TabIndex = 90;
            this.text_img.TextChanged += new System.EventHandler(this.text_img_TextChanged);
            // 
            // fond_d_ecran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 405);
            this.Controls.Add(this.btn_ValiderE);
            this.Controls.Add(this.picture_Ecran);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fond_d_ecran";
            this.Text = "fond_d_ecran";
            this.Load += new System.EventHandler(this.fond_d_ecran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ecran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Ecran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ValiderE;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox text_img;
    }
}