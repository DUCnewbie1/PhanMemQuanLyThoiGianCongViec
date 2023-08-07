using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Chứa danh sách các PlanItem(sự kiện) chắc thế :V 
namespace WinFormsApp1
{
    [Serializable] // Thuộc tính cho phép lớp này được tuần tự hóa
    public class PlanData
    {
        // Biến lưu trữ danh sách các mục kế hoạch
        private List<PlanItem> job;

        // Thuộc tính cho phép truy cập và thay đổi giá trị của biến job
        public List<PlanItem> Job
        {
            get { return job; }
            set { job = value; }
        }
    }
}
