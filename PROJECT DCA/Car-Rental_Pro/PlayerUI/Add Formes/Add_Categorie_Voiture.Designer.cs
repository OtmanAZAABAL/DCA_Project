﻿namespace PlayerUI
{
    partial class Add_Categorie_Voiture
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_N_p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_emailPar_Heur = new System.Windows.Forms.TextBox();
            this.text_Cout_Par_Jour = new System.Windows.Forms.TextBox();
            this.text_N_C = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_N_B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AnnulerE = new System.Windows.Forms.Button();
            this.btn_ValiderE = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ActionF = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_N_p);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_emailPar_Heur);
            this.groupBox1.Controls.Add(this.text_Cout_Par_Jour);
            this.groupBox1.Controls.Add(this.text_N_C);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_N_B);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 177);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // text_N_p
            // 
            this.text_N_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_N_p.Location = new System.Drawing.Point(160, 83);
            this.text_N_p.Name = "text_N_p";
            this.text_N_p.Size = new System.Drawing.Size(259, 23);
            this.text_N_p.TabIndex = 3;
            this.text_N_p.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_N_p_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cout Par Jour :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(7, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Frois retard par heur :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // text_emailPar_Heur
            // 
            this.text_emailPar_Heur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_emailPar_Heur.Location = new System.Drawing.Point(160, 139);
            this.text_emailPar_Heur.Name = "text_emailPar_Heur";
            this.text_emailPar_Heur.Size = new System.Drawing.Size(259, 23);
            this.text_emailPar_Heur.TabIndex = 5;
            this.text_emailPar_Heur.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.text_emailPar_Heur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_emailPar_Heur_KeyPress);
            // 
            // text_Cout_Par_Jour
            // 
            this.text_Cout_Par_Jour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Cout_Par_Jour.Location = new System.Drawing.Point(160, 110);
            this.text_Cout_Par_Jour.Name = "text_Cout_Par_Jour";
            this.text_Cout_Par_Jour.Size = new System.Drawing.Size(259, 23);
            this.text_Cout_Par_Jour.TabIndex = 4;
            this.text_Cout_Par_Jour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Cout_Par_Jour_KeyPress);
            // 
            // text_N_C
            // 
            this.text_N_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_N_C.Location = new System.Drawing.Point(160, 22);
            this.text_N_C.Name = "text_N_C";
            this.text_N_C.Size = new System.Drawing.Size(259, 23);
            this.text_N_C.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nom Categorie :";
            // 
            // text_N_B
            // 
            this.text_N_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_N_B.Location = new System.Drawing.Point(160, 54);
            this.text_N_B.Name = "text_N_B";
            this.text_N_B.Size = new System.Drawing.Size(259, 23);
            this.text_N_B.TabIndex = 2;
            this.text_N_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_N_B_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre Bagages :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre Perssonne :";
            // 
            // btn_AnnulerE
            // 
            this.btn_AnnulerE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.btn_AnnulerE.FlatAppearance.BorderSize = 0;
            this.btn_AnnulerE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnnulerE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnulerE.ForeColor = System.Drawing.Color.Black;
            this.btn_AnnulerE.Location = new System.Drawing.Point(253, 259);
            this.btn_AnnulerE.Name = "btn_AnnulerE";
            this.btn_AnnulerE.Size = new System.Drawing.Size(100, 35);
            this.btn_AnnulerE.TabIndex = 7;
            this.btn_AnnulerE.Text = "Annuler";
            this.btn_AnnulerE.UseVisualStyleBackColor = false;
            this.btn_AnnulerE.Click += new System.EventHandler(this.btn_AnnulerE_Click);
            // 
            // btn_ValiderE
            // 
            this.btn_ValiderE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.btn_ValiderE.FlatAppearance.BorderSize = 0;
            this.btn_ValiderE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ValiderE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValiderE.ForeColor = System.Drawing.Color.Black;
            this.btn_ValiderE.Location = new System.Drawing.Point(93, 259);
            this.btn_ValiderE.Name = "btn_ValiderE";
            this.btn_ValiderE.Size = new System.Drawing.Size(100, 35);
            this.btn_ValiderE.TabIndex = 6;
            this.btn_ValiderE.Text = "Valider";
            this.btn_ValiderE.UseVisualStyleBackColor = false;
            this.btn_ValiderE.Click += new System.EventHandler(this.btn_ValiderE_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(117, 167);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(129, 80);
            this.dataGridView1.TabIndex = 57;
            // 
            // ActionF
            // 
            this.ActionF.AutoSize = true;
            this.ActionF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionF.ForeColor = System.Drawing.SystemColors.Window;
            this.ActionF.Location = new System.Drawing.Point(181, 9);
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
            this.button5.Location = new System.Drawing.Point(420, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 38);
            this.button5.TabIndex = 16;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.BarraTitulo.Size = new System.Drawing.Size(451, 38);
            this.BarraTitulo.TabIndex = 52;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Add_Categorie_Voiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AnnulerE);
            this.Controls.Add(this.btn_ValiderE);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Categorie_Voiture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Categorie_Voiture";
            this.Load += new System.EventHandler(this.Add_Categorie_Voiture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox text_emailPar_Heur;
        public System.Windows.Forms.TextBox text_Cout_Par_Jour;
        public System.Windows.Forms.TextBox text_N_C;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox text_N_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AnnulerE;
        private System.Windows.Forms.Button btn_ValiderE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ActionF;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel BarraTitulo;
        public System.Windows.Forms.TextBox text_N_p;
    }
}