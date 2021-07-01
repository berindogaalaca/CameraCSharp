
namespace CameraOrnek1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CAMERAS = new System.Windows.Forms.ComboBox();
            this.CAM = new System.Windows.Forms.Label();
            this.GORUNTU = new System.Windows.Forms.PictureBox();
            this.START = new System.Windows.Forms.Button();
            this.CAPTURE = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TIMER = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CHOOSESECOND = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CREDIT = new System.Windows.Forms.Button();
            this.PROJEADI = new System.Windows.Forms.Label();
            this.DOWNPAGE = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.Button();
            this.SAYAC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GORUNTU)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CAMERAS
            // 
            this.CAMERAS.FormattingEnabled = true;
            this.CAMERAS.Location = new System.Drawing.Point(369, 52);
            this.CAMERAS.Name = "CAMERAS";
            this.CAMERAS.Size = new System.Drawing.Size(286, 24);
            this.CAMERAS.TabIndex = 0;
            this.CAMERAS.MouseHover += new System.EventHandler(this.CAMERAS_MouseHover);
            // 
            // CAM
            // 
            this.CAM.AutoSize = true;
            this.CAM.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.CAM.Location = new System.Drawing.Point(191, 52);
            this.CAM.Name = "CAM";
            this.CAM.Size = new System.Drawing.Size(101, 24);
            this.CAM.TabIndex = 1;
            this.CAM.Text = "Cameras:";
            // 
            // GORUNTU
            // 
            this.GORUNTU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GORUNTU.Location = new System.Drawing.Point(103, 104);
            this.GORUNTU.Name = "GORUNTU";
            this.GORUNTU.Size = new System.Drawing.Size(640, 360);
            this.GORUNTU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GORUNTU.TabIndex = 2;
            this.GORUNTU.TabStop = false;
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Transparent;
            this.START.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.START.FlatAppearance.BorderSize = 0;
            this.START.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.START.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.START.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.START.Image = ((System.Drawing.Image)(resources.GetObject("START.Image")));
            this.START.Location = new System.Drawing.Point(810, 128);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(204, 46);
            this.START.TabIndex = 3;
            this.START.Text = "  START";
            this.START.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            this.START.MouseHover += new System.EventHandler(this.START_MouseHover);
            // 
            // CAPTURE
            // 
            this.CAPTURE.BackColor = System.Drawing.Color.Transparent;
            this.CAPTURE.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.CAPTURE.FlatAppearance.BorderSize = 0;
            this.CAPTURE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CAPTURE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CAPTURE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CAPTURE.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CAPTURE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.CAPTURE.Image = ((System.Drawing.Image)(resources.GetObject("CAPTURE.Image")));
            this.CAPTURE.Location = new System.Drawing.Point(810, 214);
            this.CAPTURE.Name = "CAPTURE";
            this.CAPTURE.Size = new System.Drawing.Size(225, 46);
            this.CAPTURE.TabIndex = 4;
            this.CAPTURE.Text = "  CAPTURE";
            this.CAPTURE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CAPTURE.UseVisualStyleBackColor = false;
            this.CAPTURE.Click += new System.EventHandler(this.CAPTURE_Click_1);
            this.CAPTURE.MouseHover += new System.EventHandler(this.CAPTURE_MouseHover);
            // 
            // SAVE
            // 
            this.SAVE.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.SAVE.FlatAppearance.BorderSize = 0;
            this.SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.SAVE.Image = ((System.Drawing.Image)(resources.GetObject("SAVE.Image")));
            this.SAVE.Location = new System.Drawing.Point(810, 300);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(201, 46);
            this.SAVE.TabIndex = 6;
            this.SAVE.Text = "  SAVE";
            this.SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            this.SAVE.MouseHover += new System.EventHandler(this.SAVE_MouseHover);
            // 
            // TIMER
            // 
            this.TIMER.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.TIMER.FlatAppearance.BorderSize = 0;
            this.TIMER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TIMER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TIMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TIMER.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TIMER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.TIMER.Image = ((System.Drawing.Image)(resources.GetObject("TIMER.Image")));
            this.TIMER.Location = new System.Drawing.Point(810, 386);
            this.TIMER.Name = "TIMER";
            this.TIMER.Size = new System.Drawing.Size(184, 46);
            this.TIMER.TabIndex = 7;
            this.TIMER.Text = "  TIMER";
            this.TIMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TIMER.UseVisualStyleBackColor = true;
            this.TIMER.Click += new System.EventHandler(this.TIMER_Click);
            this.TIMER.MouseHover += new System.EventHandler(this.TIMER_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CHOOSESECOND
            // 
            this.CHOOSESECOND.BackColor = System.Drawing.Color.GhostWhite;
            this.CHOOSESECOND.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CHOOSESECOND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CHOOSESECOND.FormattingEnabled = true;
            this.CHOOSESECOND.Location = new System.Drawing.Point(963, 395);
            this.CHOOSESECOND.Name = "CHOOSESECOND";
            this.CHOOSESECOND.Size = new System.Drawing.Size(51, 31);
            this.CHOOSESECOND.TabIndex = 8;
            this.CHOOSESECOND.Visible = false;
            this.CHOOSESECOND.SelectedIndexChanged += new System.EventHandler(this.CHOOSESECOND_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.CREDIT);
            this.panel1.Controls.Add(this.PROJEADI);
            this.panel1.Controls.Add(this.DOWNPAGE);
            this.panel1.Controls.Add(this.CLOSE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 28);
            this.panel1.TabIndex = 9;
            // 
            // CREDIT
            // 
            this.CREDIT.BackColor = System.Drawing.Color.Transparent;
            this.CREDIT.FlatAppearance.BorderSize = 0;
            this.CREDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CREDIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.CREDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CREDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CREDIT.ForeColor = System.Drawing.Color.GhostWhite;
            this.CREDIT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CREDIT.Location = new System.Drawing.Point(1096, 0);
            this.CREDIT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CREDIT.Name = "CREDIT";
            this.CREDIT.Size = new System.Drawing.Size(35, 28);
            this.CREDIT.TabIndex = 11;
            this.CREDIT.Text = "?";
            this.CREDIT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CREDIT.UseVisualStyleBackColor = false;
            this.CREDIT.Click += new System.EventHandler(this.CREDIT_Click);
            this.CREDIT.MouseHover += new System.EventHandler(this.CREDIT_MouseHover);
            // 
            // PROJEADI
            // 
            this.PROJEADI.AutoSize = true;
            this.PROJEADI.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PROJEADI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.PROJEADI.Location = new System.Drawing.Point(10, 4);
            this.PROJEADI.Name = "PROJEADI";
            this.PROJEADI.Size = new System.Drawing.Size(164, 24);
            this.PROJEADI.TabIndex = 10;
            this.PROJEADI.Text = "Cam-BAUN v1.0";
            this.PROJEADI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOWNPAGE
            // 
            this.DOWNPAGE.BackColor = System.Drawing.Color.Transparent;
            this.DOWNPAGE.FlatAppearance.BorderSize = 0;
            this.DOWNPAGE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DOWNPAGE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DOWNPAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DOWNPAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DOWNPAGE.ForeColor = System.Drawing.Color.GhostWhite;
            this.DOWNPAGE.Image = ((System.Drawing.Image)(resources.GetObject("DOWNPAGE.Image")));
            this.DOWNPAGE.Location = new System.Drawing.Point(1131, 0);
            this.DOWNPAGE.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.DOWNPAGE.Name = "DOWNPAGE";
            this.DOWNPAGE.Size = new System.Drawing.Size(35, 28);
            this.DOWNPAGE.TabIndex = 10;
            this.DOWNPAGE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DOWNPAGE.UseVisualStyleBackColor = false;
            this.DOWNPAGE.Click += new System.EventHandler(this.DOWNPAGE_Click);
            this.DOWNPAGE.MouseHover += new System.EventHandler(this.DOWNPAGE_MouseHover);
            // 
            // CLOSE
            // 
            this.CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.CLOSE.Dock = System.Windows.Forms.DockStyle.Right;
            this.CLOSE.FlatAppearance.BorderSize = 0;
            this.CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CLOSE.ForeColor = System.Drawing.Color.GhostWhite;
            this.CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("CLOSE.Image")));
            this.CLOSE.Location = new System.Drawing.Point(1166, 0);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(35, 28);
            this.CLOSE.TabIndex = 0;
            this.CLOSE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CLOSE.UseVisualStyleBackColor = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            this.CLOSE.MouseHover += new System.EventHandler(this.CLOSE_MouseHover);
            // 
            // SAYAC
            // 
            this.SAYAC.AutoSize = true;
            this.SAYAC.BackColor = System.Drawing.Color.Transparent;
            this.SAYAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAYAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SAYAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SAYAC.Location = new System.Drawing.Point(1006, 222);
            this.SAYAC.Name = "SAYAC";
            this.SAYAC.Size = new System.Drawing.Size(29, 29);
            this.SAYAC.TabIndex = 10;
            this.SAYAC.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1201, 511);
            this.Controls.Add(this.SAYAC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CHOOSESECOND);
            this.Controls.Add(this.TIMER);
            this.Controls.Add(this.CAMERAS);
            this.Controls.Add(this.CAM);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.CAPTURE);
            this.Controls.Add(this.START);
            this.Controls.Add(this.GORUNTU);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GORUNTU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CAMERAS;
        private System.Windows.Forms.Label CAM;
        private System.Windows.Forms.PictureBox GORUNTU;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button CAPTURE;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button TIMER;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox CHOOSESECOND;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.Button DOWNPAGE;
        private System.Windows.Forms.Button CREDIT;
        private System.Windows.Forms.Label PROJEADI;
        private System.Windows.Forms.Label SAYAC;
    }
}

