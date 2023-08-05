using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DailyPlan : Form
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        //Tạo ra một điều khiển chứa các điều khiển con và tự động sắp xếp chúng theo chiều ngang hoặc chiều dọc.
        FlowLayoutPanel fPanel = new FlowLayoutPanel();

        // Phương thức khởi tạo của lớp DailyPlan
        public DailyPlan(DateTime date, PlanData job)
        {
            // Gọi phương thức InitializeComponent để khởi tạo các điều khiển
            InitializeComponent();

            // Khởi tạo các thuộc tính Date và Job với các giá trị tương ứng
            this.Date = date;
            this.Job = job;

            // Thiết lập kích thước của fPanel và thêm nó vào pnlJob
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fPanel);

            // Đặt giá trị của dtpkDate bằng giá trị của thuộc tính Date
            dtpkDate.Value = Date;
        }

        // Phương thức hiển thị danh sách công việc trong ngày được chỉ định
        void ShowJobByDate(DateTime date)
        {
            // Xóa tất cả các điều khiển trong fPanel
            fPanel.Controls.Clear();

            // Kiểm tra xem có công việc nào trong ngày được chỉ định hay không
            if (Job != null && Job.Job != null)
            {
                // Lấy danh sách công việc trong ngày
                List<PlanItem> todayJob = GetJobByDay(date);

                // Thêm từng công việc vào fPanel
                for (int i = 0; i < GetJobByDay(date).Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }
        }

        // Phương thức thêm một công việc vào fPanel
        void AddJob(PlanItem job)
        {
            // Tạo một đối tượng mới của lớp AJob với tham số là job
            AJob aJob = new AJob(job,0);

            // Đăng ký các sự kiện Edited và Deleted của đối tượng AJob với các phương thức xử lý tương ứng
            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleted;

            // Thêm đối tượng AJob vào fPanel
            fPanel.Controls.Add(aJob);
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút mnAddJob
        private void mnAddJob_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng mới của lớp PlanItem với thuộc tính Date được đặt bằng giá trị của dtpkDate.Value
            PlanItem item = new PlanItem() { Date = dtpkDate.Value };

            // Thêm đối tượng này vào danh sách công việc của thuộc tính Job
            Job.Job.Add(item);

            // Gọi phương thức AddJob để hiển thị công việc mới
            AddJob(item);
        }

        // Phương thức lấy danh sách công việc trong ngày được chỉ định
        List<PlanItem> GetJobByDay(DateTime date)
        {
            // Sử dụng phép toán LINQ để lọc ra các công việc có thuộc tính Date trùng với giá trị của tham số date
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        // Phương thức xử lý sự kiện khi người dùng thay đổi giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate
        private void dtpkDate_ValueChanged_1(object sender, EventArgs e)
        {
            // Gọi phương thức ShowJobByDate với giá trị mới của điều khiển nhập liệu để hiển thị danh sách công việc trong ngày mới
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút btnNextDay
        private void btnNextDay_Click_1(object sender, EventArgs e)
        {
            // Cộng giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate thêm một ngày
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút btnPreviousDay
        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            // Trừ giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate đi một ngày
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        // Phương thức xử lý sự kiện Deleted của một đối tượng AJob
        void aJob_Deleted(object sender, EventArgs e)
        {
            // Lấy đối tượng AJob phát sinh sự kiện
            AJob uc = sender as AJob;

            // Lấy đối tượng công việc từ thuộc tính Job của đối tượng AJob
            PlanItem job = uc.Job;

            // Xóa đối tượng AJob khỏi fPanel
            fPanel.Controls.Remove(uc);

            // Xóa đối tượng công việc khỏi danh sách công việc của thuộc tính Job
            Job.Job.Remove(job);
        }

        // Phương thức xử lý sự kiện Edited của một đối tượng AJob
        void aJob_Edited(object sender, EventArgs e)
        {
            // Hiện tại phương thức này chưa được triển khai và không có chức năng gì
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút mnsToday
        private void mnsToday_Click(object sender, EventArgs e)
        {
            // Đặt giá trị của điều khiển nhập liệu ngày tháng năm dtpkDate bằng ngày giờ hiện tại
            dtpkDate.Value = DateTime.Now;
        }
        // Nút X để thoát và trở lại giao diện chương trình
    }
}
