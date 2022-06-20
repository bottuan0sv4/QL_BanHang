
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
            ((System.ComponentModel.ISupportInitialize)(this.gc_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBaoCaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_BaoCao
            // 
            this.gc_BaoCao.DataSource = this.clsBaoCaoBindingSource;
            this.gc_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_BaoCao.Location = new System.Drawing.Point(0, 0);
            this.gc_BaoCao.MainView = this.gv_BaoCao;
            this.gc_BaoCao.Name = "gc_BaoCao";
            this.gc_BaoCao.Size = new System.Drawing.Size(850, 450);
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
            this.gv_BaoCao.OptionsView.ShowAutoFilterRow = true;
            this.gv_BaoCao.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn7.GroupFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn7.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
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
            this.gridColumn8.GroupFormat.FormatString = "dd/MM/yyyy";
            this.gridColumn8.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 94;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.gc_BaoCao);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo Cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBaoCaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BaoCao)).EndInit();
            this.ResumeLayout(false);

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
    }
}