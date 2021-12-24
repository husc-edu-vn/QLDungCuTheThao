using QLDungCuTheThao.DAL;
using QLDungCuTheThao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDungCuTheThao.BLL
{
    internal class LoaiDungCuBLL
    {
        public static List<LoaiDungCu> getList()
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.LoaiDungCus.OrderByDescending(e => e.Id).ToList();
        }
        public static List<LoaiDungCuVM> getListVM()
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.LoaiDungCus.Select(e => new LoaiDungCuVM
            {
                ID = e.Id,
                TenLoai = e.TenLoai,
                SoDungCu = e.DungCus.Count,
                MoTa = e.MoTa
            }).ToList();
        }
        public static List<LoaiDungCuVM> getListVMbySearch(String tk)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            return model.LoaiDungCus.Where(e => e.TenLoai.Contains(tk))
                .Select(e => new LoaiDungCuVM
            {
                ID = e.Id,
                TenLoai = e.TenLoai,
                SoDungCu = e.DungCus.Count,
                MoTa = e.MoTa
            }).ToList();
        }
        public static KetQua Add(LoaiDungCuVM l)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var loai = model.LoaiDungCus.Where(e => e.TenLoai == l.TenLoai).FirstOrDefault();
            if (loai != null)
            {
                return KetQua.TenTrung;
            }
            else
            {
                loai = new LoaiDungCu
                {
                    Id = l.ID,
                    TenLoai = l.TenLoai,
                    MoTa = l.MoTa                    
                };
                model.LoaiDungCus.Add(loai);
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua Update(LoaiDungCuVM l)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var loai = model.LoaiDungCus.Where(e => e.Id != l.ID && e.TenLoai == l.TenLoai).FirstOrDefault();
            if (loai != null)
            {
                return KetQua.TenTrung;
            }
            else
            {
                loai = model.LoaiDungCus.Where(e => e.Id == l.ID).FirstOrDefault();
                loai.TenLoai = l.TenLoai;
                loai.MoTa = l.MoTa;
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static void Delete(long id)
        {
            ModelQLDungCu model = new ModelQLDungCu();
            var loai = model.LoaiDungCus.Where(e => e.Id == id).FirstOrDefault();
            if (loai != null && loai.DungCus.Count == 0)
                model.LoaiDungCus.Remove(loai);
            else if (loai != null && loai.DungCus.Count != 0)
                throw new Exception("Loại đang có dụng cụ. Không thể xoá!");
            else
                throw new Exception("Loại không tồn tại!");
            model.SaveChanges();
        }
    }
}
