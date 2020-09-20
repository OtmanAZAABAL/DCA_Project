namespace PlayerUI
{
    partial class Add_Detail_Remise
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
            this.text_Percountage_Remise = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDeDhR = new System.Windows.Forms.DateTimePicker();
            this.text_Code_Remise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_nomR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AnnulerE = new System.Windows.Forms.Button();
            this.btn_ValiderE = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ActionF = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_Percountage_Remise);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateDeDhR);
            this.groupBox1.Controls.Add(this.text_Code_Remise);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_nomR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 166);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // text_Percountage_Remise
            // 
            this.text_Percountage_Remise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Percountage_Remise.Location = new System.Drawing.Point(163, 125);
            this.text_Percountage_Remise.Name = "text_Percountage_Remise";
            this.text_Percountage_Remise.Size = new System.Drawing.Size(256, 23);
            this.text_Percountage_Remise.TabIndex = 4;
            this.text_Percountage_Remise.Text = "0";
            this.text_Percountage_Remise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Percountage_Remise_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Percountage Remise:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateDeDhR
            // 
            this.dateDeDhR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateDeDhR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDeDhR.Location = new System.Drawing.Point(163, 87);
            this.dateDeDhR.Name = "dateDeDhR";
            this.dateDeDhR.Size = new System.Drawing.Size(256, 26);
            this.dateDeDhR.TabIndex = 3;
            this.dateDeDhR.ValueChanged += new System.EventHandler(this.dateDeDhR_ValueChanged);
            this.dateDeDhR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateDeDhR_MouseDown);
            this.dateDeDhR.MouseEnter += new System.EventHandler(this.dateDeDhR_MouseEnter);
            this.dateDeDhR.MouseLeave += new System.EventHandler(this.dateDeDhR_MouseLeave);
            this.dateDeDhR.MouseHover += new System.EventHandler(this.dateDeDhR_MouseHover);
            // 
            // text_Code_Remise
            // 
            this.text_Code_Remise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Code_Remise.Location = new System.Drawing.Point(163, 22);
            this.text_Code_Remise.Name = "text_Code_Remise";
            this.text_Code_Remise.Size = new System.Drawing.Size(256, 23);
            this.text_Code_Remise.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Code Remise :";
            // 
            // text_nomR
            // 
            this.text_nomR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nomR.Location = new System.Drawing.Point(163, 54);
            this.text_nomR.Name = "text_nomR";
            this.text_nomR.Size = new System.Drawing.Size(256, 23);
            this.text_nomR.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom Remise :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date Expiration :";
            // 
            // btn_AnnulerE
            // 
            this.btn_AnnulerE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.btn_AnnulerE.FlatAppearance.BorderSize = 0;
            this.btn_AnnulerE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnnulerE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnulerE.ForeColor = System.Drawing.Color.Black;
            this.btn_AnnulerE.Location = new System.Drawing.Point(243, 241);
            this.btn_AnnulerE.Name = "btn_AnnulerE";
            this.btn_AnnulerE.Size = new System.Drawing.Size(100, 35);
            this.btn_AnnulerE.TabIndex = 6;
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
            this.btn_ValiderE.Location = new System.Drawing.Point(104, 241);
            this.btn_ValiderE.Name = "btn_ValiderE";
            this.btn_ValiderE.Size = new System.Drawing.Size(100, 35);
            this.btn_ValiderE.TabIndex = 5;
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
            this.button5.Location = new System.Drawing.Point(427, 0);
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
            this.BarraTitulo.Size = new System.Drawing.Size(458, 38);
            this.BarraTitulo.TabIndex = 52;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 89;
            // 
            // Add_Detail_Remise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AnnulerE);
            this.Controls.Add(this.btn_ValiderE);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Detail_Remise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Detail_Remise";
            this.Load += new System.EventHandler(this.Add_Detail_Remise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox text_Code_Remise;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox text_nomR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AnnulerE;
        private System.Windows.Forms.Button btn_ValiderE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ActionF;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.DateTimePicker dateDeDhR;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox text_Percountage_Remise;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}