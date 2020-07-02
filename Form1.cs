using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KeepNote
{
    public partial class keep_note : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GSP-LAP-009\source\repos\KeepNote\Db_reminder.mdf;Integrated Security=True"); 
public keep_note()
        {
            InitializeComponent();
        }

        public void fillGridView() {
            try
            {
                if (sql_con.State == ConnectionState.Closed)
                    sql_con.Open();
                SqlDataAdapter sql_da = new SqlDataAdapter("VieworSearch", sql_con);
                sql_da.SelectCommand.CommandType = CommandType.StoredProcedure;
                sql_da.SelectCommand.Parameters.AddWithValue("@Title", text_search.Text.Trim());
                DataTable dtl = new DataTable();
                sql_da.Fill(dtl);
                GridView.DataSource = dtl;
                sql_con.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message,"Error Message");
            }
            

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_save.Text == "Save") {
                    if (sql_con.State == ConnectionState.Closed)
                        sql_con.Open();
                    SqlCommand sql_cmd = new SqlCommand("AddorEdit", sql_con);
                    sql_cmd.CommandType = CommandType.StoredProcedure;
                    sql_cmd.Parameters.AddWithValue("@mode", "Add");
                    sql_cmd.Parameters.AddWithValue("@Title", text_title.Text.Trim());
                    sql_cmd.Parameters.AddWithValue("@Note", text_note.Text.Trim());
                    sql_cmd.ExecuteNonQuery();
                    MessageBox.Show("Reminder saved successfully", "Successful Save");
                }
                else if (button_save.Text=="Update") {
                    if (sql_con.State == ConnectionState.Closed)
                        sql_con.Open();
                    SqlCommand sql_cmd = new SqlCommand("AddorEdit", sql_con);
                    sql_cmd.CommandType = CommandType.StoredProcedure;
                    sql_cmd.Parameters.AddWithValue("@mode", "Edit");
                    sql_cmd.Parameters.AddWithValue("@Title", text_title.Text.Trim());
                    sql_cmd.Parameters.AddWithValue("@Note", text_note.Text.Trim());
                    sql_cmd.ExecuteNonQuery();
                    MessageBox.Show("Reminder Updated successfully", "Successful Updated");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally {
                sql_con.Close();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try {
                fillGridView();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error Message");
            }
            
        }

        public void reset() {
            text_title.Text = "";
            text_note.Text = "";
            button_save.Text = "Save";
            text_search.Text = "";
            button_delete.Enabled = false;
        }
        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow.Index != -1)
            {
                text_title.Text = GridView.CurrentRow.Cells[0].Value.ToString();
                text_note.Text = GridView.CurrentRow.Cells[1].Value.ToString();
                button_save.Text = "Update";
                button_delete.Enabled = true;
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            try
            {
                reset();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql_con.State == ConnectionState.Closed)
                    sql_con.Open();
                SqlCommand sql_cmd = new SqlCommand("Delete", sql_con);
                sql_cmd.CommandType = CommandType.StoredProcedure;
                
                sql_cmd.Parameters.AddWithValue("@Title", text_title.Text.Trim());
                //sql_cmd.Parameters.AddWithValue("@Note", text_note.Text.Trim());
                sql_cmd.ExecuteNonQuery();
                MessageBox.Show("Reminder Deleted successfully", "Successful Deletion");
                reset();
                fillGridView();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error Message");
            }
        }
    }
}
