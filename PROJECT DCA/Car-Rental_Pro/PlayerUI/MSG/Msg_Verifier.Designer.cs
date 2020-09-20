namespace PlayerUI
{
    partial class Msg_Verifier
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
            this.btn_ValiderE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ActionF = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ValiderE
            // 
            this.btn_ValiderE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.btn_ValiderE.FlatAppearance.BorderSize = 0;
            this.btn_ValiderE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ValiderE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValiderE.ForeColor = System.Drawing.Color.Black;
            this.btn_ValiderE.Location = new System.Drawing.Point(76, 88);
            this.btn_ValiderE.Name = "btn_ValiderE";
            this.btn_ValiderE.Size = new System.Drawing.Size(91, 26);
            this.btn_ValiderE.TabIndex = 34;
            this.btn_ValiderE.Text = "OK";
            this.btn_ValiderE.UseVisualStyleBackColor = false;
            this.btn_ValiderE.Click += new System.EventHandler(this.btn_ValiderE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 37;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(203, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 32);
            this.button5.TabIndex = 16;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ActionF
            // 
            this.ActionF.AutoSize = true;
            this.ActionF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionF.ForeColor = System.Drawing.SystemColors.Window;
            this.ActionF.Location = new System.Drawing.Point(87, 9);
            this.ActionF.Name = "ActionF";
            this.ActionF.Size = new System.Drawing.Size(63, 20);
            this.ActionF.TabIndex = 18;
            this.ActionF.Text = "Vérifier ";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BarraTitulo.Controls.Add(this.ActionF);
            this.BarraTitulo.Controls.Add(this.button5);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(240, 32);
            this.BarraTitulo.TabIndex = 36;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Msg_Verifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 126);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.btn_ValiderE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Msg_Verifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifier";
            this.Load += new System.EventHandler(this.Verifier_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ValiderE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label ActionF;
        private System.Windows.Forms.Panel BarraTitulo;
    }
}