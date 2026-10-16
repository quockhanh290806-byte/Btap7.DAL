using QLSV.BLL;

namespace QuanLySinhVien.GUI
{
    public partial class Form1 : Form
    {
        private readonly StudentBLL _studentBLL = new StudentBLL();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            try
            {
                // Tự động co giãn cột vừa khít với bảng DataGridView
                dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Lấy dữ liệu từ tầng BLL và đổ vào DataGridView
                dgvSinhVien.DataSource = _studentBLL.GetStudentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
