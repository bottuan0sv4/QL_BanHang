
namespace QL_BanHang
{
    partial class frmHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonNhap));
            this.gv_CTHDN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_HDNhap = new DevExpress.XtraGrid.GridControl();
            this.gv_HDNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bt_ThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.bt_ChinhSua = new DevExpress.XtraBars.BarButtonItem();
            this.bt_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.bt_InHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bt_ChiTiet = new DevExpress.XtraBars.BarButtonItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.gc_CTHDNhap = new DevExpress.XtraGrid.GridControl();
            this.gv_CTHDNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_HDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_CTHDN
            // 
            this.gv_CTHDN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn19,
            this.gridColumn21});
            this.gv_CTHDN.GridControl = this.gc_HDNhap;
            this.gv_CTHDN.Name = "gv_CTHDN";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã Kho";
            this.gridColumn6.FieldName = "makho";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 93;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên Kho";
            this.gridColumn7.FieldName = "tenkho";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 93;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mã Sản Phẩm";
            this.gridColumn8.FieldName = "masp";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 93;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên Sản Phẩm";
            this.gridColumn9.FieldName = "tensp";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 93;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Số Lượng";
            this.gridColumn14.FieldName = "soluong";
            this.gridColumn14.MinWidth = 25;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            this.gridColumn14.Width = 93;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Đơn Giá";
            this.gridColumn15.FieldName = "dongia";
            this.gridColumn15.MinWidth = 25;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 5;
            this.gridColumn15.Width = 93;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Chiết Khấu";
            this.gridColumn19.FieldName = "chietkhau";
            this.gridColumn19.MinWidth = 25;
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 6;
            this.gridColumn19.Width = 93;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Thành Tiền";
            this.gridColumn21.FieldName = "thanhtien";
            this.gridColumn21.MinWidth = 25;
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 7;
            this.gridColumn21.Width = 93;
            // 
            // gc_HDNhap
            // 
            this.gc_HDNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_HDNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_HDNhap.Location = new System.Drawing.Point(0, 0);
            this.gc_HDNhap.MainView = this.gv_HDNhap;
            this.gc_HDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gc_HDNhap.MenuManager = this.barManager1;
            this.gc_HDNhap.Name = "gc_HDNhap";
            this.gc_HDNhap.Size = new System.Drawing.Size(1105, 329);
            this.gc_HDNhap.TabIndex = 13;
            this.gc_HDNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_HDNhap,
            this.gv_CTHDN});
            // 
            // gv_HDNhap
            // 
            this.gv_HDNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn3});
            this.gv_HDNhap.DetailHeight = 431;
            this.gv_HDNhap.GridControl = this.gc_HDNhap;
            this.gv_HDNhap.Name = "gv_HDNhap";
            this.gv_HDNhap.OptionsBehavior.Editable = false;
            this.gv_HDNhap.OptionsView.ShowGroupPanel = false;
            this.gv_HDNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_HDNhap_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Hóa Đơn Nhập";
            this.gridColumn1.FieldName = "ID_HDNhap";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số Phiếu Nhập";
            this.gridColumn2.FieldName = "sophieunhap";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã Nhà Cung Cấp";
            this.gridColumn4.FieldName = "mancc";
            this.gridColumn4.MinWidth = 27;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên Nhà Cung Cấp";
            this.gridColumn5.FieldName = "tenncc";
            this.gridColumn5.MinWidth = 27;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Tạo";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "ngaytao";
            this.gridColumn3.MinWidth = 27;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 100;
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
            this.bt_Xoa,
            this.bt_ChiTiet,
            this.bt_InHoaDon});
            this.barManager1.MaxItemId = 5;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_InHoaDon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.bt_ChinhSua.Caption = "Chỉnh Sửa";
            this.bt_ChinhSua.Id = 1;
            this.bt_ChinhSua.ImageOptions.Image = global::QL_BanHang.Properties.Resources.editdatasource_16x16;
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
            // bt_InHoaDon
            // 
            this.bt_InHoaDon.Caption = "In hóa đơn";
            this.bt_InHoaDon.Id = 4;
            this.bt_InHoaDon.ImageOptions.Image = global::QL_BanHang.Properties.Resources.printernetwork_16x16;
            this.bt_InHoaDon.ImageOptions.LargeImage = global::QL_BanHang.Properties.Resources.printernetwork_32x32;
            this.bt_InHoaDon.Name = "bt_InHoaDon";
            this.bt_InHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_InHoaDon_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1105, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 683);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1105, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 653);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1105, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 653);
            // 
            // bt_ChiTiet
            // 
            this.bt_ChiTiet.Caption = "Chi Tiết";
            this.bt_ChiTiet.Id = 3;
            this.bt_ChiTiet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bt_ChiTiet.ImageOptions.SvgImage")));
            this.bt_ChiTiet.Name = "bt_ChiTiet";
            this.bt_ChiTiet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ChiTiet_ItemClick);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.gc_HDNhap);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 30);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1105, 330);
            this.sidePanel1.TabIndex = 12;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.gc_CTHDNhap);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 360);
            this.sidePanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1105, 323);
            this.sidePanel2.TabIndex = 18;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // gc_CTHDNhap
            // 
            this.gc_CTHDNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CTHDNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_CTHDNhap.Location = new System.Drawing.Point(0, 0);
            this.gc_CTHDNhap.MainView = this.gv_CTHDNhap;
            this.gc_CTHDNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_CTHDNhap.MenuManager = this.barManager1;
            this.gc_CTHDNhap.Name = "gc_CTHDNhap";
            this.gc_CTHDNhap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gc_CTHDNhap.Size = new System.Drawing.Size(1105, 323);
            this.gc_CTHDNhap.TabIndex = 1;
            this.gc_CTHDNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CTHDNhap});
            // 
            // gv_CTHDNhap
            // 
            this.gv_CTHDNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn20});
            this.gv_CTHDNhap.GridControl = this.gc_CTHDNhap;
            this.gv_CTHDNhap.Name = "gv_CTHDNhap";
            this.gv_CTHDNhap.OptionsBehavior.Editable = false;
            this.gv_CTHDNhap.OptionsView.ShowAutoFilterRow = true;
            this.gv_CTHDNhap.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã Sản Phẩm";
            this.gridColumn10.FieldName = "masp";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 93;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Tên Sản Phẩm";
            this.gridColumn11.FieldName = "tensp";
            this.gridColumn11.MinWidth = 25;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            this.gridColumn11.Width = 93;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Mã Kho";
            this.gridColumn12.FieldName = "makho";
            this.gridColumn12.MinWidth = 25;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 93;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Tên Kho";
            this.gridColumn13.FieldName = "tenkho";
            this.gridColumn13.MinWidth = 25;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 93;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Số Lượng";
            this.gridColumn16.FieldName = "soluong";
            this.gridColumn16.MinWidth = 25;
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 93;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Đơn Giá";
            this.gridColumn17.DisplayFormat.FormatString = "#,#";
            this.gridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn17.FieldName = "dongia";
            this.gridColumn17.MinWidth = 25;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            this.gridColumn17.Width = 93;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Chiết Khấu";
            this.gridColumn18.FieldName = "chietkhau";
            this.gridColumn18.MinWidth = 25;
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 6;
            this.gridColumn18.Width = 93;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Thành Tiền";
            this.gridColumn20.DisplayFormat.FormatString = "#,#";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn20.FieldName = "thanhtien";
            this.gridColumn20.MinWidth = 25;
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 7;
            this.gridColumn20.Width = 93;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.btsua_click);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 683);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_HDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bt_ChiTiet;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraGrid.GridControl gc_CTHDNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTHDNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.GridControl gc_HDNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_HDNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTHDN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarButtonItem bt_InHoaDon;
    }
}