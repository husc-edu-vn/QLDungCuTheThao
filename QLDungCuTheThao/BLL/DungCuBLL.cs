using QLDungCuTheThao.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDungCuTheThao.BLL
{
    public enum KetQua
    {
        ThanhCong, ThatBai, TenTrung
    }
    internal class DungCuBLL
    {
        public static List<DungCu> getList()
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.DungCus.OrderByDescending(e => e.Id).ToList();
        }     
        
        public static List<DungCu> getListbySearch(String tk)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.DungCus.Where(e => e.Ten.Contains(tk)).ToList();
        }
        public static KetQua Add(DungCu dc)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var dungcu = model.DungCus.Where(e => e.Ten == dc.Ten).FirstOrDefault();
            if (dungcu != null)
            {
                return KetQua.TenTrung;
            }
            else
            {
                DateTime localDate = DateTime.Now;
                dungcu = new DungCu
                {
                    Ten = dc.Ten,
                    Gia = dc.Gia,
                    SoLuong = dc.SoLuong,
                    ThuongHieu = dc.ThuongHieu,
                    NgaySX = dc.NgaySX,
                    MoTa = dc.MoTa,
                    NgayThem = localDate,                    
                    AnhMoTa = dc.AnhMoTa
                };
                model.DungCus.Add(dungcu);
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua Update(DungCu dc)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var dungcu = model.DungCus.Where(e => e.Id != dc.Id && e.Ten == dc.Ten).FirstOrDefault();
            if (dungcu != null)
            {
                return KetQua.TenTrung;
            }
            else
            {
                DateTime localDate = DateTime.Now;
                dungcu = model.DungCus.Where(e => e.Id == dc.Id).FirstOrDefault();
                dungcu.Ten = dc.Ten;    
                dungcu.Gia = dc.Gia;    
                dungcu.SoLuong = dc.SoLuong;
                dungcu.ThuongHieu = dc.ThuongHieu;
                dungcu.NgaySX = dc.NgaySX;
                dungcu.MoTa = dc.MoTa;               
                dungcu.NgayCapNhat = localDate;
                dungcu.AnhMoTa = dc.AnhMoTa;
                
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static void Delete(long id)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var dungcu = model.DungCus.Where(e => e.Id == id).FirstOrDefault();
            if (dungcu != null)
                model.DungCus.Remove(dungcu);           
            else
                throw new Exception("Dụng cụ không tồn tại!");
            model.SaveChanges();
        }
    }
}
