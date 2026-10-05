using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inspection_log_viewer
{
    public partial class DetailForm : Form
    {
        private ErrorLog currentLog;

        public DetailForm()
        {
            InitializeComponent();
        }

        public void SetDetail(ErrorLog log)
        {
            currentLog = log;
            lblDetail.Text = "日時　 : " + log.Date + "\n" +
                             "機械名 : " + log.Machine + "\n" +
                             "製品　 : " + log.Product + "\n" +
                             "種別　 : " + log.Category + "\n" +
                             "場所　 : " + log.Location + "\n" +
                             "内容　 : " + log.Content + "\n" +                    
                             "対処法 : " + log.Action + "\n" +
                             "備考　 : " + log.Note;
        }

        private void RefreshFromDatabase()
        {
            using (var connection = new Microsoft.Data.Sqlite.SqliteConnection(DbConfig.ConnectionString))
            {
                connection.Open();
                string query = "SELECT id, datetime, machine, product, category, location, content, action, note FROM error_log WHERE id = @id";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", currentLog.Id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ErrorLog updated = new ErrorLog();
                            updated.Id = reader.GetInt32(0);
                            updated.Date = reader.GetString(1);
                            updated.Machine = reader.GetString(2);
                            updated.Product = reader.GetString(3);
                            updated.Category = reader.GetString(4);                          
                            updated.Location = reader.GetString(5);
                            updated.Content = reader.GetString(6);
                            updated.Action = reader.GetString(7);
                            updated.Note = reader.GetString(8);

                            SetDetail(updated);
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.SetDetail(currentLog);
            editForm.ShowDialog();

            RefreshFromDatabase();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "このデータを削除しますか?この操作は元に戻せません。",
            "削除の確認",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning );

            if (result == DialogResult.Yes)
            {
                using (var connection = new Microsoft.Data.Sqlite.SqliteConnection(DbConfig.ConnectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM error_log WHERE id = @id";

                    using (var command = new Microsoft.Data.Sqlite.SqliteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", currentLog.Id);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("削除しました。");
                this.Close();  // Form2を閉じて、一覧(Form1)に戻る
            }
        }
    }
}

