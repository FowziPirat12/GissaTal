namespace GissaTal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStörstaTalet = new System.Windows.Forms.Label();
            this.lblDator = new System.Windows.Forms.Label();
            this.lblGissaTal = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornstal = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            this.gbxSpeldata = new System.Windows.Forms.GroupBox();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.gbxSpeldata.SuspendLayout();
            this.gbxSpelet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStörstaTalet
            // 
            this.lblStörstaTalet.AutoSize = true;
            this.lblStörstaTalet.Location = new System.Drawing.Point(9, 35);
            this.lblStörstaTalet.Name = "lblStörstaTalet";
            this.lblStörstaTalet.Size = new System.Drawing.Size(72, 15);
            this.lblStörstaTalet.TabIndex = 0;
            this.lblStörstaTalet.Text = "Största talet:";
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(6, 31);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(67, 15);
            this.lblDator.TabIndex = 1;
            this.lblDator.Text = "Datorns tal:";
            // 
            // lblGissaTal
            // 
            this.lblGissaTal.AutoSize = true;
            this.lblGissaTal.Location = new System.Drawing.Point(3, 76);
            this.lblGissaTal.Name = "lblGissaTal";
            this.lblGissaTal.Size = new System.Drawing.Size(70, 15);
            this.lblGissaTal.TabIndex = 2;
            this.lblGissaTal.Text = "Gissa ett tal:";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(6, 112);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(135, 23);
            this.lblResultat.TabIndex = 3;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatornstal
            // 
            this.lblDatornstal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornstal.Location = new System.Drawing.Point(79, 27);
            this.lblDatornstal.Name = "lblDatornstal";
            this.lblDatornstal.Size = new System.Drawing.Size(71, 23);
            this.lblDatornstal.TabIndex = 4;
            this.lblDatornstal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(79, 73);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(71, 23);
            this.tbxGissa.TabIndex = 5;
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(177, 54);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 6;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(276, 37);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(108, 60);
            this.tbxMinaResultat.TabIndex = 7;
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(288, 19);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(76, 15);
            this.lblMinaResultat.TabIndex = 8;
            this.lblMinaResultat.Text = "Mina resultat";
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(300, 88);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(84, 23);
            this.btnSpelaIgen.TabIndex = 9;
            this.btnSpelaIgen.Text = "Spela igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(300, 47);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(85, 23);
            this.btnStartaSpelet.TabIndex = 10;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.btnStartaSpelet_Click);
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.ItemHeight = 15;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(87, 35);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(120, 34);
            this.lbxStörstaTalet.TabIndex = 14;
            // 
            // gbxSpeldata
            // 
            this.gbxSpeldata.Controls.Add(this.lblStörstaTalet);
            this.gbxSpeldata.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpeldata.Location = new System.Drawing.Point(12, 32);
            this.gbxSpeldata.Name = "gbxSpeldata";
            this.gbxSpeldata.Size = new System.Drawing.Size(266, 92);
            this.gbxSpeldata.TabIndex = 15;
            this.gbxSpeldata.TabStop = false;
            this.gbxSpeldata.Text = "Speldata";
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.lblDator);
            this.gbxSpelet.Controls.Add(this.lblGissaTal);
            this.gbxSpelet.Controls.Add(this.lblDatornstal);
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Controls.Add(this.lblResultat);
            this.gbxSpelet.Controls.Add(this.tbxMinaResultat);
            this.gbxSpelet.Controls.Add(this.lblMinaResultat);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Location = new System.Drawing.Point(12, 161);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Size = new System.Drawing.Size(410, 156);
            this.gbxSpelet.TabIndex = 16;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "Spelet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 358);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.gbxSpeldata);
            this.Controls.Add(this.btnStartaSpelet);
            this.Controls.Add(this.btnSpelaIgen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSpeldata.ResumeLayout(false);
            this.gbxSpeldata.PerformLayout();
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStörstaTalet;
        private Label lblDator;
        private Label lblGissaTal;
        private Label lblResultat;
        private Label lblDatornstal;
        private TextBox tbxGissa;
        private Button btnGissa;
        private TextBox tbxMinaResultat;
        private Label lblMinaResultat;
        private Button btnSpelaIgen;
        private Button btnStartaSpelet;
        private ListBox lbxStörstaTalet;
        private GroupBox gbxSpeldata;
        private GroupBox gbxSpelet;
    }
}