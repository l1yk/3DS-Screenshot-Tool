namespace prj3DS_ScreenShot_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉程式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBGColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBG_BlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBG_WhiteWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.自訂CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picTopScreen = new System.Windows.Forms.PictureBox();
            this.picBottomScreen = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnOpenTop = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOpenBottom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.另存上螢幕截圖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.另存下螢幕截圖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出整張截圖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預覽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomScreen)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(400, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.另存上螢幕截圖ToolStripMenuItem,
            this.另存下螢幕截圖ToolStripMenuItem,
            this.匯出整張截圖ToolStripMenuItem,
            this.toolStripSeparator5,
            this.預覽ToolStripMenuItem,
            this.toolStripSeparator4,
            this.關閉程式ToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(102, 38);
            this.檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 關閉程式ToolStripMenuItem
            // 
            this.關閉程式ToolStripMenuItem.Name = "關閉程式ToolStripMenuItem";
            this.關閉程式ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.關閉程式ToolStripMenuItem.Size = new System.Drawing.Size(370, 38);
            this.關閉程式ToolStripMenuItem.Text = "關閉程式(&X)";
            this.關閉程式ToolStripMenuItem.Click += new System.EventHandler(this.關閉程式ToolStripMenuItem_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeBGColorToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(102, 38);
            this.編輯EToolStripMenuItem.Text = "編輯(&E)";
            // 
            // ChangeBGColorToolStripMenuItem
            // 
            this.ChangeBGColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeBG_BlackToolStripMenuItem,
            this.ChangeBG_WhiteWToolStripMenuItem,
            this.toolStripSeparator3,
            this.自訂CToolStripMenuItem});
            this.ChangeBGColorToolStripMenuItem.Name = "ChangeBGColorToolStripMenuItem";
            this.ChangeBGColorToolStripMenuItem.Size = new System.Drawing.Size(406, 38);
            this.ChangeBGColorToolStripMenuItem.Text = "變更空白部分的背景顏色(&B)";
            // 
            // ChangeBG_BlackToolStripMenuItem
            // 
            this.ChangeBG_BlackToolStripMenuItem.Name = "ChangeBG_BlackToolStripMenuItem";
            this.ChangeBG_BlackToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.ChangeBG_BlackToolStripMenuItem.Text = "黑色(&B)";
            this.ChangeBG_BlackToolStripMenuItem.Click += new System.EventHandler(this.ChangeBG_BlackToolStripMenuItem_Click);
            // 
            // ChangeBG_WhiteWToolStripMenuItem
            // 
            this.ChangeBG_WhiteWToolStripMenuItem.Name = "ChangeBG_WhiteWToolStripMenuItem";
            this.ChangeBG_WhiteWToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.ChangeBG_WhiteWToolStripMenuItem.Text = "白色(&W)";
            this.ChangeBG_WhiteWToolStripMenuItem.Click += new System.EventHandler(this.ChangeBG_WhiteWToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // 自訂CToolStripMenuItem
            // 
            this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            this.自訂CToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.自訂CToolStripMenuItem.Text = "自訂(&C)";
            this.自訂CToolStripMenuItem.Click += new System.EventHandler(this.自訂CToolStripMenuItem_Click);
            // 
            // picTopScreen
            // 
            this.picTopScreen.BackColor = System.Drawing.Color.Black;
            this.picTopScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTopScreen.Location = new System.Drawing.Point(0, 0);
            this.picTopScreen.Margin = new System.Windows.Forms.Padding(0);
            this.picTopScreen.Name = "picTopScreen";
            this.picTopScreen.Size = new System.Drawing.Size(400, 226);
            this.picTopScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopScreen.TabIndex = 1;
            this.picTopScreen.TabStop = false;
            // 
            // picBottomScreen
            // 
            this.picBottomScreen.BackColor = System.Drawing.Color.Black;
            this.picBottomScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBottomScreen.Location = new System.Drawing.Point(40, 0);
            this.picBottomScreen.Margin = new System.Windows.Forms.Padding(0);
            this.picBottomScreen.Name = "picBottomScreen";
            this.picBottomScreen.Size = new System.Drawing.Size(320, 226);
            this.picBottomScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBottomScreen.TabIndex = 2;
            this.picBottomScreen.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsBtnOpenTop,
            this.tsBtnOpenBottom,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(400, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "儲存完整螢幕截圖";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsBtnOpenTop
            // 
            this.tsBtnOpenTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnOpenTop.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOpenTop.Image")));
            this.tsBtnOpenTop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenTop.Name = "tsBtnOpenTop";
            this.tsBtnOpenTop.Size = new System.Drawing.Size(185, 36);
            this.tsBtnOpenTop.Text = "開啟上螢幕截圖";
            this.tsBtnOpenTop.Click += new System.EventHandler(this.tsBtnOpenTop_Click);
            // 
            // tsBtnOpenBottom
            // 
            this.tsBtnOpenBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnOpenBottom.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOpenBottom.Image")));
            this.tsBtnOpenBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenBottom.Name = "tsBtnOpenBottom";
            this.tsBtnOpenBottom.Size = new System.Drawing.Size(185, 34);
            this.tsBtnOpenBottom.Text = "開啟下螢幕截圖";
            this.tsBtnOpenBottom.Click += new System.EventHandler(this.tsBtnOpenBottom_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picTopScreen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 452);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.picBottomScreen, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 226);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 226);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // 另存上螢幕截圖ToolStripMenuItem
            // 
            this.另存上螢幕截圖ToolStripMenuItem.Name = "另存上螢幕截圖ToolStripMenuItem";
            this.另存上螢幕截圖ToolStripMenuItem.Size = new System.Drawing.Size(370, 38);
            this.另存上螢幕截圖ToolStripMenuItem.Text = "另存上螢幕截圖(&T)";
            this.另存上螢幕截圖ToolStripMenuItem.Click += new System.EventHandler(this.另存上螢幕截圖ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(367, 6);
            // 
            // 另存下螢幕截圖ToolStripMenuItem
            // 
            this.另存下螢幕截圖ToolStripMenuItem.Name = "另存下螢幕截圖ToolStripMenuItem";
            this.另存下螢幕截圖ToolStripMenuItem.Size = new System.Drawing.Size(370, 38);
            this.另存下螢幕截圖ToolStripMenuItem.Text = "另存下螢幕截圖(&B)";
            this.另存下螢幕截圖ToolStripMenuItem.Click += new System.EventHandler(this.另存下螢幕截圖ToolStripMenuItem_Click);
            // 
            // 匯出整張截圖ToolStripMenuItem
            // 
            this.匯出整張截圖ToolStripMenuItem.Name = "匯出整張截圖ToolStripMenuItem";
            this.匯出整張截圖ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.匯出整張截圖ToolStripMenuItem.Size = new System.Drawing.Size(370, 38);
            this.匯出整張截圖ToolStripMenuItem.Text = "匯出整張截圖(&S)";
            this.匯出整張截圖ToolStripMenuItem.Click += new System.EventHandler(this.匯出整張截圖ToolStripMenuItem_Click);
            // 
            // 預覽ToolStripMenuItem
            // 
            this.預覽ToolStripMenuItem.Name = "預覽ToolStripMenuItem";
            this.預覽ToolStripMenuItem.Size = new System.Drawing.Size(370, 38);
            this.預覽ToolStripMenuItem.Text = "預覽(&P)";
            this.預覽ToolStripMenuItem.Click += new System.EventHandler(this.預覽ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(367, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 568);
            this.Name = "Form1";
            this.Text = "3DS截圖處理工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomScreen)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox picTopScreen;
        private System.Windows.Forms.PictureBox picBottomScreen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnOpenTop;
        private System.Windows.Forms.ToolStripButton tsBtnOpenBottom;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉程式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeBGColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeBG_BlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeBG_WhiteWToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存上螢幕截圖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存下螢幕截圖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匯出整張截圖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 預覽ToolStripMenuItem;
    }
}

