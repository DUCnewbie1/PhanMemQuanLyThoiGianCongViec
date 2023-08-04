using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
// để quản lý các mục kế hoạch (sự kiện) trong lịch.
namespace WinFormsApp1
{
     public class PlanItem
    {
        // Biến lưu trữ ngày tháng của mục kế hoạch
        private DateTime date;

        // Thuộc tính cho phép truy cập và thay đổi giá trị của biến date
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        // Biến lưu trữ công việc của mục kế hoạch
        private string job;

        // Thuộc tính cho phép truy cập và thay đổi giá trị của biến job
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        // Biến lưu trữ thời gian bắt đầu của mục kế hoạch
        private Point fromTime;

        // Thuộc tính cho phép truy cập và thay đổi giá trị của biến fromTime
        public Point FromTime
        {
            get { return fromTime; }
            set { fromTime = value; }
        }

        // Biến lưu trữ thời gian kết thúc của mục kế hoạch
        private Point toTime;

        // Thuộc tính cho phép truy cập và thay đổi giá trị của biến toTime
        public Point ToTime
        {
            get { return toTime; }
            set { toTime = value; }
        }

        // Biến lưu trữ trạng thái của mục kế hoạch
        private string status;

        // Thuộc tính cho phép truy cập và thay đổi giá trị của biến status
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Danh sách tĩnh chứa các trạng thái có thể có của một mục kế hoạch
        public static List<string> ListStatus = new List<string>() { "Đã xong", "Đang làm", "Sắp tới", "Bỏ lỡ" };
    }

    // Kiểu liệt kê định nghĩa các giá trị cho các trạng thái của một mục kế hoạch
    public enum EPlanItem
    {
        DONE,
        DOING,
        COMING,
        MISSED
    }
}
