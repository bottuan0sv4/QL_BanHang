
namespace QL_BanHang
{
    partial class frmBaoCao
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
            this.gc_BaoCao = new DevExpress.XtraGrid.GridControl();
            this.clsBaoCaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_BaoCao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btMaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bt_MaKho = new DevExpress.XtraBars.BarButtonItem();
            this.bt_NgayNhap = new DevExpress.XtraBars.BarButtonItem();
            this.bt_NgayXuat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gc_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBaoCaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_BaoCao
            // 
            this.gc_BaoCao.DataSource = this.clsBaoCaoBindingSource;
            this.gc_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_BaoCao.Location = new System.Drawing.Point(0, 30);
            this.gc_BaoCao.MainView = this.gv_BaoCao;
            this.gc_BaoCao.Name = "gc_BaoCao";
            this.gc_BaoCao.Size = new System.Drawing.Size(850, 420);
            this.gc_BaoCao.TabIndex = 0;
            this.gc_BaoCao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_BaoCao});
            // 
            // clsBaoCaoBindingSource
            // 
            this.clsBaoCaoBindingSource.DataSource = typeof(QL_BanHang.Class.clsBaoCao);
            // 
            // gv_BaoCao
            // 
            this.gv_BaoCao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gv_BaoCao.GridControl = this.gc_BaoCao;
            this.gv_BaoCao.Name = "gv_BaoCao";
            this.gv_BaoCao.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Kho";
            this.gridColumn1.FieldName = "MaKho";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Kho";
            this.gridColumn2.FieldName = "TenKho";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Sản Phẩm";
            this.gridColumn3.FieldName = "MaSP";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên Sản Phẩm";
            this.gridColumn4.FieldName = "TenSP";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Lượng Nhập";
            this.gridColumn5.FieldName = "SoLuongNhap";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Sô Lượng Xuất";
            this.gridColumn6.FieldName = "SoLuongXuat";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Thời Gian Nhập";
            this.gridColumn7.FieldName = "ThoiGianNhap";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Thời Gian Xuất";
            this.gridColumn8.FieldName = "ThoiGianXuat";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 94;
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
            this.bt_MaKho,
            this.bt_NgayNhap,
            this.bt_NgayXuat,
            this.btMaKho,
            this.btBaoCao});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btBaoCao, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btMaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btMaKho
            // 
            this.btMaKho.Caption = "Mã Kho";
            this.btMaKho.Id = 3;
            this.btMaKho.ImageOptions.Image = global::QL_BanHang.Properties.Resources.boproductgroup_16x16;
            this.btMaKho.Name = "btMaKho";
            this.btMaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btMaKho_ItemClick);
            // 
            // btBaoCao
            // 
            this.btBaoCao.Caption = "Báo Cáo";
            this.btBaoCao.Id = 4;
            this.btBaoCao.ImageOptions.Image = global::QL_BanHang.Properties.Resources.boreport2_16x16;
            this.btBaoCao.ImageOptions.LargeImage = global::QL_BanHang.Properties.Resources.boreport2_32x32;
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btBaoCao_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(850, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(850, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(850, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // bt_MaKho
            // 
            this.bt_MaKho.Caption = "Theo Kho";
            this.bt_MaKho.Id = 0;
            this.bt_MaKho.ImageOptions.Image = global::QL_BanHang.Properties.Resources.bosaleitem_16x16;
            this.bt_MaKho.ImageOptions.LargeImage = global::QL_BanHang.Properties.Resources.bosaleitem_32x32;
            this.bt_MaKho.Name = "bt_MaKho";
            this.bt_MaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_MaKho_ItemClick);
            // 
            // bt_NgayNhap
            // 
            this.bt_NgayNhap.Caption = "Theo Ngày Nhập";
            this.bt_NgayNhap.Id = 1;
            this.bt_NgayNhap.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.date1;
            this.bt_NgayNhap.Name = "bt_NgayNhap";
            this.bt_NgayNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_NgayNhap_ItemClick);
            // 
            // bt_NgayXuat
            // 
            this.bt_NgayXuat.Caption = "Theo Ngày Xuất";
            this.bt_NgayXuat.Id = 2;
            this.bt_NgayXuat.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.date_time;
            this.bt_NgayXuat.Name = "bt_NgayXuat";
            this.bt_NgayXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bt_NgayXuat_ItemClick);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.gc_BaoCao);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBaoCaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_BaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_BaoCao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.BindingSource clsBaoCaoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bt_MaKho;
        private DevExpress.XtraBars.BarButtonItem bt_NgayNhap;
        private DevExpress.XtraBars.BarButtonItem bt_NgayXuat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btMaKho;
        private DevExpress.XtraBars.BarButtonItem btBaoCao;
    }
}