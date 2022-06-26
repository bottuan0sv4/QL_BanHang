
namespace QL_BanHang
{
    partial class frmNhaCC
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
            this.gc_Nhacc = new DevExpress.XtraGrid.GridControl();
            this.gv_Nhacc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Nhacc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Nhacc)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(800, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(800, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // gc_Nhacc
            // 
            this.gc_Nhacc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Nhacc.Location = new System.Drawing.Point(0, 30);
            this.gc_Nhacc.MainView = this.gv_Nhacc;
            this.gc_Nhacc.MenuManager = this.barManager1;
            this.gc_Nhacc.Name = "gc_Nhacc";
            this.gc_Nhacc.Size = new System.Drawing.Size(800, 420);
            this.gc_Nhacc.TabIndex = 4;
            this.gc_Nhacc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Nhacc});
            // 
            // gv_Nhacc
            // 
            this.gv_Nhacc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_Nhacc.GridControl = this.gc_Nhacc;
            this.gv_Nhacc.Name = "gv_Nhacc";
            this.gv_Nhacc.OptionsBehavior.Editable = false;
            this.gv_Nhacc.OptionsView.ShowAutoFilterRow = true;
            this.gv_Nhacc.OptionsView.ShowDetailButtons = false;
            this.gv_Nhacc.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID Nhà Cung Cấp";
            this.gridColumn1.FieldName = "ID_NCC";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Nhà Cung Cấp *";
            this.gridColumn2.FieldName = "mancc";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Nhà Cung Cấp";
            this.gridColumn3.FieldName = "tenncc";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa Chỉ";
            this.gridColumn4.FieldName = "diachi";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Điện Thoại";
            this.gridColumn5.FieldName = "sdt";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // frmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gc_Nhacc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmNhaCC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNhaCC_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Nhacc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Nhacc)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gc_Nhacc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Nhacc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}