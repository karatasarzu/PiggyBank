
namespace PiggyBank
{
    partial class KumbaraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KumbaraForm));
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.pnlDolu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnKir = new System.Windows.Forms.Button();
            this.cmbKagitPara = new System.Windows.Forms.ComboBox();
            this.lblBozukPara = new System.Windows.Forms.Label();
            this.cmbBozukPara = new System.Windows.Forms.ComboBox();
            this.btnKatla = new System.Windows.Forms.Button();
            this.lblParaHacmi = new System.Windows.Forms.Label();
            this.lblFazladan = new System.Windows.Forms.Label();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotal.Controls.Add(this.pnlDolu);
            this.pnlTotal.Location = new System.Drawing.Point(552, 59);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(200, 347);
            this.pnlTotal.TabIndex = 8;
            // 
            // pnlDolu
            // 
            this.pnlDolu.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDolu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDolu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDolu.Location = new System.Drawing.Point(0, 257);
            this.pnlDolu.Name = "pnlDolu";
            this.pnlDolu.Size = new System.Drawing.Size(196, 86);
            this.pnlDolu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kağıt Para";
            // 
            // btnSalla
            // 
            this.btnSalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalla.BackColor = System.Drawing.Color.Transparent;
            this.btnSalla.ForeColor = System.Drawing.Color.Black;
            this.btnSalla.Location = new System.Drawing.Point(29, 379);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(75, 23);
            this.btnSalla.TabIndex = 16;
            this.btnSalla.Text = "Salla!";
            this.btnSalla.UseVisualStyleBackColor = false;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnParaAt
            // 
            this.btnParaAt.BackColor = System.Drawing.Color.Transparent;
            this.btnParaAt.ForeColor = System.Drawing.Color.Black;
            this.btnParaAt.Location = new System.Drawing.Point(177, 109);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(75, 23);
            this.btnParaAt.TabIndex = 15;
            this.btnParaAt.Text = "Para At!";
            this.btnParaAt.UseVisualStyleBackColor = false;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnKir
            // 
            this.btnKir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKir.BackColor = System.Drawing.Color.Transparent;
            this.btnKir.ForeColor = System.Drawing.Color.Black;
            this.btnKir.Location = new System.Drawing.Point(177, 379);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(75, 23);
            this.btnKir.TabIndex = 14;
            this.btnKir.Text = "Kır!";
            this.btnKir.UseVisualStyleBackColor = false;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // cmbKagitPara
            // 
            this.cmbKagitPara.ForeColor = System.Drawing.Color.Black;
            this.cmbKagitPara.FormattingEnabled = true;
            this.cmbKagitPara.Location = new System.Drawing.Point(29, 59);
            this.cmbKagitPara.Name = "cmbKagitPara";
            this.cmbKagitPara.Size = new System.Drawing.Size(121, 21);
            this.cmbKagitPara.TabIndex = 12;
            this.cmbKagitPara.SelectedIndexChanged += new System.EventHandler(this.cmbKagitPara_SelectedIndexChanged);
            // 
            // lblBozukPara
            // 
            this.lblBozukPara.AutoSize = true;
            this.lblBozukPara.ForeColor = System.Drawing.Color.White;
            this.lblBozukPara.Location = new System.Drawing.Point(26, 93);
            this.lblBozukPara.Name = "lblBozukPara";
            this.lblBozukPara.Size = new System.Drawing.Size(62, 13);
            this.lblBozukPara.TabIndex = 20;
            this.lblBozukPara.Text = "Bozuk Para";
            // 
            // cmbBozukPara
            // 
            this.cmbBozukPara.ForeColor = System.Drawing.Color.Black;
            this.cmbBozukPara.FormattingEnabled = true;
            this.cmbBozukPara.Location = new System.Drawing.Point(29, 109);
            this.cmbBozukPara.Name = "cmbBozukPara";
            this.cmbBozukPara.Size = new System.Drawing.Size(121, 21);
            this.cmbBozukPara.TabIndex = 19;
            this.cmbBozukPara.SelectedIndexChanged += new System.EventHandler(this.cmbBozukPara_SelectedIndexChanged);
            // 
            // btnKatla
            // 
            this.btnKatla.BackColor = System.Drawing.Color.Transparent;
            this.btnKatla.ForeColor = System.Drawing.Color.Black;
            this.btnKatla.Location = new System.Drawing.Point(177, 57);
            this.btnKatla.Name = "btnKatla";
            this.btnKatla.Size = new System.Drawing.Size(75, 23);
            this.btnKatla.TabIndex = 21;
            this.btnKatla.Text = "Katla!";
            this.btnKatla.UseVisualStyleBackColor = false;
            this.btnKatla.Visible = false;
            this.btnKatla.Click += new System.EventHandler(this.btnKatla_Click);
            // 
            // lblParaHacmi
            // 
            this.lblParaHacmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParaHacmi.AutoSize = true;
            this.lblParaHacmi.ForeColor = System.Drawing.Color.White;
            this.lblParaHacmi.Location = new System.Drawing.Point(551, 9);
            this.lblParaHacmi.Name = "lblParaHacmi";
            this.lblParaHacmi.Size = new System.Drawing.Size(136, 13);
            this.lblParaHacmi.TabIndex = 22;
            this.lblParaHacmi.Text = "Paraların kapladığı hacim: 0";
            // 
            // lblFazladan
            // 
            this.lblFazladan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFazladan.AutoSize = true;
            this.lblFazladan.ForeColor = System.Drawing.Color.White;
            this.lblFazladan.Location = new System.Drawing.Point(551, 31);
            this.lblFazladan.Name = "lblFazladan";
            this.lblFazladan.Size = new System.Drawing.Size(182, 13);
            this.lblFazladan.TabIndex = 23;
            this.lblFazladan.Text = "Paraların kapladığı fazladan hacim:  0";
            // 
            // KumbaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(164)))), ((int)(((byte)(172)))));
            this.BackgroundImage = global::PiggyBank.Properties.Resources.Glass_Piggy_Bank;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(790, 430);
            this.Controls.Add(this.lblFazladan);
            this.Controls.Add(this.lblParaHacmi);
            this.Controls.Add(this.btnKatla);
            this.Controls.Add(this.lblBozukPara);
            this.Controls.Add(this.cmbBozukPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnParaAt);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.cmbKagitPara);
            this.Controls.Add(this.pnlTotal);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KumbaraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piggy Bank";
            this.pnlTotal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlDolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.ComboBox cmbKagitPara;
        private System.Windows.Forms.Label lblBozukPara;
        private System.Windows.Forms.ComboBox cmbBozukPara;
        private System.Windows.Forms.Button btnKatla;
        private System.Windows.Forms.Label lblParaHacmi;
        private System.Windows.Forms.Label lblFazladan;
    }
}

