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
    public partial class EditForm : Form
    {
        private int logId;
        public EditForm()
        {
            InitializeComponent();
        }
        public void SetDetail(ErrorLog log)
        {
            logId = log.Id;

            txtDate.Text = log.Date;
            txtMachine.Text = log.Machine;
            txtProduct.Text = log.Product;
            txtCategory.Text = log.Category;
            txtContent.Text = log.Content;
            txtLocation.Text = log.Location;
            txtAction.Text = log.Action;
            txtNote.Text = log.Note;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var connection = new Microsoft.Data.Sqlite.SqliteConnection(DbConfig.ConnectionString))
            {
                connection.Open();

                string updateQuery = @"UPDATE error_log
                                        SET machine = @machine, product = @product, category = @category,
                                            content = @content, location = @location, action = @action, note = @note
                                        WHERE id = @id";

                using (var command = new SqliteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@machine", txtMachine.Text);
                    command.Parameters.AddWithValue("@product", txtProduct.Text);
                    command.Parameters.AddWithValue("@category", txtCategory.Text);
                    command.Parameters.AddWithValue("@content", txtContent.Text);
                    command.Parameters.AddWithValue("@location", txtLocation.Text);
                    command.Parameters.AddWithValue("@action", txtAction.Text);
                    command.Parameters.AddWithValue("@note", txtNote.Text);
                    command.Parameters.AddWithValue("@id", logId);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("更新しました。");
            this.Close();
        }
    }
}
