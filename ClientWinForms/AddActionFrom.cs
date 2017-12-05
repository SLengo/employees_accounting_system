using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using Newtonsoft.Json;

namespace ClientWinForms
{
    public partial class AddActionFrom : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        

        public AddActionFrom()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Panel)
                {
                    foreach(Control cntr in item.Controls)
                    if (cntr is TextBox || cntr is ComboBox)
                    {
                            cntr.Text = "";
                    }
                }
            }
            this.Hide();
            Program.myMainForm.Enabled = true;
        }

        private void AddActionFrom_VisibleChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
            switch (Program.myMainForm.ActionWithTableState)
            {
                case 1:
                    {
                        DateBirthdayCheckBox.Visible = false;
                        actionSignlabel.Text = "Employee adding";
                        break;
                    }
                case 2:
                    {
                        DateBirthdayCheckBox.Visible = true;
                        actionSignlabel.Text = "Employee seeking";
                        break;
                    }
            }
            
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (Program.myMainForm.ActionWithTableState == 1)
            {
                if (nametextBox.Text == "" ||
                   sernametextBox.Text == "" ||
                   phonetextBox.Text == "" ||
                   emailtextBox.Text == "" ||
                   SexComboBox.Text == "" ||
                   dateOfBirthdaydateTimePicker.Text == "" ||
                   agetextBox.Text == "")
                {
                    MessageBox.Show("Fill all filels!", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    WorkingPanel.Visible = true;
                    int timestampDateOfBirthday = (int)(dateOfBirthdaydateTimePicker.Value.Date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    var values = new Dictionary<string, string>
                                {
                                   { "name", nametextBox.Text },
                                   { "surname", sernametextBox.Text },
                                   { "phone", phonetextBox.Text },
                                   { "email", emailtextBox.Text },
                                   { "sex", SexComboBox.Text },
                                   { "age", agetextBox.Text },
                                   { "date_of_birthday", Convert.ToString(timestampDateOfBirthday) },
                                };
                    var content = new FormUrlEncodedContent(values);
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            var response = await client.PostAsync(Program.mySettingsForm.URL + "/api/employees/create", content);
                            var responseString = await response.Content.ReadAsStringAsync();
                            responseString = Newtonsoft.Json.Linq.JToken.Parse(responseString).ToString();

                            Newtonsoft.Json.Linq.JToken token = Newtonsoft.Json.Linq.JObject.Parse(responseString);

                            if ((string)token.SelectToken("state") == "100")
                            {
                                Program.myMainForm.showAllEmployeeToolStripMenuItem_Click(sender,e);
                                MessageBox.Show("Employee is added", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    WorkingPanel.Visible = false;
                    cancelBtn_Click(sender, e);
                }
            }
            else if (Program.myMainForm.ActionWithTableState == 2)
            {
                WorkingPanel.Visible = true;
                try
                {
                    List<EmployeeJson> json = null;
                    int timestampDateOfBirthday = 0;
                    if (DateBirthdayCheckBox.Checked)
                    {
                        timestampDateOfBirthday = (int)(dateOfBirthdaydateTimePicker.Value.Date.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    }
                    var values = new Dictionary<string, string>
                                {
                                   { "name", nametextBox.Text },
                                   { "age", agetextBox.Text },
                                   { "phone", phonetextBox.Text },
                                   { "sex", SexComboBox.Text },
                                   { "date_of_birth", Convert.ToString(timestampDateOfBirthday) },
                                   { "surname", sernametextBox.Text },
                                   { "email", emailtextBox.Text },
                                };
                    var content = new FormUrlEncodedContent(values);
                    using (HttpClient httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsync(Program.mySettingsForm.URL + "/api/employees/find", content);
                        var responseString = await response.Content.ReadAsStringAsync();

                        List<JsonResponceFromServer> jsonCode = JsonConvert.DeserializeObject<List<JsonResponceFromServer>>(responseString);
                        if (jsonCode.Count < 0)
                        {
                            if (jsonCode[0].State == "101")
                            {
                                MessageBox.Show("Error finding\n Message: " + jsonCode[0].Message, "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                WorkingPanel.Visible = false;
                                cancelBtn_Click(sender, e);
                                return;
                            }
                        }

                        json = JsonConvert.DeserializeObject<List<EmployeeJson>>(responseString);
                        Program.myMainForm.dataGridView1.DataSource = json;
                        int widthColumn = Program.myMainForm.dataGridView1.Width / Program.myMainForm.dataGridView1.ColumnCount - 5;
                        foreach (DataGridViewColumn item in Program.myMainForm.dataGridView1.Columns)
                        {
                            item.Width = widthColumn;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Server is unavaliable", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                WorkingPanel.Visible = false;
                cancelBtn_Click(sender, e);
            }
        }

        private void agetextBox_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex("^[0-9]{1,}$");
            if (!pattern.IsMatch(agetextBox.Text))
            {
                agetextBox.Text = "";
            }
        }
    }
}
