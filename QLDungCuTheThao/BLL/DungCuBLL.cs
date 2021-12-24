using QLDungCuTheThao.DAL;
using QLDungCuTheThao.ViewModel;
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
        public static List<DungCuVM> getListVM()
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.DungCus.Select(e => new DungCuVM
            {
                ID = e.Id,
                IdLoai = e.IdLoai,
                TenLoai = model.LoaiDungCus.Where(x => x.Id == e.IdLoai).Select(x => x.TenLoai).FirstOrDefault(),
                Ten = e.Ten,
                SoLuong = e.SoLuong,
                MoTa = e.MoTa,
                NgayThem = e.NgayThem.ToString(),
                NgayCapNhat = e.NgayCapNhat.ToString(),
                AnhMoTa = e.AnhMoTa
            }).ToList();
        }

        public static DungCu getDungCubyID(long iddc)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.DungCus.Where(e => e.Id == iddc).FirstOrDefault();
        }
        public static List<DungCuVM> getListVMbyID(long idloai)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.DungCus.Where(e => e.IdLoai== idloai)
                .Select(e => new DungCuVM
            {
                ID = e.Id,
                IdLoai = e.IdLoai,
                TenLoai = model.LoaiDungCus.Where(x => x.Id == e.IdLoai).Select(x => x.TenLoai).FirstOrDefault(),
                Ten = e.Ten,
                SoLuong = e.SoLuong,
                MoTa = e.MoTa,
                NgayThem = e.NgayThem.ToString(),
                NgayCapNhat = e.NgayCapNhat.ToString(),
                AnhMoTa = e.AnhMoTa
            }).ToList();
        }

        public static List<DungCuVM> getListbySearch(String tk)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.DungCus.Where(e => e.Ten.Contains(tk)).Select(e => new DungCuVM
            {
                ID = e.Id,
                IdLoai = e.IdLoai,
                TenLoai = model.LoaiDungCus.Where(x => x.Id == e.IdLoai).Select(x => x.TenLoai).FirstOrDefault(),
                Ten = e.Ten,
                SoLuong = e.SoLuong,
                MoTa = e.MoTa,
                NgayThem = e.NgayThem.ToString(),
                NgayCapNhat = (e.NgayCapNhat != null ? e.NgayCapNhat.ToString() : "Đang mượn"),
                AnhMoTa = e.AnhMoTa
            }).ToList();
        }
        public static KetQua Add(DungCuVM dc)
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
                    IdLoai = dc.IdLoai,                    
                    Ten = dc.Ten,
                    SoLuong = dc.SoLuong,
                    MoTa = dc.MoTa,
                    NgayThem = localDate,                     
                    AnhMoTa = dc.AnhMoTa
                };
                model.DungCus.Add(dungcu);
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua Update(DungCuVM dc)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var dungcu = model.DungCus.Where(e => e.Id != dc.ID && e.Ten == dc.Ten).FirstOrDefault();
            if (dungcu != null)
            {
                return KetQua.TenTrung;
            }
            else
            {
                DateTime localDate = DateTime.Now;
                dungcu = model.DungCus.Where(e => e.Id == dc.ID).FirstOrDefault();
                dungcu.IdLoai = dc.IdLoai;
                dungcu.Ten = dc.Ten;                    
                dungcu.SoLuong = dc.SoLuong;               
                dungcu.MoTa = dc.MoTa;               
                dungcu.NgayCapNhat = localDate;
                dungcu.AnhMoTa = dc.AnhMoTa;
                
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua UpdateSL(long iddc, long sl)
        {
            ModelQLDungCu model = new ModelQLDungCu();  
            var dungcu = model.DungCus.Where(e => e.Id == iddc).FirstOrDefault();            
            dungcu.SoLuong = sl;  
            model.SaveChanges();
            return KetQua.ThanhCong;
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
