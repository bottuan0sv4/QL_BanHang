
namespace QL_BanHang
{
    partial class frmCapNhatNCC
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
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenNCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaNCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.paymentunpaid;
            this.bt_Huy.Location = new System.Drawing.Point(680, 82);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(125, 46);
            this.bt_Huy.TabIndex = 50;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(135, 42);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(229, 22);
            this.txt_TenNCC.TabIndex = 49;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 45);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(116, 17);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "Tên Nhà Cung Cấp";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(508, 42);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(297, 22);
            this.txt_SDT.TabIndex = 44;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(387, 47);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 17);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Số Điện Thoại";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(508, 10);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(297, 22);
            this.txt_DiaChi.TabIndex = 42;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(387, 15);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 17);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Địa Chỉ";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Location = new System.Drawing.Point(135, 10);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(229, 22);
            this.txt_MaNCC.TabIndex = 39;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 17);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Mã Nhà Cung Cấp";
            // 
            // bt_CapNhat
            // 
            this.bt_CapNhat.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.refreshallpivottable;
            this.bt_CapNhat.Location = new System.Drawing.Point(547, 82);
            this.bt_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_CapNhat.Name = "bt_CapNhat";
            this.bt_CapNhat.Size = new System.Drawing.Size(125, 46);
            this.bt_CapNhat.TabIndex = 46;
            this.bt_CapNhat.Text = "Cập Nhật";
            this.bt_CapNhat.Click += new System.EventHandler(this.bt_CapNhat_Click);
            // 
            // frmCapNhatNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 142);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.txt_TenNCC);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.bt_CapNhat);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_MaNCC);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmCapNhatNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập Nhật Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmCapNhatNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNCC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.TextEdit txt_TenNCC;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton bt_CapNhat;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_MaNCC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}