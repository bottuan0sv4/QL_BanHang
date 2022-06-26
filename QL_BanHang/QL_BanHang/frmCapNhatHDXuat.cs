using DevExpress.DataProcessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QL_BanHang.Class;
using System.Drawing;

namespace QL_BanHang
{
    public partial class frmCapNhatHDXuat : Form
    {
        Linq_QL_BanHangDataContext db = new Linq_QL_BanHangDataContext();
        HDXuat hdx = new HDXuat();
        CT_HDXuat ct_hdx = new CT_HDXuat();
        SanPham sp = new SanPham();

        public bool themmoi { get; set; }

        public clsHDXuat hdXuat { get; set; }
        public clsCTHDXuat cthdXuat { get; set; }

        List<clsCTHDXuat> lstchitiet = new List<clsCTHDXuat>();
        List<clsCTHDXuat> lstSource = new List<clsCTHDXuat>();


        public frmCapNhatHDXuat()
        {
            InitializeComponent();
        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e) 
        { 

        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (themmoi)
            {
                try
                {
                    lstchitiet.Add(new clsCTHDXuat()
                    {
                        ID_Kho = (from p in db.Khos
                                  where cbMaKho.Text == p.makho
                                  select p.ID_Kho).FirstOrDefault(),
                        makho = cbMaKho.Text,
                        tenkho = txt_TenKho.Text,
                        ID_SP = (from p in db.SanPhams
                                 where cbMaSP.Text == p.masp
                                 select p.ID_SP).FirstOrDefault(),
                        masp = cbMaSP.Text,
                        tensp = txt_TenSP.Text,
                        soluong = Convert.ToInt32(txt_SoLuong.EditValue),
                        dongia = Convert.ToDouble(txt_DonGia.EditValue),
                        chietkhau = Convert.ToDouble(txt_ChietKhau.EditValue),
                        thanhtien = ((Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) - ((Convert.ToDouble(txt_ChietKhau.EditValue) * Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) / 100)) + (((Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) - ((Convert.ToDouble(txt_ChietKhau.EditValue) * Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) / 100)) * Convert.ToDouble(txt_Thue.EditValue) / 100),
                        masothue = Convert.ToDouble(txt_Thue.EditValue)
                    });
                    cbMaKho.ResetText();
                    cbMaSP.ResetText();
                    txt_SoLuong.ResetText();
                    txt_ChietKhau.ResetText();
                    txt_TenKho.ResetText();
                    txt_TenSP.ResetText();
                    txt_DonGia.ResetText();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xin hãy nhập dữ liệu!", "Error");
                }


            }
            else
            {

                    lstchitiet.Add(new clsCTHDXuat()
                    {
                        ID_Kho = (from p in db.Khos
                                  where cbMaKho.Text == p.makho
                                  select p.ID_Kho).FirstOrDefault(),
                        makho = cbMaKho.Text,
                        tenkho = txt_TenKho.Text,
                        ID_SP = (from p in db.SanPhams
                                 where cbMaSP.Text == p.masp
                                 select p.ID_SP).FirstOrDefault(),
                        masp = cbMaSP.Text,
                        tensp = txt_TenSP.Text,
                        soluong = Convert.ToInt32(txt_SoLuong.EditValue),
                        dongia = Convert.ToDouble(txt_DonGia.EditValue),
                        chietkhau = Convert.ToDouble(txt_ChietKhau.EditValue),
                        thanhtien = ((Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) - ((Convert.ToDouble(txt_ChietKhau.EditValue) * Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) / 100)) + (((Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) - ((Convert.ToDouble(txt_ChietKhau.EditValue) * Convert.ToDouble(txt_DonGia.EditValue) * Convert.ToInt32(txt_SoLuong.EditValue)) / 100)) * Convert.ToDouble(txt_Thue.EditValue) / 100),
                        masothue = Convert.ToDouble(txt_Thue.EditValue)
                    });
                    cbMaKho.ResetText();
                    cbMaSP.ResetText();
                    txt_SoLuong.ResetText();
                    txt_ChietKhau.ResetText();
                    txt_TenKho.ResetText();
                    txt_TenSP.ResetText();
                    txt_DonGia.ResetText();
                lstchitiet.AddRange(lstSource);
            }
            
            cbMaSP.Items.Clear();
            cbMaKH.Items.Clear();
            cbMaKho.Items.Clear();

            frmCapNhatHDXuat_Load(sender, e);
            gc_ctHDXuat.DataSource = lstchitiet;
            gc_ctHDXuat.RefreshDataSource();
        }

        private void bt_Luu_HD_Click(object sender, EventArgs e)
        {
            
                if (themmoi)
                {

                        hdx.sophieuxuat = txt_SoPhieuXuat.Text;
                        hdx.makh = cbMaKH.Text;
                        hdx.ngaytao = (DateTime)date_NgayTao.DateTime;
                        var list = (from p in db.KHs
                                    where cbMaKH.Text == p.makh
                                    select p.ID_KH).SingleOrDefault();
                        hdx.ID_KH = list;
                if (string.IsNullOrEmpty(hdx.sophieuxuat))
                {
                    MessageBox.Show("Hãy nhập dữ liệu!", "Error");
                }
                else
                {
                    foreach (var item in lstchitiet)
                    {
                        CT_HDXuat ct = new CT_HDXuat();
                        ct.makho = item.makho;
                        ct.masp = item.masp;
                        ct.soluong = item.soluong;
                        ct.chietkhau = item.chietkhau;
                        ct.thanhtien = item.thanhtien;


                        ct.ID_Kho = item.ID_Kho;

                        ct.ID_SP = item.ID_SP;

                        ct.ID_HDXuat = item.ID_HDXuat;


                        hdx.CT_HDXuats.Add(ct);
                    }


                    db.HDXuats.InsertOnSubmit(hdx);
                    db.SubmitChanges();
                    frmHoaDonXuat_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;
                }

                }
                else
                {
                    HDXuat hdxs = (from ds in db.HDXuats where ds.ID_HDXuat == hdXuat.ID_HDXuat select ds).FirstOrDefault();

                    hdx = db.HDXuats.Where(s => s.sophieuxuat == txt_SoPhieuXuat.Text).FirstOrDefault();
                    hdx.sophieuxuat = txt_SoPhieuXuat.Text;
                    hdx.makh = cbMaKH.Text;
                    hdx.ngaytao = (DateTime)date_NgayTao.DateTime;
                    var list = (from p in db.KHs
                                where cbMaKH.Text == p.makh
                                select p.ID_KH).SingleOrDefault();
                    hdx.ID_KH = list;
                    foreach (var item in from ds in db.CT_HDXuats where ds.ID_HDXuat == hdxs.ID_HDXuat select ds)
                    {
                        db.CT_HDXuats.DeleteOnSubmit(item);
                    }
                    foreach (var item in lstchitiet)
                    {
                        CT_HDXuat ct = new CT_HDXuat();
                        ct.makho = item.makho;
                        ct.masp = item.masp;
                        ct.soluong = item.soluong;
                        ct.chietkhau = item.chietkhau;
                        ct.thanhtien = item.thanhtien;

                        ct.ID_Kho = (from p in db.Khos
                                     where item.makho == p.makho
                                     select p.ID_Kho).SingleOrDefault();

                        ct.ID_SP = (from p in db.SanPhams
                                    where item.masp == p.masp
                                    select p.ID_SP).SingleOrDefault();

                        ct.ID_HDXuat = (from p in db.HDXuats
                                        where txt_SoPhieuXuat.Text == p.sophieuxuat
                                        select p.ID_HDXuat).SingleOrDefault();
                        ct.ID_CTHDX = item.ID_CTHDX;

                        hdx.CT_HDXuats.Add(ct);
                    }
                    db.SubmitChanges();
                    frmHoaDonXuat_Load(sender, e);
                    this.DialogResult = DialogResult.Cancel;

                }

        }

        private void frmCapNhatHDXuat_Load(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.KHs select p;
            var list2 = from c in db.Khos select c;
            var list3 = from d in db.SanPhams select d;

            foreach (var kh in list)
            {
                cbMaKH.Items.Add(kh.makh);
            }
            foreach (var kho in list2)
            {
                cbMaKho.Items.Add(kho.makho);
            }
            foreach (var sp in list3)
            {
                cbMaSP.Items.Add(sp.masp);
            }
            if (themmoi)
            {

            }
            else
            {
                txt_SoPhieuXuat.Text = hdXuat.sophieuxuat;
                date_NgayTao.DateTime = hdXuat.ngaytao;
                cbMaKH.Text = hdXuat.makh;

                lstSource = (from p in db.CT_HDXuats
                          join c in db.Khos on p.ID_Kho equals c.ID_Kho
                          join s in db.SanPhams on p.ID_SP equals s.ID_SP
                          join d in db.HDXuats on p.ID_HDXuat equals d.ID_HDXuat
                          where p.ID_HDXuat == hdXuat.ID_HDXuat
                          select new clsCTHDXuat
                          {
                              ID_CTHDX = p.ID_CTHDX,
                              ID_HDXuat = p.ID_HDXuat,
                              sophieuxuat = d.sophieuxuat,
                              masp = p.masp,
                              tensp = s.tensp,
                              makho = p.makho,
                              tenkho = c.tenkho,
                              soluong = p.soluong,
                              dongia = s.dongia,
                              chietkhau = p.chietkhau,
                              thanhtien = p.thanhtien,
                          }).OrderBy(x => x.ID_HDXuat).ToList();

                gc_ctHDXuat.DataSource = lstSource;
                gc_ctHDXuat.RefreshDataSource();
            }
        }

        private void cbMaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.KHs where p.makh == cbMaKH.Text select p;
            foreach (var kh in list)
            {
                txt_TenKH.Text = kh.tenkh;
                txt_Thue.EditValue = kh.masothue;
            }
        }

        private void cbMaKho_SelectedValueChanged(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.Khos where p.makho == cbMaKho.Text select p;
            foreach (var kho in list)
            {
                txt_TenKho.Text = kho.tenkho;
            }
        }

        private void cbMaSP_SelectedValueChanged(object sender, EventArgs e)
        {
            db = new Linq_QL_BanHangDataContext();
            var list = from p in db.SanPhams where p.masp == cbMaSP.Text select p;
            foreach (var sp in list)
            {
                txt_TenSP.Text = sp.tensp;
                txt_DonGia.EditValue = sp.dongia;
            }
        }

        private void gv_ctHDXuat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var obj = gv_ctHDXuat.GetRowCellValue(e.RowHandle, maSP);
            if (obj != null)
            {

                var b = (from ds in lstSource where ds.masp == obj.ToString() select ds).FirstOrDefault();
                if (b.soluong != 0 && b.dongia != 0 && b.chietkhau != 0)
                {
                    if (b != null)
                    {
                        b.thanhtien = (int.Parse(b.soluong.ToString()) * int.Parse(b.dongia.ToString())) - (int.Parse(b.soluong.ToString()) * int.Parse(b.dongia.ToString()) * int.Parse(b.chietkhau.ToString()) / 100) + (int.Parse(b.soluong.ToString()) * int.Parse(b.dongia.ToString()) * int.Parse(b.masothue.ToString()) / 100);                        
                        gc_ctHDXuat.DataSource = lstSource;
                    }

                }
                
            }
        }

        private void txt_Thue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_ChietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            /*long n;
            if (long.TryParse(txt_SoLuong.Text, out n))
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Successful!";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Error! Vui lòng nhập số!";
            }*/
        }

        private void txt_Thue_TextChanged(object sender, EventArgs e)
        {
            /*double n;
            if (double.TryParse(txt_SoPhieuXuat.Text, out n))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Successful!";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Error! Vui lòng nhập số!";
            }*/
        }

        private void txt_ChietKhau_TextChanged(object sender, EventArgs e)
        {
            /*double n;
            if (double.TryParse(txt_ChietKhau.Text, out n))
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Successful!";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Error! Vui lòng nhập số";
            }*/
        }

        private void txt_SoPhieuXuat_TextChanged(object sender, EventArgs e)
        {
            /*long n;
            if (long.TryParse(txt_SoPhieuXuat.Text, out n))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Successful!";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Error! Vui lòng nhập số!";
            }*/
        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_SoPhieuXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmCapNhatHDXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }
    }
}
