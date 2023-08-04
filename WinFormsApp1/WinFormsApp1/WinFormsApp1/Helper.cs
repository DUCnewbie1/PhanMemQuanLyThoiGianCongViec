using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//Dùng lớp này thì khỏi phải tạo connection string cho mỗi class 
namespace WinFormsApp1
{
    public class Helper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
