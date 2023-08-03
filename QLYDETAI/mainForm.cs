namespace QLYDETAI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var db = new Database();
            //dgvData.DataSource = db.SelectData(null, null);
        }

    }
}