using QLDungCuTheThao.DAL;
using QLDungCuTheThao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDungCuTheThao.BLL
{
    internal class TheMuonTraBLL
    {
        public static List<TheMuonTra> getList()
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.TheMuonTras.OrderByDescending(e => e.Id).ToList();
        }
        public static List<TheMuonTraVM> getListVM()
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.TheMuonTras.Select(e => new TheMuonTraVM
            {
                ID = e.Id, 
                IDDungCu = e.IdDungCu,
                TenDungCu = model.DungCus.Where(x => x.Id == e.IdDungCu).Select(x => x.Ten).FirstOrDefault(),
                TenNguoiMuon = e.TenNguoiMuon,
                Lop = e.Lop,
                SoLuongMuon = e.SoLuongMuon, 
                NgayMuon = e.NgayMuon.ToString(),
                NgayTra = e.NgayTra.ToString(),
                TrangThai = (e.TrangThai==false?"Đang mượn":"Đã trả")
            }).ToList();
        }
        public static List<TheMuonTraVM> getListVMbySearch(String tk)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.TheMuonTras.Where(e => e.TenNguoiMuon.Contains(tk) || e.Lop.Contains(tk))
                .Select(e => new TheMuonTraVM
            {
                ID = e.Id,
                IDDungCu = e.IdDungCu,
                TenDungCu = model.DungCus.Where(x => x.Id == e.IdDungCu).Select(x => x.Ten).FirstOrDefault(),
                TenNguoiMuon = e.TenNguoiMuon,
                Lop = e.Lop,
                SoLuongMuon = e.SoLuongMuon,
                NgayMuon = e.NgayMuon.ToString(),
                NgayTra = e.NgayTra.ToString(),
                TrangThai = (e.TrangThai == false ? "Đang mượn" : "Đã trả")
            }).ToList();
        }
        public static KetQua Add(TheMuonTraVM l)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            DateTime localDate = DateTime.Now;
            var the = new TheMuonTra
            {                
                Id = l.ID,
                IdDungCu = l.IDDungCu,
                TenNguoiMuon = l.TenNguoiMuon,
                Lop = l.Lop,
                SoLuongMuon = l.SoLuongMuon,
                NgayMuon = localDate,
                TrangThai = false
            };           
            model.TheMuonTras.Add(the);
            model.SaveChanges();
            //Cap nhat sl dung cu kho
            long sldcup = DungCuBLL.getDungCubyID(l.IDDungCu).SoLuong - l.SoLuongMuon;          
            DungCuBLL.UpdateSL(l.IDDungCu, sldcup);
            return KetQua.ThanhCong;
            
        }
        public static KetQua Update(TheMuonTraVM l)
        {
            ModelQLDungCu model = new ModelQLDungCu(); 
            var the = model.TheMuonTras.Where(e => e.Id == l.ID).FirstOrDefault();
            long slbd = the.SoLuongMuon;
            long slls = l.SoLuongMuon;
            the.IdDungCu = l.IDDungCu;
            the.TenNguoiMuon = l.TenNguoiMuon;
            the.Lop = l.Lop;
            the.SoLuongMuon = l.SoLuongMuon;
            the.NgayMuon = DateTime.Parse(l.NgayMuon);            
            the.NgayTra = (!string.IsNullOrEmpty(l.NgayTra) ? DateTime.Parse(l.NgayTra) : the.NgayTra);
            the.TrangThai = (l.TrangThai.Equals("Đang mượn")?false:true);            
            //Cap nhat sl dung cu kho 
            if (slbd > slls)
            {
                DungCuBLL.UpdateSL(l.IDDungCu, DungCuBLL.getDungCubyID(l.IDDungCu).SoLuong + (slbd - slls));
            }
            else if(slbd < slls)
            {
                DungCuBLL.UpdateSL(l.IDDungCu, DungCuBLL.getDungCubyID(l.IDDungCu).SoLuong - (slls - slbd));
            }
            model.SaveChanges();
            return KetQua.ThanhCong;
           
        }
        
        public static void Delete(long id)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var the = model.TheMuonTras.Where(e => e.Id == id).FirstOrDefault();
            if (the != null)
                model.TheMuonTras.Remove(the);            
            else
                throw new Exception("Thẻ mượn trả không tồn tại!");
            model.SaveChanges();
        }
    }
}
