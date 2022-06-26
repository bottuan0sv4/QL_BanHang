
namespace QL_BanHang
{
    partial class frmTonKho
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_TonKho = new DevExpress.XtraGrid.GridControl();
            this.gv_TonKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTonKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // clsTonKhoBindingSource
            // 
            this.clsTonKhoBindingSource.DataSource = typeof(QL_BanHang.Class.clsTonKho);
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // gc_TonKho
            // 
            this.gc_TonKho.DataSource = this.clsTonKhoBindingSource;
            this.gc_TonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TonKho.Location = new System.Drawing.Point(0, 0);
            this.gc_TonKho.MainView = this.gv_TonKho;
            this.gc_TonKho.Name = "gc_TonKho";
            this.gc_TonKho.Size = new System.Drawing.Size(1085, 394);
            this.gc_TonKho.TabIndex = 2;
            this.gc_TonKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TonKho});
            // 
            // gv_TonKho
            // 
            this.gv_TonKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn16});
            this.gv_TonKho.GridControl = this.gc_TonKho;
            this.gv_TonKho.Name = "gv_TonKho";
            this.gv_TonKho.OptionsBehavior.Editable = false;
            this.gv_TonKho.OptionsView.ShowAutoFilterRow = true;
            this.gv_TonKho.OptionsView.ShowDetailButtons = false;
            this.gv_TonKho.OptionsView.ShowGroupPanel = false;
            this.gv_TonKho.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã Sản Phẩm";
            this.gridColumn6.FieldName = "MaSP";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Sản Phẩm";
            this.gridColumn1.FieldName = "TenSP";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Lượng Nhập";
            this.gridColumn4.FieldName = "SoLuongNhap";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 106;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Lượng Xuất";
            this.gridColumn5.FieldName = "SoLuongXuat";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 105;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tồn";
            this.gridColumn2.FieldName = "Ton";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 56;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá Trị";
            this.gridColumn3.DisplayFormat.FormatString = "#,#";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "giatri";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 85;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Đơn Giá";
            this.gridColumn8.DisplayFormat.FormatString = "#,#";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "dongia";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 68;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Mã Kho";
            this.gridColumn9.FieldName = "MaKho";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 87;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tên Kho";
            this.gridColumn10.FieldName = "TenKho";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 62;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Tồn Đầu Năm";
            this.gridColumn16.FieldName = "TonDauNam";
            this.gridColumn16.MinWidth = 25;
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 94;
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 394);
            this.Controls.Add(this.gc_TonKho);
            this.KeyPreview = true;
            this.Name = "frmTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn Kho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTonKho_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTonKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsTonKhoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gc_TonKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TonKho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
    }
}