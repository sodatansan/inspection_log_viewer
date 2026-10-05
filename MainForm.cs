using System.IO;

namespace inspection_log_viewer
{
    public partial class MainForm : Form
    {
        List<ErrorLog> allLogs = new List<ErrorLog>();

        public MainForm()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromDatabase();
        }
        private void LoadFromDatabase()
        {
            using (var connection = new Microsoft.Data.Sqlite.SqliteConnection(DbConfig.ConnectionString))
            {
                connection.Open();
                string query = "SELECT id, datetime, machine, product, category, location, content, action, note FROM error_log";

                using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ErrorLog log = new ErrorLog();
                            log.Id = reader.GetInt32(0);
                            log.Date = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            log.Machine = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            log.Product = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            log.Category = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            log.Location = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            log.Content = reader.IsDBNull(6) ? "" : reader.GetString(6);
                            log.Action = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            log.Note = reader.IsDBNull(8) ? "" : reader.GetString(8);

                            allLogs.Add(log);
                        }
                    }
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 検索処理
            string keyword = txtKeyword.Text;   // テキストボックスの中身を取得

            dgvResults.Rows.Clear();    // 前回の検索結果をクリア
            dgvResults.RowHeadersVisible = false;  // 左の余白を消す

            // 最初に列を作る
            if (dgvResults.Columns.Count == 0)
            {
                dgvResults.Columns.Add("Id", "ID");
                dgvResults.Columns.Add("Date", "日時");
                dgvResults.Columns.Add("Machine", "機械名");
                dgvResults.Columns.Add("Product", "製品名");
                dgvResults.Columns.Add("Category", "種別");
                dgvResults.Columns.Add("Location", "場所");
                dgvResults.Columns.Add("Content", "内容");
                dgvResults.Columns.Add("Action", "対処法");
                dgvResults.Columns.Add("Note", "備考");
            }

            foreach (ErrorLog log in allLogs)
            {
                if (log.Date.Contains(keyword) ||
                    log.Machine.Contains(keyword) ||
                    log.Product.Contains(keyword) ||
                    log.Category.Contains(keyword) ||
                    log.Location.Contains(keyword) ||
                    log.Content.Contains(keyword) ||
                    log.Action.Contains(keyword) ||
                    log.Note.Contains(keyword))

                {
                    int rowIndex = dgvResults.Rows.Add(log.Id, log.Date, log.Machine, log.Product, log.Category, log.Location, log.Content,
                                             log.Action, log.Note);
                    dgvResults.Rows[rowIndex].Tag = log;

                }
            }
            dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);  // 列幅を自動調整
        }
        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ErrorLog log = (ErrorLog)dgvResults.Rows[e.RowIndex].Tag;

                DetailForm detailForm = new DetailForm();
                detailForm.SetDetail(log);
                detailForm.ShowDialog();

                allLogs.Clear();
                LoadFromDatabase();
                btnSearch_Click(sender, e);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ErrorLog newLog = new ErrorLog();
            newLog.Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            newLog.Machine = txtMachine.Text;
            newLog.Product = txtProduct.Text;
            newLog.Category = txtCategory.Text;
            newLog.Location = txtLocation.Text;
            newLog.Content = txtContent.Text;
            newLog.Action = txtAction.Text;
            newLog.Note = txtNote.Text;

            using (var connection = new Microsoft.Data.Sqlite.SqliteConnection(DbConfig.ConnectionString))
            {
                connection.Open();

                string insertQuery = @"INSERT INTO error_log (datetime, machine, product, category,location, content, action, note)
                                VALUES (@datetime, @machine, @product, @category, @location, @content, @action, @note)";

                using (var command = new Microsoft.Data.Sqlite.SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@datetime", newLog.Date);
                    command.Parameters.AddWithValue("@machine", newLog.Machine);
                    command.Parameters.AddWithValue("@product", newLog.Product);
                    command.Parameters.AddWithValue("@category", newLog.Category);
                    command.Parameters.AddWithValue("@location", newLog.Location);
                    command.Parameters.AddWithValue("@content", newLog.Content);
                    command.Parameters.AddWithValue("@action", newLog.Action);
                    command.Parameters.AddWithValue("@note", newLog.Note);

                    command.ExecuteNonQuery();
                }
            }
            allLogs.Clear();
            LoadFromDatabase();
            btnSearch_Click(sender, e);

            MessageBox.Show("登録しました。");

            txtMachine.Text = "";
            txtProduct.Text = "";
            txtCategory.Text = "";
            txtLocation.Text = "";
            txtContent.Text = "";
            txtAction.Text = "";
            txtNote.Text = "";
        }
    }

}
