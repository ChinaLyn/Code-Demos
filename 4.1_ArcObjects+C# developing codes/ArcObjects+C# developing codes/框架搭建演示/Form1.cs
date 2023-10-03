using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Carto;

namespace 框架搭建演示
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //实现空间之间的关联
            axTOCControl1.SetBuddyControl(MainMapControl.Object);
            axToolbarControl1.SetBuddyControl(MainMapControl.Object);
        }

        private void openMxDocCOmmand加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 拉框放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region 调用类资源库 ControlsMapZoomInTool
            MainMapControl.CurrentTool = null;
            ControlsMapZoomInTool pTool = new ControlsMapZoomInTool();
            pTool.OnCreate(MainMapControl.Object);
            MainMapControl.CurrentTool = pTool as ITool;



            #endregion
        }

        private void 拉框缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region 调用资源库
            MainMapControl.CurrentTool = null;
            ControlsMapZoomOutTool PTool = new ControlsMapZoomOutTool();
            PTool.OnCreate(MainMapControl.Object);
            MainMapControl.CurrentTool = PTool as ITool;
            #endregion
        }

        private void MainMapControl_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            ////产生拖曳多边形，并绘制
            //IGeometry PGeom = MainMapControl.TrackPolygon();
            ////设置颜色为浅褐色
            //IRgbColor pColor = new RgbColor();
            //pColor.Red = 220;
            //pColor.Green = 112;
            //pColor.Blue = 60;

            //ISimpleFillSymbol pFillsyl = new SimpleFillSymbol();
            //pFillsyl.Color = pColor;
            //Object oFillsyl = pFillsyl;

            //MainMapControl.DrawShape(PGeom, ref oFillsyl); 
            //MainMapControl.Refresh(ESRI.ArcGIS.Carto.esriViewDrawPhase.esriViewGeography, null, null);
        }

        private void 要素选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMapControl.CurrentTool = null;
            ControlsSelectFeaturesTool pTool = new ControlsSelectFeaturesTool();
            pTool.OnCreate(MainMapControl.Object);
            MainMapControl.CurrentTool = pTool as ITool;
        }

        private void 缩放至选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nSelection = MainMapControl.Map.SelectionCount;
            if (nSelection == 0)
            {
                MessageBox.Show("请先选择要素！", "提示");

            }
            else
            {
                ISelection selection = MainMapControl.Map.FeatureSelection;
                IEnumElement enumFeature = (IEnumElement)selection;
                enumFeature.Reset();
                Envelope pEnvelope = new Envelope();


            }
        }

        private void MainMapControl_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            //在加Map Control加载文档的同时，让PageLayoutControl加载对应文档
            axPageLayoutControl1.LoadMxFile(MainMapControl.DocumentFilename);
            axPageLayoutControl1.Extent = EagleEyeMapControl.FullExtent;

        }

        private void 加载shapeFile文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShapefileUsingOpenFileDialog(MainMapControl.ActiveView);
        }


    }
}
