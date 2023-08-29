namespace miniPaint
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboTick = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripbtnLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnGreen = new System.Windows.Forms.ToolStripButton();
            this.menuBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도형ToolStripMenuItem,
            this.색상ToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.toolStripSeparator6,
            this.ToolStripExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 도형ToolStripMenuItem
            // 
            this.도형ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLine,
            this.ToolStripRect,
            this.ToolStripCircle});
            this.도형ToolStripMenuItem.Name = "도형ToolStripMenuItem";
            this.도형ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도형ToolStripMenuItem.Text = "도형";
            // 
            // 색상ToolStripMenuItem
            // 
            this.색상ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripColor});
            this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
            this.색상ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.색상ToolStripMenuItem.Text = "색상";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtnLine,
            this.toolStripSeparator1,
            this.toolStripbtnRect,
            this.toolStripSeparator2,
            this.toolStripbtnCircle,
            this.toolStripSeparator3,
            this.toolStripbtnBlack,
            this.toolStripSeparator4,
            this.toolStripbtnRed,
            this.toolStripSeparator5,
            this.toolStripbtnBlue,
            this.toolStripSeparator7,
            this.toolStripbtnGreen,
            this.toolStripSeparator8,
            this.toolStripComboTick});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.Size = new System.Drawing.Size(180, 22);
            this.ToolStripNew.Text = "새로만들기";
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripExit.Text = "종료";
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // ToolStripLine
            // 
            this.ToolStripLine.Name = "ToolStripLine";
            this.ToolStripLine.Size = new System.Drawing.Size(180, 22);
            this.ToolStripLine.Text = "직선";
            this.ToolStripLine.Click += new System.EventHandler(this.ToolStripLine_Click);
            // 
            // ToolStripRect
            // 
            this.ToolStripRect.Name = "ToolStripRect";
            this.ToolStripRect.Size = new System.Drawing.Size(180, 22);
            this.ToolStripRect.Text = "사각형";
            this.ToolStripRect.Click += new System.EventHandler(this.ToolStripRect_Click);
            // 
            // ToolStripCircle
            // 
            this.ToolStripCircle.Name = "ToolStripCircle";
            this.ToolStripCircle.Size = new System.Drawing.Size(180, 22);
            this.ToolStripCircle.Text = "원";
            this.ToolStripCircle.Click += new System.EventHandler(this.ToolStripCircle_Click);
            // 
            // ToolStripColor
            // 
            this.ToolStripColor.Name = "ToolStripColor";
            this.ToolStripColor.Size = new System.Drawing.Size(180, 22);
            this.ToolStripColor.Text = "컬러 선택";
            this.ToolStripColor.Click += new System.EventHandler(this.ToolStripColor_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboTick
            // 
            this.toolStripComboTick.Items.AddRange(new object[] {
            "1",
            "4",
            "8",
            "12",
            "16"});
            this.toolStripComboTick.Name = "toolStripComboTick";
            this.toolStripComboTick.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboTick.Text = "1";
            this.toolStripComboTick.SelectedIndexChanged += new System.EventHandler(this.toolStripComboTick_SelectedIndexChanged);
            // 
            // toolStripbtnLine
            // 
            this.toolStripbtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnLine.Image = global::miniPaint.Properties.Resources.line;
            this.toolStripbtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnLine.Name = "toolStripbtnLine";
            this.toolStripbtnLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnLine.Text = "toolStripButton1";
            this.toolStripbtnLine.ToolTipText = "직선";
            this.toolStripbtnLine.Click += new System.EventHandler(this.toolStripbtnLine_Click);
            // 
            // toolStripbtnRect
            // 
            this.toolStripbtnRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnRect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnRect.Image")));
            this.toolStripbtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnRect.Name = "toolStripbtnRect";
            this.toolStripbtnRect.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnRect.Text = "toolStripButton2";
            this.toolStripbtnRect.ToolTipText = "사각형";
            this.toolStripbtnRect.Click += new System.EventHandler(this.toolStripbtnRect_Click);
            // 
            // toolStripbtnCircle
            // 
            this.toolStripbtnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnCircle.Image")));
            this.toolStripbtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnCircle.Name = "toolStripbtnCircle";
            this.toolStripbtnCircle.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnCircle.Text = "toolStripButton3";
            this.toolStripbtnCircle.ToolTipText = "원";
            this.toolStripbtnCircle.Click += new System.EventHandler(this.toolStripbtnCircle_Click);
            // 
            // toolStripbtnBlack
            // 
            this.toolStripbtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnBlack.Image = global::miniPaint.Properties.Resources.black;
            this.toolStripbtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnBlack.Name = "toolStripbtnBlack";
            this.toolStripbtnBlack.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnBlack.Text = "toolStripButton4";
            this.toolStripbtnBlack.ToolTipText = "검정";
            this.toolStripbtnBlack.Click += new System.EventHandler(this.toolStripbtnBlack_Click);
            // 
            // toolStripbtnRed
            // 
            this.toolStripbtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnRed.Image = global::miniPaint.Properties.Resources.Red;
            this.toolStripbtnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnRed.Name = "toolStripbtnRed";
            this.toolStripbtnRed.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnRed.Text = "toolStripButton5";
            this.toolStripbtnRed.ToolTipText = "빨강";
            this.toolStripbtnRed.Click += new System.EventHandler(this.toolStripbtnRed_Click);
            // 
            // toolStripbtnBlue
            // 
            this.toolStripbtnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnBlue.Image = global::miniPaint.Properties.Resources.Image1;
            this.toolStripbtnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnBlue.Name = "toolStripbtnBlue";
            this.toolStripbtnBlue.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnBlue.Text = "toolStripButton6";
            this.toolStripbtnBlue.ToolTipText = "파랑";
            this.toolStripbtnBlue.Click += new System.EventHandler(this.toolStripbtnBlue_Click);
            // 
            // toolStripbtnGreen
            // 
            this.toolStripbtnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripbtnGreen.Image = global::miniPaint.Properties.Resources.green;
            this.toolStripbtnGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnGreen.Name = "toolStripbtnGreen";
            this.toolStripbtnGreen.Size = new System.Drawing.Size(23, 22);
            this.toolStripbtnGreen.Text = "toolStripButton1";
            this.toolStripbtnGreen.ToolTipText = "초록";
            this.toolStripbtnGreen.Click += new System.EventHandler(this.toolStripbtnGreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "미니 그림판";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripbtnLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripbtnRect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripbtnCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripbtnBlack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripbtnRed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripbtnBlue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripLine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCircle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripbtnGreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripComboBox toolStripComboTick;
    }
}

