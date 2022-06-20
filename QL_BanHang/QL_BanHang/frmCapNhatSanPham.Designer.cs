
namespace QL_BanHang
{
    partial class frmCapNhatSanPham
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
            this.txt_DonVi = new DevExpress.XtraEditors.TextEdit();
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenSP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaSP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.date_NgayTao = new DevExpress.XtraEditors.DateEdit();
            this.bt_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.Location = new System.Drawing.Point(727, 47);
            this.txt_DonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.Size = new System.Drawing.Size(84, 22);
            this.txt_DonVi.TabIndex = 51;
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.paymentunpaid;
            this.bt_Huy.Location = new System.Drawing.Point(685, 107);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(125, 46);
            this.bt_Huy.TabIndex = 50;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(140, 47);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(229, 22);
            this.txt_TenSP.TabIndex = 49;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(19, 50);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(89, 17);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "Tên Sản Phẩm";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(513, 47);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(125, 22);
            this.txt_DonGia.TabIndex = 47;
            this.txt_DonGia.TextChanged += new System.EventHandler(this.txt_DonGia_TextChanged);
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(419, 50);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 16);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "Đơn Giá";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(419, 22);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 17);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Ngày Tạo";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(647, 50);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Đơn Vị Tính";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(140, 15);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(229, 22);
            this.txt_MaSP.TabIndex = 39;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 17);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Mã Sản Phẩm";
            // 
            // date_NgayTao
            // 
            this.date_NgayTao.EditValue = null;
            this.date_NgayTao.Location = new System.Drawing.Point(513, 15);
            this.date_NgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.date_NgayTao.Name = "date_NgayTao";
            this.date_NgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_NgayTao.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date_NgayTao.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.date_NgayTao.Size = new System.Drawing.Size(296, 22);
            this.date_NgayTao.TabIndex = 52;
            // 
            // bt_CapNhat
            // 
            this.bt_CapNhat.ImageOptions.SvgImage = global::QL_BanHang.Properties.Resources.refreshallpivottable;
            this.bt_CapNhat.Location = new System.Drawing.Point(552, 107);
            this.bt_CapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_CapNhat.Name = "bt_CapNhat";
            this.bt_CapNhat.Size = new System.Drawing.Size(125, 46);
            this.bt_CapNhat.TabIndex = 46;
            this.bt_CapNhat.Text = "Cập Nhật";
            this.bt_CapNhat.Click += new System.EventHandler(this.bt_CapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 53;
            // 
            // frmCapNhatSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_NgayTao);
            this.Controls.Add(this.txt_DonVi);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.bt_CapNhat);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCapNhatSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập Nhật Sản Phẩm";
            this.Load += new System.EventHandler(this.frmCapNhatSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_NgayTao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_DonVi;
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.TextEdit txt_TenSP;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_DonGia;
        private DevExpress.XtraEditors.SimpleButton bt_CapNhat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_MaSP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit date_NgayTao;
        private System.Windows.Forms.Label label1;
    }
}