
namespace QL_BanHang
{
    partial class frmXacNhanXoaHDN
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.txt_SoPhieuNhap = new DevExpress.XtraEditors.TextEdit();
            this.date_NgayTao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.txt_TenNCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(387, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bạn Có Xác Nhận Xóa?";
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.paymentunpaid;
            this.bt_Huy.Location = new System.Drawing.Point(489, 173);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(106, 43);
            this.bt_Huy.TabIndex = 2;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_Xacnhan
            // 
            this.bt_Xacnhan.ImageOptions.Image = global::QL_BanHang.Properties.Resources.apply_32x32;
            this.bt_Xacnhan.Location = new System.Drawing.Point(319, 173);
            this.bt_Xacnhan.Name = "bt_Xacnhan";
            this.bt_Xacnhan.Size = new System.Drawing.Size(113, 43);
            this.bt_Xacnhan.TabIndex = 1;
            this.bt_Xacnhan.Text = "Xác Nhận";
            this.bt_Xacnhan.Click += new System.EventHandler(this.bt_Xacnhan_Click);
            // 
            // txt_SoPhieuNhap
            // 
            this.txt_SoPhieuNhap.Location = new System.Drawing.Point(134, 12);
            this.txt_SoPhieuNhap.Name = "txt_SoPhieuNhap";
            this.txt_SoPhieuNhap.Size = new System.Drawing.Size(243, 22);
            this.txt_SoPhieuNhap.TabIndex = 81;
            // 
            // date_NgayTao
            // 
            this.date_NgayTao.EditValue = null;
            this.date_NgayTao.Location = new System.Drawing.Point(636, 12);
            this.date_NgayTao.Name = "date_NgayTao";
            this.date_NgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayTao.Size = new System.Drawing.Size(234, 22);
            this.date_NgayTao.TabIndex = 80;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(512, 15);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(56, 17);
            this.labelControl14.TabIndex = 79;
            this.labelControl14.Text = "Ngày tạo";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(134, 63);
            this.cbMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(243, 24);
            this.cbMaNCC.TabIndex = 78;
            this.cbMaNCC.SelectedValueChanged += new System.EventHandler(this.cbMaNCC_SelectedValueChanged);
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(636, 63);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(235, 22);
            this.txt_TenNCC.TabIndex = 77;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(512, 66);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(116, 17);
            this.labelControl5.TabIndex = 76;
            this.labelControl5.Text = "Tên Nhà Cung Cấp";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 67);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 17);
            this.labelControl4.TabIndex = 75;
            this.labelControl4.Text = "Mã Nhà Cung Cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 17);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Số phiếu nhập";
            // 
            // frmXacNhanXoaHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 241);
            this.Controls.Add(this.txt_SoPhieuNhap);
            this.Controls.Add(this.date_NgayTao);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.cbMaNCC);
            this.Controls.Add(this.txt_TenNCC);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_Xacnhan);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmXacNhanXoaHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác Nhận Xóa Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.frmXacNhanXoaHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_Xacnhan;
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.TextEdit txt_SoPhieuNhap;
        private DevExpress.XtraEditors.DateEdit date_NgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private DevExpress.XtraEditors.TextEdit txt_TenNCC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}