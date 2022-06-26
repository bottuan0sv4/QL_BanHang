
namespace QL_BanHang
{
    partial class FrmTaiKhoan
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
            this.gc_TaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gv_TaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_TK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bt_Them = new DevExpress.XtraBars.BarButtonItem();
            this.bt_Chinhsua = new DevExpress.XtraBars.BarButtonItem();
            this.bt_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bt_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_TaiKhoan
            // 
            this.gc_TaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_TaiKhoan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_TaiKhoan.Location = new System.Drawing.Point(0, 30);
            this.gc_TaiKhoan.MainView = this.gv_TaiKhoan;
            this.gc_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.gc_TaiKhoan.Name = "gc_TaiKhoan";
            this.gc_TaiKhoan.Size = new System.Drawing.Size(1067, 523);
            this.gc_TaiKhoan.TabIndex = 0;
            this.gc_TaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TaiKhoan,
            this.bandedGridView1});
            // 
            // gv_TaiKhoan
            // 
            this.gv_TaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_TK,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gv_TaiKhoan.DetailHeight = 431;
            this.gv_TaiKhoan.GridControl = this.gc_TaiKhoan;
            this.gv_TaiKhoan.Name = "gv_TaiKhoan";
            this.gv_TaiKhoan.OptionsBehavior.Editable = false;
            this.gv_TaiKhoan.OptionsView.ShowAutoFilterRow = true;
            this.gv_TaiKhoan.OptionsView.ShowDetailButtons = false;
            this.gv_TaiKhoan.OptionsView.ShowGroupPanel = false;
            // 
            // ID_TK
            // 
            this.ID_TK.Caption = "ID Tài Khoản";
            this.ID_TK.FieldName = "ID_TK";
            this.ID_TK.MinWidth = 27;
            this.ID_TK.Name = "ID_TK";
            this.ID_TK.OptionsColumn.FixedWidth = true;
            this.ID_TK.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên";
            this.gridColumn2.FieldName = "hoten";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa Chỉ";
            this.gridColumn3.FieldName = "diachi";
            this.gridColumn3.MinWidth = 27;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày Sinh";
            this.gridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "ngaysinh";
            this.gridColumn4.MinWidth = 27;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Điện Thoại";
            this.gridColumn5.FieldName = "sdt";
            this.gridColumn5.MinWidth = 27;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giới Tính";
            this.gridColumn6.FieldName = "gioitinh";
            this.gridColumn6.MinWidth = 27;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Username";
            this.gridColumn7.FieldName = "username";
            this.gridColumn7.MinWidth = 27;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Password";
            this.gridColumn8.FieldName = "password";
            this.gridColumn8.MinWidth = 27;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 100;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.DetailHeight = 431;
            this.bandedGridView1.GridControl = this.gc_TaiKhoan;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.MinWidth = 13;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 93;
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
            this.bt_Them,
            this.bt_Chinhsua,
            this.bt_Xoa,
            this.bt_Luu});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_Them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_Chinhsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bt_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // bt_Them
            // 
            this.bt_Them.Caption = "Thêm mới";
            this.bt_Them.Id = 0;
            this.bt_Them.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.adddatasource;
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ClickThemMoi);
            // 
            // bt_Chinhsua
            // 
            this.bt_Chinhsua.Caption = "Chỉnh sửa";
            this.bt_Chinhsua.Id = 1;
            this.bt_Chinhsua.ImageOptions.Image = global::QL_BanHang.Properties.Resources.editdatasource_16x16;
            this.bt_Chinhsua.ImageOptions.LargeImage = global::QL_BanHang.Properties.Resources.editdatasource_32x321;
            this.bt_Chinhsua.Name = "bt_Chinhsua";
            this.bt_Chinhsua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ClickChinhSua);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Caption = "Xóa";
            this.bt_Xoa.Id = 2;
            this.bt_Xoa.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.deletedatasource;
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_ClickXoa);
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
            // bt_Luu
            // 
            this.bt_Luu.Caption = "Lưu";
            this.bt_Luu.Id = 3;
            this.bt_Luu.Name = "bt_Luu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gc_TaiKhoan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục tài khoản";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTaiKhoan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_TaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn ID_TK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bt_Them;
        private DevExpress.XtraBars.BarButtonItem bt_Chinhsua;
        private DevExpress.XtraBars.BarButtonItem bt_Xoa;
        private DevExpress.XtraBars.BarButtonItem bt_Luu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraBars.Bar bar2;
    }
}