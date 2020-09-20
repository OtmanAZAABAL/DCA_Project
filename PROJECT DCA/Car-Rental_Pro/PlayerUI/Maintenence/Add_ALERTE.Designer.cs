namespace PlayerUI
{
    partial class Add_ALERTE
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.ActionF = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Vb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Mot_de_pasee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_prenom_user = new System.Windows.Forms.TextBox();
            this.text_id_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_nomUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ValiderE = new System.Windows.Forms.Button();
            this.btn_AnnulerE = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BarraTitulo.Controls.Add(this.ActionF);
            this.BarraTitulo.Controls.Add(this.button5);
            this.BarraTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(525, 38);
            this.BarraTitulo.TabIndex = 65;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // ActionF
            // 
            this.ActionF.AutoSize = true;
            this.ActionF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionF.ForeColor = System.Drawing.SystemColors.Window;
            this.ActionF.Location = new System.Drawing.Point(220, 9);
            this.ActionF.Name = "ActionF";
            this.ActionF.Size = new System.Drawing.Size(0, 20);
            this.ActionF.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(494, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 38);
            this.button5.TabIndex = 16;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Vb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_Mot_de_pasee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_prenom_user);
            this.groupBox1.Controls.Add(this.text_id_user);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_nomUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 197);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_Vb
            // 
            this.cb_Vb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Vb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_Vb.FormattingEnabled = true;
            this.cb_Vb.Items.AddRange(new object[] {
            "administarteur",
            "User"});
            this.cb_Vb.Location = new System.Drawing.Point(212, 150);
            this.cb_Vb.Name = "cb_Vb";
            this.cb_Vb.Size = new System.Drawing.Size(254, 24);
            this.cb_Vb.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Masquer :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(7, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Numero_Enrg :";
            // 
            // text_Mot_de_pasee
            // 
            this.text_Mot_de_pasee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Mot_de_pasee.Location = new System.Drawing.Point(211, 121);
            this.text_Mot_de_pasee.Name = "text_Mot_de_pasee";
            this.text_Mot_de_pasee.Size = new System.Drawing.Size(255, 23);
            this.text_Mot_de_pasee.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Quand :";
            // 
            // text_prenom_user
            // 
            this.text_prenom_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_prenom_user.Location = new System.Drawing.Point(211, 92);
            this.text_prenom_user.Name = "text_prenom_user";
            this.text_prenom_user.Size = new System.Drawing.Size(255, 23);
            this.text_prenom_user.TabIndex = 30;
            // 
            // text_id_user
            // 
            this.text_id_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id_user.Location = new System.Drawing.Point(211, 25);
            this.text_id_user.Name = "text_id_user";
            this.text_id_user.Size = new System.Drawing.Size(255, 23);
            this.text_id_user.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Id ALERTE :";
            // 
            // text_nomUser
            // 
            this.text_nomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nomUser.Location = new System.Drawing.Point(211, 57);
            this.text_nomUser.Name = "text_nomUser";
            this.text_nomUser.Size = new System.Drawing.Size(255, 23);
            this.text_nomUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Type_ALERTE :";
            // 
            // btn_ValiderE
            // 
            this.btn_ValiderE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.btn_ValiderE.FlatAppearance.BorderSize = 0;
            this.btn_ValiderE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ValiderE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValiderE.ForeColor = System.Drawing.Color.Black;
            this.btn_ValiderE.Location = new System.Drawing.Point(93, 293);
            this.btn_ValiderE.Name = "btn_ValiderE";
            this.btn_ValiderE.Size = new System.Drawing.Size(146, 36);
            this.btn_ValiderE.TabIndex = 75;
            this.btn_ValiderE.Text = "Valider";
            this.btn_ValiderE.UseVisualStyleBackColor = false;
            // 
            // btn_AnnulerE
            // 
            this.btn_AnnulerE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.btn_AnnulerE.FlatAppearance.BorderSize = 0;
            this.btn_AnnulerE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnnulerE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnulerE.ForeColor = System.Drawing.Color.Black;
            this.btn_AnnulerE.Location = new System.Drawing.Point(291, 293);
            this.btn_AnnulerE.Name = "btn_AnnulerE";
            this.btn_AnnulerE.Size = new System.Drawing.Size(146, 36);
            this.btn_AnnulerE.TabIndex = 76;
            this.btn_AnnulerE.Text = "Annuler";
            this.btn_AnnulerE.UseVisualStyleBackColor = false;
            // 
            // Add_ALERTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 353);
            this.Controls.Add(this.btn_ValiderE);
            this.Controls.Add(this.btn_AnnulerE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_ALERTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_ALERTE";
            this.Load += new System.EventHandler(this.Add_ALERTE_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label ActionF;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Vb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox text_Mot_de_pasee;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox text_prenom_user;
        public System.Windows.Forms.TextBox text_id_user;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox text_nomUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ValiderE;
        private System.Windows.Forms.Button btn_AnnulerE;
    }
}