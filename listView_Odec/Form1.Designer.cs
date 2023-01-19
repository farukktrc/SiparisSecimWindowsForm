namespace listView_Odec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.lblaciklama = new System.Windows.Forms.Label();
            this.cbketcap = new System.Windows.Forms.CheckBox();
            this.cbmayonez = new System.Windows.Forms.CheckBox();
            this.cbhardal = new System.Windows.Forms.CheckBox();
            this.cbparmesan = new System.Windows.Forms.CheckBox();
            this.cbtursu = new System.Windows.Forms.CheckBox();
            this.lblextra = new System.Windows.Forms.Label();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.lbsiparisler = new System.Windows.Forms.ListBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btntamamla = new System.Windows.Forms.Button();
            this.lbltoplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Items.AddRange(new object[] {
            "HAMBURGER",
            "TAVUKBURGER",
            "SOSİSLİ",
            "PATATES"});
            this.cmbMenu.Location = new System.Drawing.Point(49, 211);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(137, 23);
            this.cmbMenu.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(49, 193);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(38, 15);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menü";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(49, 270);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(137, 23);
            this.txtaciklama.TabIndex = 3;
            // 
            // lblaciklama
            // 
            this.lblaciklama.AutoSize = true;
            this.lblaciklama.Location = new System.Drawing.Point(49, 252);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(56, 15);
            this.lblaciklama.TabIndex = 4;
            this.lblaciklama.Text = "Açıklama";
            // 
            // cbketcap
            // 
            this.cbketcap.AutoSize = true;
            this.cbketcap.Location = new System.Drawing.Point(49, 318);
            this.cbketcap.Name = "cbketcap";
            this.cbketcap.Size = new System.Drawing.Size(62, 19);
            this.cbketcap.TabIndex = 5;
            this.cbketcap.Text = "Ketçap";
            this.cbketcap.UseVisualStyleBackColor = true;
            // 
            // cbmayonez
            // 
            this.cbmayonez.AutoSize = true;
            this.cbmayonez.Location = new System.Drawing.Point(112, 318);
            this.cbmayonez.Name = "cbmayonez";
            this.cbmayonez.Size = new System.Drawing.Size(74, 19);
            this.cbmayonez.TabIndex = 6;
            this.cbmayonez.Text = "Mayonez";
            this.cbmayonez.UseVisualStyleBackColor = true;
            // 
            // cbhardal
            // 
            this.cbhardal.AutoSize = true;
            this.cbhardal.Location = new System.Drawing.Point(49, 343);
            this.cbhardal.Name = "cbhardal";
            this.cbhardal.Size = new System.Drawing.Size(61, 19);
            this.cbhardal.TabIndex = 7;
            this.cbhardal.Text = "Hardal";
            this.cbhardal.UseVisualStyleBackColor = true;
            // 
            // cbparmesan
            // 
            this.cbparmesan.AutoSize = true;
            this.cbparmesan.Location = new System.Drawing.Point(112, 343);
            this.cbparmesan.Name = "cbparmesan";
            this.cbparmesan.Size = new System.Drawing.Size(78, 19);
            this.cbparmesan.TabIndex = 8;
            this.cbparmesan.Text = "Parmesan";
            this.cbparmesan.UseVisualStyleBackColor = true;
            // 
            // cbtursu
            // 
            this.cbtursu.AutoSize = true;
            this.cbtursu.Location = new System.Drawing.Point(49, 368);
            this.cbtursu.Name = "cbtursu";
            this.cbtursu.Size = new System.Drawing.Size(55, 19);
            this.cbtursu.TabIndex = 9;
            this.cbtursu.Text = "Turşu";
            this.cbtursu.UseVisualStyleBackColor = true;
            // 
            // lblextra
            // 
            this.lblextra.AutoSize = true;
            this.lblextra.Location = new System.Drawing.Point(49, 300);
            this.lblextra.Name = "lblextra";
            this.lblextra.Size = new System.Drawing.Size(33, 15);
            this.lblextra.TabIndex = 10;
            this.lblextra.Text = "Extra";
            // 
            // btnsiparis
            // 
            this.btnsiparis.Location = new System.Drawing.Point(49, 416);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(137, 59);
            this.btnsiparis.TabIndex = 11;
            this.btnsiparis.Text = "Sipariş Al";
            this.btnsiparis.UseVisualStyleBackColor = true;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // lbsiparisler
            // 
            this.lbsiparisler.FormattingEnabled = true;
            this.lbsiparisler.ItemHeight = 15;
            this.lbsiparisler.Location = new System.Drawing.Point(289, 33);
            this.lbsiparisler.Name = "lbsiparisler";
            this.lbsiparisler.Size = new System.Drawing.Size(332, 394);
            this.lbsiparisler.TabIndex = 12;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(289, 452);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "SİPARİŞ SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btntamamla
            // 
            this.btntamamla.Location = new System.Drawing.Point(493, 452);
            this.btntamamla.Name = "btntamamla";
            this.btntamamla.Size = new System.Drawing.Size(128, 23);
            this.btntamamla.TabIndex = 14;
            this.btntamamla.Text = "siparişi tamamla";
            this.btntamamla.UseVisualStyleBackColor = true;
            this.btntamamla.Click += new System.EventHandler(this.btntamamla_Click);
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(289, 496);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(83, 15);
            this.lbltoplam.TabIndex = 15;
            this.lbltoplam.Text = "Toplam Fiyat : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 545);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.btntamamla);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.lbsiparisler);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.lblextra);
            this.Controls.Add(this.cbtursu);
            this.Controls.Add(this.cbparmesan);
            this.Controls.Add(this.cbhardal);
            this.Controls.Add(this.cbmayonez);
            this.Controls.Add(this.cbketcap);
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbMenu;
        private Label lblMenu;
        private TextBox txtaciklama;
        private Label lblaciklama;
        private CheckBox cbketcap;
        private CheckBox cbmayonez;
        private CheckBox cbhardal;
        private CheckBox cbparmesan;
        private CheckBox cbtursu;
        private Label lblextra;
        private Button btnsiparis;
        private ListBox lbsiparisler;
        private Button btnsil;
        private Button btntamamla;
        private Label lbltoplam;
    }
}