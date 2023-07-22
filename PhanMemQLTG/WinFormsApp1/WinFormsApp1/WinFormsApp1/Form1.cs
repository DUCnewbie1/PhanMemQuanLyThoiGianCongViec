using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region peoperties
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
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbTo_Click(object sender, EventArgs e)
        {

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
                    pnMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, oldbtn.Location.Y + Cons.DateButtonHeight) };
            }
            SetDefaultDay();
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

        // hàm thực thi lệnh thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // hàm đăng xuất 
        private void DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
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
            Application.Exit();
        }
    }
}