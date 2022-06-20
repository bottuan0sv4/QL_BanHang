
namespace QL_BanHang
{
    partial class frmHoaDonXuat
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
            this.bt_themmoi = new DevExpress.XtraBars.BarButtonItem();
            this.bt_chinhsua = new DevExpress.XtraBars.BarButtonItem();
            this.bt_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.bt_InHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.gc_HDXuat = new DevExpress.XtraGrid.GridControl();
            this.gv_HDXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.gc_CTHDXuat = new DevExpress.XtraGrid.GridControl();
            this.gv_CTHDXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_HDXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HDXuat)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHDXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHDXuat)).BeginInit();
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
            this.bt_themmoi,
            this.bt_chinhsua,
            this.bt_xoa,
            this.bt_InHoaDon});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_themmoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_chinhsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_InHoaDon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // bt_themmoi
            // 
            this.bt_themmoi.Caption = "Thêm mới";
            this.bt_themmoi.Id = 0;
            this.bt_themmoi.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.adddatasource;
            this.bt_themmoi.Name = "bt_themmoi";
            this.bt_themmoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_themmoi_ItemClick);
            // 
            // bt_chinhsua
            // 
            this.bt_chinhsua.Caption = "Chỉnh Sửa";
            this.bt_chinhsua.Id = 1;
            this.bt_chinhsua.ImageOptions.Image = global::QL_BanHang.Properties.Resources.editdatasource_16x16;
            this.bt_chinhsua.Name = "bt_chinhsua";
            this.bt_chinhsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_chinhsua_ItemClick);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Caption = "Xóa";
            this.bt_xoa.Id = 2;
            this.bt_xoa.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.deletedatasource;
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_xoa_ItemClick);
            // 
            // bt_InHoaDon
            // 
            this.bt_InHoaDon.Caption = "In hóa đơn";
            this.bt_InHoaDon.Id = 3;
            this.bt_InHoaDon.ImageOptions.Image = global::QL_BanHang.Properties.Resources.printernetwork_16x16;
            this.bt_InHoaDon.Name = "bt_InHoaDon";
            this.bt_InHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_InHoaDon_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1078, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 615);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1078, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 585);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1078, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 585);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.gc_HDXuat);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 30);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1078, 290);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // gc_HDXuat
            // 
            this.gc_HDXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_HDXuat.Location = new System.Drawing.Point(0, 0);
            this.gc_HDXuat.MainView = this.gv_HDXuat;
            this.gc_HDXuat.MenuManager = this.barManager1;
            this.gc_HDXuat.Name = "gc_HDXuat";
            this.gc_HDXuat.Size = new System.Drawing.Size(1078, 289);
            this.gc_HDXuat.TabIndex = 0;
            this.gc_HDXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_HDXuat});
            // 
            // gv_HDXuat
            // 
            this.gv_HDXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn13});
            this.gv_HDXuat.GridControl = this.gc_HDXuat;
            this.gv_HDXuat.Name = "gv_HDXuat";
            this.gv_HDXuat.OptionsBehavior.Editable = false;
            this.gv_HDXuat.OptionsView.ShowGroupPanel = false;
            this.gv_HDXuat.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_HDXuat_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Hóa Đơn Xuất";
            this.gridColumn1.FieldName = "ID_HDXuat";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số Phiếu Xuất";
            this.gridColumn2.FieldName = "sophieuxuat";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Khách Hàng";
            this.gridColumn3.FieldName = "makh";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên Khách Hàng";
            this.gridColumn4.FieldName = "tenkh";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày Tạo";
            this.gridColumn5.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "ngaytao";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Mã Số Thuế";
            this.gridColumn13.FieldName = "masothue";
            this.gridColumn13.MinWidth = 25;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 94;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.gc_CTHDXuat);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 320);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1078, 295);
            this.sidePanel2.TabIndex = 5;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // gc_CTHDXuat
            // 
            this.gc_CTHDXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CTHDXuat.Location = new System.Drawing.Point(0, 0);
            this.gc_CTHDXuat.MainView = this.gv_CTHDXuat;
            this.gc_CTHDXuat.MenuManager = this.barManager1;
            this.gc_CTHDXuat.Name = "gc_CTHDXuat";
            this.gc_CTHDXuat.Size = new System.Drawing.Size(1078, 295);
            this.gc_CTHDXuat.TabIndex = 0;
            this.gc_CTHDXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_CTHDXuat});
            // 
            // gv_CTHDXuat
            // 
            this.gv_CTHDXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn14});
            this.gv_CTHDXuat.GridControl = this.gc_CTHDXuat;
            this.gv_CTHDXuat.Name = "gv_CTHDXuat";
            this.gv_CTHDXuat.OptionsBehavior.Editable = false;
            this.gv_CTHDXuat.OptionsView.ShowAutoFilterRow = true;
            this.gv_CTHDXuat.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã Kho";
            this.gridColumn6.FieldName = "makho";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên Kho";
            this.gridColumn7.FieldName = "tenkho";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mã Sản Phẩm";
            this.gridColumn8.FieldName = "masp";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên Sản Phẩm";
            this.gridColumn9.FieldName = "tensp";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số Lượng";
            this.gridColumn10.FieldName = "soluong";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 94;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Đơn Giá";
            this.gridColumn11.DisplayFormat.FormatString = "#,#";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "dongia";
            this.gridColumn11.MinWidth = 25;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 94;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Chiết Khấu";
            this.gridColumn12.FieldName = "chietkhau";
            this.gridColumn12.MinWidth = 25;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            this.gridColumn12.Width = 94;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Thành Tiền";
            this.gridColumn14.DisplayFormat.FormatString = "#,#";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn14.FieldName = "thanhtien";
            this.gridColumn14.MinWidth = 25;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 7;
            this.gridColumn14.Width = 94;
            // 
            // frmHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 615);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHoaDonXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa Đơn Xuất";
            this.Load += new System.EventHandler(this.frmHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_HDXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_HDXuat)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_CTHDXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTHDXuat)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bt_themmoi;
        private DevExpress.XtraBars.BarButtonItem bt_chinhsua;
        private DevExpress.XtraBars.BarButtonItem bt_xoa;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraGrid.GridControl gc_CTHDXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTHDXuat;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gc_HDXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_HDXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraBars.BarButtonItem bt_InHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
    }
}