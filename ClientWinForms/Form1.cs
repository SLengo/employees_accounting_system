using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace ClientWinForms
{
    public partial class Form1 : Form
    {
        public int ActionWithTableState = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionWithTableState = 1;
            this.Enabled = false;
            Program.mySecondForm.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Program.mySettingsForm.Show();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionWithTableState = 2;
            this.Enabled = false;
            Program.mySecondForm.Show();
        }

        public async void showAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkingPanel.Visible = true;
            try
            {
                List<EmployeeJson> json = null;
                using (HttpClient httpClient = new HttpClient())
                {
                    var uri = Program.mySettingsForm.URL + "/api/employees/get-all";
                    var response = await httpClient.GetAsync(uri);
                    string JsonFromResponse = await response.Content.ReadAsStringAsync();

                    List<JsonResponceFromServer> jsonCode = JsonConvert.DeserializeObject<List<JsonResponceFromServer>>(JsonFromResponse);
                    if (jsonCode.Count > 0)
                    {
                        if (jsonCode[0].State == "101")
                        {
                            MessageBox.Show("Error finding\n Message: " + jsonCode[0].Message, "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            WorkingPanel.Visible = false;
                            return;
                        }
                    }


                    json = JsonConvert.DeserializeObject<List< EmployeeJson >>(JsonFromResponse);
                    dataGridView1.DataSource = json;
                    int widthColumn = dataGridView1.Width / dataGridView1.ColumnCount - 5;
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        item.Width = widthColumn;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Server is unavaliable", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                WorkingPanel.Visible = false;
            }
        }
        private async void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select row with employee", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WorkingPanel.Visible = true;
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var values = new Dictionary<string, string>
                                {
                                   { "id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString() }
                                };
                        var content = new FormUrlEncodedContent(values);
                        var response = await client.PostAsync(Program.mySettingsForm.URL + "/api/employees/delete", content);
                        var responseString = await response.Content.ReadAsStringAsync();

                        responseString = Newtonsoft.Json.Linq.JToken.Parse(responseString).ToString();
                        Newtonsoft.Json.Linq.JToken token = Newtonsoft.Json.Linq.JObject.Parse(responseString);

                        if ((string)token.SelectToken("state") == "100")
                        {
                            dataGridView1.ClearSelection();
                            MessageBox.Show("Employee is deleted", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error adding\n Message: " + (string)token.SelectToken("message"), "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Server is unavaliable", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    showAllEmployeeToolStripMenuItem_Click(sender,e);
                }
                WorkingPanel.Visible = false;
            }
        }


        private void prepearDataGridView<T>(IEnumerable<T> iQ)
        {
            System.Data.DataTable People = new System.Data.DataTable("People");

            DataColumn c = null;
            foreach (var item in iQ)
            {
                foreach (System.Reflection.PropertyInfo item1 in item.GetType().GetProperties())
                {
                    c = new DataColumn(item1.Name);
                    People.Columns.Add(c);
                }
                break;
            }
            DataRow currentRow = null;
            foreach (var item in iQ)
            {
                currentRow = People.NewRow();
                foreach (System.Reflection.PropertyInfo item1 in item.GetType().GetProperties())
                {
                    currentRow[item1.Name] = item1.GetValue(item, null);
                }
                People.Rows.Add(currentRow);
            }

            dataGridView1.DataSource = People;
            int widthColumn = dataGridView1.Width / dataGridView1.ColumnCount - 5;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.Width = widthColumn;
            }
        }

    }
}
