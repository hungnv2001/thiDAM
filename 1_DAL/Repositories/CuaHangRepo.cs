using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repositories
{
    public class CuaHangRepo
    {
        FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context db;
        public CuaHangRepo()
        {
            db = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
        }
        public List<CuaHang> GetAll()
        { 
            return db.CuaHangs.ToList();
        }
        public bool Delete(CuaHang hang)
        {
            try
            {
                hang = db.CuaHangs.FirstOrDefault(p => p.Id == hang.Id);
                db.CuaHangs.Remove(hang);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Add(CuaHang hang)
        {
            try
            {
                
                db.CuaHangs.Add(hang);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
