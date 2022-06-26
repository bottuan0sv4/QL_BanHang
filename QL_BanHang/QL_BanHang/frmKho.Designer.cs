
namespace QL_BanHang
{
    partial class frmKho
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bt_ThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gc_Kho = new DevExpress.XtraGrid.GridControl();
            this.gv_Kho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_IDKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kho)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bt_ThemMoi,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_ThemMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.Text = "Tools";
            // 
            // bt_ThemMoi
            // 
            this.bt_ThemMoi.Caption = "Thêm mới";
            this.bt_ThemMoi.Id = 0;
            this.bt_ThemMoi.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.adddatasource;
            this.bt_ThemMoi.Name = "bt_ThemMoi";
            this.bt_ThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ThemMoi_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Chỉnh sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = global::QL_BanHang.Properties.Resources.editdatasource_16x16;
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ChinhSua_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.deletedatasource;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_Xoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // gc_Kho
            // 
            this.gc_Kho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Kho.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Kho.Location = new System.Drawing.Point(0, 30);
            this.gc_Kho.MainView = this.gv_Kho;
            this.gc_Kho.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Kho.MenuManager = this.barManager1;
            this.gc_Kho.Name = "gc_Kho";
            this.gc_Kho.Size = new System.Drawing.Size(1067, 524);
            this.gc_Kho.TabIndex = 4;
            this.gc_Kho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Kho});
            // 
            // gv_Kho
            // 
            this.gv_Kho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_IDKho,
            this.gridColumn2,
            this.gridColumn1});
            this.gv_Kho.DetailHeight = 431;
            this.gv_Kho.GridControl = this.gc_Kho;
            this.gv_Kho.Name = "gv_Kho";
            this.gv_Kho.OptionsBehavior.Editable = false;
            this.gv_Kho.OptionsView.ShowAutoFilterRow = true;
            this.gv_Kho.OptionsView.ShowDetailButtons = false;
            this.gv_Kho.OptionsView.ShowGroupPanel = false;
            // 
            // gc_IDKho
            // 
            this.gc_IDKho.Caption = "ID Kho";
            this.gc_IDKho.FieldName = "ID_Kho";
            this.gc_IDKho.MinWidth = 27;
            this.gc_IDKho.Name = "gc_IDKho";
            this.gc_IDKho.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TenKho";
            this.gridColumn2.FieldName = "tenkho";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Kho *";
            this.gridColumn1.FieldName = "makho";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gc_Kho);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKho_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bt_ThemMoi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gc_Kho;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IDKho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}