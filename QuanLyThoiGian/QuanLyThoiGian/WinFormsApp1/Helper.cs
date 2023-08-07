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
        // Phương thức hiển thị hộp thoại xác nhận thoát chương trình
        public static bool ConfirmExit()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        //Phương thức hiển thị hộp thoại xác nhận quay lại chương trình
        public static bool ConfirmBack()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn trở lại giao diện chính?", "Xác nhận trở lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        //Các lệnh giới hạn kí tự
        public static KiemTraNhapChuoi HoTextBoxHandler = new KiemTraNhapChuoi(20);
        public static KiemTraNhapChuoi TenTextBoxHandler = new KiemTraNhapChuoi(20);
        public static KiemTraNhapChuoi DiaChiTextBoxHandler = new KiemTraNhapChuoi(40);
        public static KiemTraNhapChuoi TKTextBoxHandler = new KiemTraNhapChuoi(20);
        public static KiemTraNhapChuoi MKTextBoxHandler = new KiemTraNhapChuoi(20);
        public static KiemTraNhapChuoi MKCheckTextBoxHandler = new KiemTraNhapChuoi(20);
        //bool kiểm tra độ dài kí tự
        public static bool TextThayDoi = false;
        public static bool HoVuotQuaDoDaiMax = false;
        public static bool TenVuotQuaDoDaiMax = false;
        public static bool DiaChiVuotQuaDoDaiMax = false;
        public static bool TKVuotQuaDoDaiMax = false;
        public static bool MKVuotQuaDoDaiMax = false;
        public static bool MKCheckVuotQuaDoDaiMax = false;
    }
}
