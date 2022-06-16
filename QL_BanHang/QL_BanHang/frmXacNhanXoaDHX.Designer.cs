
namespace QL_BanHang
{
    partial class frmXacNhanXoaDHX
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
            this.txt_SoPhieuXuat = new DevExpress.XtraEditors.TextEdit();
            this.date_NgayTao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SoPhieuXuat
            // 
            this.txt_SoPhieuXuat.Location = new System.Drawing.Point(131, 12);
            this.txt_SoPhieuXuat.Name = "txt_SoPhieuXuat";
            this.txt_SoPhieuXuat.Size = new System.Drawing.Size(243, 22);
            this.txt_SoPhieuXuat.TabIndex = 92;
            // 
            // date_NgayTao
            // 
            this.date_NgayTao.EditValue = null;
            this.date_NgayTao.Location = new System.Drawing.Point(633, 12);
            this.date_NgayTao.Name = "date_NgayTao";
            this.date_NgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayTao.Size = new System.Drawing.Size(234, 22);
            this.date_NgayTao.TabIndex = 91;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(509, 15);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(59, 17);
            this.labelControl14.TabIndex = 90;
            this.labelControl14.Text = "Ngày Tạo";
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(131, 63);
            this.cbMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(243, 24);
            this.cbMaKH.TabIndex = 89;
            this.cbMaKH.SelectedValueChanged += new System.EventHandler(this.cbMaKH_SelectedValueChanged);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(633, 63);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(235, 22);
            this.txt_TenKH.TabIndex = 88;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(509, 66);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(93, 16);
            this.labelControl5.TabIndex = 87;
            this.labelControl5.Text = "Tên Khách Hàng";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(11, 67);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 16);
            this.labelControl4.TabIndex = 86;
            this.labelControl4.Text = "Mã Khách Hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 17);
            this.labelControl2.TabIndex = 85;
            this.labelControl2.Text = "Số Phiếu Xuất";
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.paymentunpaid;
            this.bt_Huy.Location = new System.Drawing.Point(486, 173);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(106, 43);
            this.bt_Huy.TabIndex = 84;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // bt_Xacnhan
            // 
            this.bt_Xacnhan.ImageOptions.Image = global::QL_BanHang.Properties.Resources.apply_32x32;
            this.bt_Xacnhan.Location = new System.Drawing.Point(316, 173);
            this.bt_Xacnhan.Name = "bt_Xacnhan";
            this.bt_Xacnhan.Size = new System.Drawing.Size(113, 43);
            this.bt_Xacnhan.TabIndex = 83;
            this.bt_Xacnhan.Text = "Xác Nhận";
            this.bt_Xacnhan.Click += new System.EventHandler(this.bt_Xacnhan_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(384, 117);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(140, 17);
            this.labelControl1.TabIndex = 82;
            this.labelControl1.Text = "Bạn Có Xác Nhận Xóa?";
            // 
            // frmXacNhanXoaDHX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 232);
            this.Controls.Add(this.txt_SoPhieuXuat);
            this.Controls.Add(this.date_NgayTao);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_Xacnhan);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmXacNhanXoaDHX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmXacNhanXoaDHX";
            this.Load += new System.EventHandler(this.frmXacNhanXoaDHX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_SoPhieuXuat;
        private DevExpress.XtraEditors.DateEdit date_NgayTao;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.ComboBox cbMaKH;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.SimpleButton bt_Xacnhan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}