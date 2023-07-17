using _1_DAL.Models;
using _1_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2_BUS.Services
{
    public class CuaHangService
    {
        CuaHangRepo repo;
        public CuaHangService()
        {
            repo = new CuaHangRepo();
        }
        public string CreateName(string name)
        {

            try
            {
                string[] arrName = name.ToLower().Split(" ");
                name = "";
                for (int i = 0; i < arrName.Length; i++)
                {
                    if (arrName[i].Length == 0)
                    {
                        break;
                    }
                    name += arrName[i][0];
                }
              
                return name;
            }
            catch (Exception)
            {

                return "";
            }
        }
        public List<CuaHang> GetAll()
        {
            return repo.GetAll();
        }
        public List<CuaHang> Search(string ten)
        {
            try
            {
                return GetAll().Where(p => p.Ten == ten).ToList();
            }
            catch (Exception)
            {
                return new List<CuaHang>();
                
            }
        }
        public bool Add(CuaHang hang)
        {
            int number = 0;
            string nameGoc = hang.Ma;

            while (GetAll().FirstOrDefault(p => p.Ma == hang.Ma) != null)
            {
                number++;
                hang.Ma = nameGoc;
                hang.Ma += number.ToString();
            };
            return repo.Add(hang);
        }
        public bool Delete(CuaHang hang)
        {
            return repo.Delete(hang);
        }
    }
}
