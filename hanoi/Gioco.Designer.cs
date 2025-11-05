namespace hanoi
{
    partial class Gioco
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_uno = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_due = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_tre = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_gioca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmr_dischi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_uno.SuspendLayout();
            this.pnl_due.SuspendLayout();
            this.pnl_tre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_dischi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(92, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 286);
            this.panel1.TabIndex = 0;
            // 
            // pnl_uno
            // 
            this.pnl_uno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_uno.Controls.Add(this.panel2);
            this.pnl_uno.Controls.Add(this.panel1);
            this.pnl_uno.Location = new System.Drawing.Point(12, 12);
            this.pnl_uno.Name = "pnl_uno";
            this.pnl_uno.Size = new System.Drawing.Size(200, 353);
            this.pnl_uno.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 16);
            this.panel2.TabIndex = 1;
            // 
            // pnl_due
            // 
            this.pnl_due.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_due.Controls.Add(this.panel3);
            this.pnl_due.Controls.Add(this.panel4);
            this.pnl_due.Location = new System.Drawing.Point(218, 12);
            this.pnl_due.Name = "pnl_due";
            this.pnl_due.Size = new System.Drawing.Size(200, 353);
            this.pnl_due.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 16);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(92, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 286);
            this.panel4.TabIndex = 0;
            // 
            // pnl_tre
            // 
            this.pnl_tre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_tre.Controls.Add(this.panel5);
            this.pnl_tre.Controls.Add(this.panel6);
            this.pnl_tre.Location = new System.Drawing.Point(424, 12);
            this.pnl_tre.Name = "pnl_tre";
            this.pnl_tre.Size = new System.Drawing.Size(200, 353);
            this.pnl_tre.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(0, 337);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 16);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(92, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 286);
            this.panel6.TabIndex = 0;
            // 
            // btn_gioca
            // 
            this.btn_gioca.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold);
            this.btn_gioca.Location = new System.Drawing.Point(738, 82);
            this.btn_gioca.Name = "btn_gioca";
            this.btn_gioca.Size = new System.Drawing.Size(41, 38);
            this.btn_gioca.TabIndex = 5;
            this.btn_gioca.Text = "✓";
            this.btn_gioca.UseVisualStyleBackColor = true;
            this.btn_gioca.Click += new System.EventHandler(this.btn_gioca_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dischi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nmr_dischi
            // 
            this.nmr_dischi.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold);
            this.nmr_dischi.Location = new System.Drawing.Point(663, 82);
            this.nmr_dischi.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nmr_dischi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_dischi.Name = "nmr_dischi";
            this.nmr_dischi.Size = new System.Drawing.Size(69, 38);
            this.nmr_dischi.TabIndex = 3;
            this.nmr_dischi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Noto Sans Lao", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mosse eseguite: X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mosse minime: X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Noto Sans Lao", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(633, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gioca";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Gioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_gioca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmr_dischi);
            this.Controls.Add(this.pnl_tre);
            this.Controls.Add(this.pnl_due);
            this.Controls.Add(this.pnl_uno);
            this.Name = "Gioco";
            this.Text = "Gioco";
            this.Load += new System.EventHandler(this.Gioco_Load);
            this.pnl_uno.ResumeLayout(false);
            this.pnl_due.ResumeLayout(false);
            this.pnl_tre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_dischi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_uno;
        private System.Windows.Forms.Panel pnl_due;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl_tre;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_gioca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmr_dischi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}