
namespace QL_BanHang
{
    partial class frmSanPham
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bt_ThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.bt_ChinhSua = new DevExpress.XtraBars.BarButtonItem();
            this.bt_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gc_SanPham = new DevExpress.XtraGrid.GridControl();
            this.gv_SanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bt_ThemMoi,
            this.bt_ChinhSua,
            this.bt_Xoa});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_ThemMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_ChinhSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // bt_ThemMoi
            // 
            this.bt_ThemMoi.Caption = "Thêm mới";
            this.bt_ThemMoi.Id = 0;
            this.bt_ThemMoi.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.adddatasource;
            this.bt_ThemMoi.Name = "bt_ThemMoi";
            this.bt_ThemMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ThemMoi_ItemClick);
            // 
            // bt_ChinhSua
            // 
            this.bt_ChinhSua.Caption = "Chỉnh sửa";
            this.bt_ChinhSua.Id = 1;
            this.bt_ChinhSua.ImageOptions.Image = global::QL_BanHang.Properties.Resources.editdatasource_16x16;
            this.bt_ChinhSua.ImageOptions.LargeImage = global::QL_BanHang.Properties.Resources.editdatasource_32x32;
            this.bt_ChinhSua.Name = "bt_ChinhSua";
            this.bt_ChinhSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ChinhSua_ItemClick);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Caption = "Xóa";
            this.bt_Xoa.Id = 2;
            this.bt_Xoa.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.deletedatasource;
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_Xoa_ItemClick);
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
            // gc_SanPham
            // 
            this.gc_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_SanPham.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_SanPham.Location = new System.Drawing.Point(0, 30);
            this.gc_SanPham.MainView = this.gv_SanPham;
            this.gc_SanPham.Margin = new System.Windows.Forms.Padding(4);
            this.gc_SanPham.MenuManager = this.barManager1;
            this.gc_SanPham.Name = "gc_SanPham";
            this.gc_SanPham.Size = new System.Drawing.Size(1067, 524);
            this.gc_SanPham.TabIndex = 4;
            this.gc_SanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_SanPham});
            // 
            // gv_SanPham
            // 
            this.gv_SanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn7,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_SanPham.DetailHeight = 431;
            this.gv_SanPham.GridControl = this.gc_SanPham;
            this.gv_SanPham.Name = "gv_SanPham";
            this.gv_SanPham.OptionsBehavior.Editable = false;
            this.gv_SanPham.OptionsView.ShowAutoFilterRow = true;
            this.gv_SanPham.OptionsView.ShowDetailButtons = false;
            this.gv_SanPham.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Sản Phẩm";
            this.gridColumn1.FieldName = "ID_SP";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã Sản Phẩm *";
            this.gridColumn7.FieldName = "masp";
            this.gridColumn7.MinWidth = 27;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Sản Phẩm";
            this.gridColumn2.FieldName = "tensp";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn Vị";
            this.gridColumn3.FieldName = "donvi";
            this.gridColumn3.MinWidth = 27;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn Giá";
            this.gridColumn4.DisplayFormat.FormatString = "#,#";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "dongia";
            this.gridColumn4.MinWidth = 27;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày Tạo";
            this.gridColumn5.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "ngaytao";
            this.gridColumn5.MinWidth = 27;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 100;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gc_SanPham);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSanPham_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bt_ThemMoi;
        private DevExpress.XtraBars.BarButtonItem bt_ChinhSua;
        private DevExpress.XtraBars.BarButtonItem bt_Xoa;
        private DevExpress.XtraGrid.GridControl gc_SanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_SanPham;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}