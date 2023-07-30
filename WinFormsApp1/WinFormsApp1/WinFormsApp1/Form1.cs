using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region peoperties
        private string filePath = "data.xml";

        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion

        public Form1()
        {
            InitializeComponent();
            //-------------------------------THỦY TỔ LẬP TRÌNH ĐỨC ĐÃ THÊM-------------------------------------
            try
            {
                Job = DeserializeFromXML(filePath) as PlanData;
            }
            catch
            {
                SetDefaultJob();
            }
            //-------------------------------------------------------------------------------------------------
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpkDate.CustomFormat = "dd/MM/yyyy"; // Hoặc để null nếu muốn sử dụng giá trị mặc định
            dtpkDate.ValueChanged += dtpkDate_ValueChanged; // Đăng ký sự kiện ValueChanged của DateTimePicker
            Matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
            for (int i = 0; i < Cons.Column; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.NgayTrongTuan; j++)
                {
                    Button btn = new Button() { Width = Cons.DateButtonWidth, Height = Cons.DateButtonHeight };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + Cons.Margin, oldbtn.Location.Y);
                    btn.Click += Btn_Click;// ĐỨC THÊM!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    pnMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, oldbtn.Location.Y + Cons.DateButtonHeight) };
            }
            foreach (List<Button> buttonRow in Matrix)
            {
                foreach (Button btn in buttonRow)
                {
                    btn.Click += Click_Color; // Nhan nut thi to mau
                }
            }
            SetDefaultDay(); //Dat ngay mac dinh
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }


        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || (date.Year % 400 == 0))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                default:
                    return 30;
            }
        }

        private Button CheckColor;
        private void Click_Color(object sender, EventArgs e)
        {

            if (CheckColor != null)
            {
                CheckColor.BackColor = Color.WhiteSmoke;
            }
            Button ClickColor = (Button)sender;
            //Ngoai thang thi khong to mau  
            if (string.IsNullOrEmpty(ClickColor.Text))
            {
                return;
            }

            ClickColor.BackColor = Color.Aqua;
            CheckColor = ClickColor;

            int day = int.Parse(CheckColor.Text);
            DateTime useDate = new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, day);

            if (KiemTraNgay(useDate, DateTime.Now))
            {
                ClickColor.BackColor = Color.Aqua;
                CheckColor = ClickColor;
            }
        }

        private void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                // Nếu ngày đang xét là ngày hiện tại thì bôi xanh nền
                if (KiemTraNgay(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Orange;
                }

                if (KiemTraNgay(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                    CheckColor = btn;

                }
                if (column >= 6)
                {
                    line++;
                }
                // Cập nhật biến useDate trong vòng lặp để xử lý chính xác việc chuyển đổi giữa các tháng
                useDate = useDate.AddDays(1);
            }
        }
        // hàm so sánh ngày
        bool KiemTraNgay(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        private void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        private void SetDefaultDay() => dtpkDate.Value = DateTime.Now;
        // thoát chương trình 
        private void Thoat_Click(object sender, EventArgs e)
        {
            if (XacNhanThoatChuongTrinh.ConfirmExit())
            {
                Application.ExitThread();
            }
        }
        // đăng xuất 
        private void DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
        }

        //chuyển sang tháng tiếp theo
        private void btnnext_Click(object sender, EventArgs e)
        {
            // Tăng tháng của DateTimePicker lên 1 đơn vị
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);

            // Cập nhật lại lịch cho tháng mới
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }
        // lùi lại 1 tháng
        private void btnPreviours_Click(object sender, EventArgs e)
        {
            // Giảm tháng của DateTimePicker xuống 1 đơn vị
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);

            // Cập nhật lại lịch cho tháng mới
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }
        // hiển thị ngày hôm nay
        private void button1_Click(object sender, EventArgs e)
        {
            SetDefaultDay();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        // Hàm xử lý sự kiện FormClosing để xác nhận việc thoát chương trình khi người dùng ấn nút "X" hoặc sử dụng tổ hợp phím Alt + F4.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu người dùng đang đóng Form1 bằng cách nhấp nút "X"
            // thì không hiển thị hội thoại xác nhận và đóng form mà không hỏi gì thêm.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = !XacNhanThoatChuongTrinh.ConfirmExit();
            }
            SerializeToXML(Job, filePath);
        }
        
        //---------------------------------------------ĐỨC THÊM VÔ FORM 1---------------------------------------------------------------------
        // Lấy để xài danh sách các PlanItem(sự kiện)
        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        // Hàm SerializeToXML được sử dụng để lưu trữ một đối tượng vào một tệp XML
        private void SerializeToXML(object data, string filePath)
        {
            // Tạo một luồng để ghi dữ liệu vào tệp
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            // Tạo một đối tượng XmlSerializer để chuyển đổi đối tượng thành XML
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            // Chuyển đổi đối tượng thành XML và ghi nó vào luồng
            sr.Serialize(fs, data);

            // Đóng luồng
            fs.Close();
        }

        // Hàm DeserializeFromXML được sử dụng để đọc một đối tượng từ một tệp XML
        private object DeserializeFromXML(string filePath)
        {
            // Tạo một luồng để đọc dữ liệu từ tệp
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                // Tạo một đối tượng XmlSerializer để chuyển đổi XML thành một đối tượng
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));

                // Đọc dữ liệu từ luồng và chuyển đổi nó thành một đối tượng
                object result = sr.Deserialize(fs);
                // Đóng luồng
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                // Nếu có lỗi xảy ra, đóng luồng và ném ra ngoại lệ
                fs.Close();
                throw new NotImplementedException();
            }
        }
        //<<<<<<<<<<<<<<<<<<<<<<<ĐỨC THÊM DỮ LIỆU MẪU>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            // thêm câu trúc data thứ 1 đã thành công thêm vô file data.xml!
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm thôi 1",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
            // thêm cấu trúc data thứ 2 xem thử có thêm vô file xml không 
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(6, 0),
                ToTime = new Point(8, 0),
                Job = "Thử nghiệm thôi 2",
                Status = PlanItem.ListStatus[(int)EPlanItem.DONE]
            });
            // thêm cấu trúc data thứ 3 xem thử có thêm vô file xml không 
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(12, 2),// Date = new DateTime(2023, 7, 29, 18, 13, 0),
                ToTime = new Point(13, 3),
                Job = "Thử nghiệm thôi 3",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
            // thêm cấu trúc data thứ 4 xem thử thuộc tính date có lỗi hay không?
            Job.Job.Add(new PlanItem()
            {
                Date = new DateTime(2023, 7, 30, 18, 13, 0),// ngày 30/7/2023 lúc 18:13 
                FromTime = new Point(12, 2),
                ToTime = new Point(13, 3),
                Job = "Thử nghiệm nhập Date bằng cơm",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn vào nút Btn
        private void Btn_Click(object? sender, EventArgs e)
        {
            // Kiểm tra xem nội dung của nút Btn có rỗng hay không
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;

            // Tạo một đối tượng mới của lớp DailyPlan với ngày được đặt bằng ngày được chọn từ nút Btn và thuộc tính Job
            DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);

            // Hiển thị đối tượng DailyPlan dưới dạng một cửa sổ modal
            daily.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan();
            thongTinCaNhan.Show();
            this.Hide();
        }
    }
}