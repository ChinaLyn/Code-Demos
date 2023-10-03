
namespace 框架搭建演示
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.地图导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.区域导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全域导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载MXDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMxFile加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMapDocument加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMxDocCOmmand加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地图浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拉框放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拉框缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.逐级放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.逐级缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.漫游ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地图旋转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.要素选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所防止选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放至选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.EagleEyeMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.加载shapeFile文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EagleEyeMapControl)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainMapControl)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.数据加载ToolStripMenuItem,
            this.地图浏览ToolStripMenuItem,
            this.要素选择ToolStripMenuItem,
            this.所防止选择ToolStripMenuItem,
            this.缩放至选择ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开地图ToolStripMenuItem,
            this.新建地图ToolStripMenuItem,
            this.保存地图ToolStripMenuItem,
            this.另存地图ToolStripMenuItem,
            this.toolStripSeparator1,
            this.地图导出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开地图ToolStripMenuItem
            // 
            this.打开地图ToolStripMenuItem.Name = "打开地图ToolStripMenuItem";
            this.打开地图ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.打开地图ToolStripMenuItem.Text = "打开地图";
            // 
            // 新建地图ToolStripMenuItem
            // 
            this.新建地图ToolStripMenuItem.Name = "新建地图ToolStripMenuItem";
            this.新建地图ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.新建地图ToolStripMenuItem.Text = "新建地图";
            // 
            // 保存地图ToolStripMenuItem
            // 
            this.保存地图ToolStripMenuItem.Name = "保存地图ToolStripMenuItem";
            this.保存地图ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.保存地图ToolStripMenuItem.Text = "保存地图";
            // 
            // 另存地图ToolStripMenuItem
            // 
            this.另存地图ToolStripMenuItem.Name = "另存地图ToolStripMenuItem";
            this.另存地图ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.另存地图ToolStripMenuItem.Text = "另存地图";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 地图导出ToolStripMenuItem
            // 
            this.地图导出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.区域导出ToolStripMenuItem,
            this.全域导出ToolStripMenuItem});
            this.地图导出ToolStripMenuItem.Name = "地图导出ToolStripMenuItem";
            this.地图导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.地图导出ToolStripMenuItem.Text = "地图导出";
            // 
            // 区域导出ToolStripMenuItem
            // 
            this.区域导出ToolStripMenuItem.Name = "区域导出ToolStripMenuItem";
            this.区域导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.区域导出ToolStripMenuItem.Text = "区域导出";
            // 
            // 全域导出ToolStripMenuItem
            // 
            this.全域导出ToolStripMenuItem.Name = "全域导出ToolStripMenuItem";
            this.全域导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.全域导出ToolStripMenuItem.Text = "全域导出";
            // 
            // 数据加载ToolStripMenuItem
            // 
            this.数据加载ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载MXDToolStripMenuItem,
            this.加载shapeFile文件ToolStripMenuItem});
            this.数据加载ToolStripMenuItem.Name = "数据加载ToolStripMenuItem";
            this.数据加载ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.数据加载ToolStripMenuItem.Text = "数据加载";
            // 
            // 加载MXDToolStripMenuItem
            // 
            this.加载MXDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMxFile加载ToolStripMenuItem,
            this.iMapDocument加载ToolStripMenuItem,
            this.openMxDocCOmmand加载ToolStripMenuItem});
            this.加载MXDToolStripMenuItem.Name = "加载MXDToolStripMenuItem";
            this.加载MXDToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.加载MXDToolStripMenuItem.Text = "加载MXD";
            // 
            // loadMxFile加载ToolStripMenuItem
            // 
            this.loadMxFile加载ToolStripMenuItem.Name = "loadMxFile加载ToolStripMenuItem";
            this.loadMxFile加载ToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.loadMxFile加载ToolStripMenuItem.Text = "LoadMxFile加载";
            // 
            // iMapDocument加载ToolStripMenuItem
            // 
            this.iMapDocument加载ToolStripMenuItem.Name = "iMapDocument加载ToolStripMenuItem";
            this.iMapDocument加载ToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.iMapDocument加载ToolStripMenuItem.Text = "IMapDocument加载";
            // 
            // openMxDocCOmmand加载ToolStripMenuItem
            // 
            this.openMxDocCOmmand加载ToolStripMenuItem.Name = "openMxDocCOmmand加载ToolStripMenuItem";
            this.openMxDocCOmmand加载ToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.openMxDocCOmmand加载ToolStripMenuItem.Text = "OpenMxDocCommand加载";
            this.openMxDocCOmmand加载ToolStripMenuItem.Click += new System.EventHandler(this.openMxDocCOmmand加载ToolStripMenuItem_Click);
            // 
            // 地图浏览ToolStripMenuItem
            // 
            this.地图浏览ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拉框放大ToolStripMenuItem,
            this.拉框缩小ToolStripMenuItem,
            this.逐级放大ToolStripMenuItem,
            this.逐级缩小ToolStripMenuItem,
            this.漫游ToolStripMenuItem,
            this.全图ToolStripMenuItem,
            this.地图旋转ToolStripMenuItem});
            this.地图浏览ToolStripMenuItem.Name = "地图浏览ToolStripMenuItem";
            this.地图浏览ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.地图浏览ToolStripMenuItem.Text = "地图浏览";
            // 
            // 拉框放大ToolStripMenuItem
            // 
            this.拉框放大ToolStripMenuItem.Name = "拉框放大ToolStripMenuItem";
            this.拉框放大ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.拉框放大ToolStripMenuItem.Text = "拉框放大";
            this.拉框放大ToolStripMenuItem.Click += new System.EventHandler(this.拉框放大ToolStripMenuItem_Click);
            // 
            // 拉框缩小ToolStripMenuItem
            // 
            this.拉框缩小ToolStripMenuItem.Name = "拉框缩小ToolStripMenuItem";
            this.拉框缩小ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.拉框缩小ToolStripMenuItem.Text = "拉框缩小";
            this.拉框缩小ToolStripMenuItem.Click += new System.EventHandler(this.拉框缩小ToolStripMenuItem_Click);
            // 
            // 逐级放大ToolStripMenuItem
            // 
            this.逐级放大ToolStripMenuItem.Name = "逐级放大ToolStripMenuItem";
            this.逐级放大ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.逐级放大ToolStripMenuItem.Text = "逐级放大";
            // 
            // 逐级缩小ToolStripMenuItem
            // 
            this.逐级缩小ToolStripMenuItem.Name = "逐级缩小ToolStripMenuItem";
            this.逐级缩小ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.逐级缩小ToolStripMenuItem.Text = "逐级缩小";
            // 
            // 漫游ToolStripMenuItem
            // 
            this.漫游ToolStripMenuItem.Name = "漫游ToolStripMenuItem";
            this.漫游ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.漫游ToolStripMenuItem.Text = "漫游";
            // 
            // 全图ToolStripMenuItem
            // 
            this.全图ToolStripMenuItem.Name = "全图ToolStripMenuItem";
            this.全图ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.全图ToolStripMenuItem.Text = "全图";
            // 
            // 地图旋转ToolStripMenuItem
            // 
            this.地图旋转ToolStripMenuItem.Name = "地图旋转ToolStripMenuItem";
            this.地图旋转ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            // 
            // 要素选择ToolStripMenuItem
            // 
            this.要素选择ToolStripMenuItem.Name = "要素选择ToolStripMenuItem";
            this.要素选择ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.要素选择ToolStripMenuItem.Text = "要素选择";
            this.要素选择ToolStripMenuItem.Click += new System.EventHandler(this.要素选择ToolStripMenuItem_Click);
            // 
            // 所防止选择ToolStripMenuItem
            // 
            this.所防止选择ToolStripMenuItem.Name = "所防止选择ToolStripMenuItem";
            this.所防止选择ToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // 缩放至选择ToolStripMenuItem
            // 
            this.缩放至选择ToolStripMenuItem.Name = "缩放至选择ToolStripMenuItem";
            this.缩放至选择ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.缩放至选择ToolStripMenuItem.Text = "缩放至选择";
            this.缩放至选择ToolStripMenuItem.Click += new System.EventHandler(this.缩放至选择ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 20);
            this.toolStripStatusLabel1.Text = "地图坐标为：";
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 28);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(800, 28);
            this.axToolbarControl1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 368);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.axTOCControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.EagleEyeMapControl);
            this.splitContainer2.Size = new System.Drawing.Size(266, 368);
            this.splitContainer2.SplitterDistance = 167;
            this.splitContainer2.TabIndex = 0;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(266, 167);
            this.axTOCControl1.TabIndex = 0;
            // 
            // EagleEyeMapControl
            // 
            this.EagleEyeMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EagleEyeMapControl.Location = new System.Drawing.Point(0, 0);
            this.EagleEyeMapControl.Name = "EagleEyeMapControl";
            this.EagleEyeMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("EagleEyeMapControl.OcxState")));
            this.EagleEyeMapControl.Size = new System.Drawing.Size(266, 197);
            this.EagleEyeMapControl.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MainMapControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据视图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainMapControl
            // 
            this.MainMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMapControl.Location = new System.Drawing.Point(3, 3);
            this.MainMapControl.Name = "MainMapControl";
            this.MainMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainMapControl.OcxState")));
            this.MainMapControl.Size = new System.Drawing.Size(516, 333);
            this.MainMapControl.TabIndex = 0;
            this.MainMapControl.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.MainMapControl_OnMouseDown);
            this.MainMapControl.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.MainMapControl_OnMapReplaced);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axPageLayoutControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "布局视图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPageLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(516, 333);
            this.axPageLayoutControl1.TabIndex = 0;
            // 
            // 加载shapeFile文件ToolStripMenuItem
            // 
            this.加载shapeFile文件ToolStripMenuItem.Name = "加载shapeFile文件ToolStripMenuItem";
            this.加载shapeFile文件ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.加载shapeFile文件ToolStripMenuItem.Text = "加载shape file文件";
            this.加载shapeFile文件ToolStripMenuItem.Click += new System.EventHandler(this.加载shapeFile文件ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EagleEyeMapControl)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainMapControl)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private ESRI.ArcGIS.Controls.AxMapControl EagleEyeMapControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ESRI.ArcGIS.Controls.AxMapControl MainMapControl;
        private System.Windows.Forms.TabPage tabPage2;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private System.Windows.Forms.ToolStripMenuItem 打开地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 地图导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 区域导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全域导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载MXDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMxFile加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMapDocument加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMxDocCOmmand加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地图浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拉框放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拉框缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 逐级放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 逐级缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 漫游ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地图旋转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 要素选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所防止选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩放至选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载shapeFile文件ToolStripMenuItem;
    }
}

