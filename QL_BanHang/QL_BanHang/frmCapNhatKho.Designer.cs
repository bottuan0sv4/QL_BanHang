
namespace QL_BanHang
{
    partial class frmCapNhatKho
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
            this.txt_TenKho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaKho = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.paymentunpaid;
            this.bt_Huy.Location = new System.Drawing.Point(232, 79);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(103, 46);
            this.bt_Huy.TabIndex = 62;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // txt_TenKho
            // 
            this.txt_TenKho.Location = new System.Drawing.Point(105, 47);
            this.txt_TenKho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKho.Name = "txt_TenKho";
            this.txt_TenKho.Size = new System.Drawing.Size(229, 22);
            this.txt_TenKho.TabIndex = 61;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 50);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 16);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Tên Kho";
            // 
            // txt_MaKho
            // 
            this.txt_MaKho.Location = new System.Drawing.Point(105, 15);
            this.txt_MaKho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKho.Name = "txt_MaKho";
            this.txt_MaKho.Size = new System.Drawing.Size(229, 22);
            this.txt_MaKho.TabIndex = 54;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Mã Kho *";
            // 
            // bt_XacNhan
            // 
            this.bt_XacNhan.ImageOptions.Image = global::QL_BanHang.Properties.Resources.apply_32x32;
            this.bt_XacNhan.Location = new System.Drawing.Point(105, 79);
            this.bt_XacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_XacNhan.Name = "bt_XacNhan";
            this.bt_XacNhan.Size = new System.Drawing.Size(119, 46);
            this.bt_XacNhan.TabIndex = 58;
            this.bt_XacNhan.Text = "Xác Nhận";
            this.bt_XacNhan.Click += new System.EventHandler(this.bt_XacNhan_Click);
            // 
            // frmCapNhatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 135);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.txt_TenKho);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.bt_XacNhan);
            this.Controls.Add(this.txt_MaKho);
            this.Controls.Add(this.labelControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCapNhatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập Nhật Kho";
            this.Load += new System.EventHandler(this.frmCapNhatKho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCapNhatKho_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.TextEdit txt_TenKho;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton bt_XacNhan;
        private DevExpress.XtraEditors.TextEdit txt_MaKho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}