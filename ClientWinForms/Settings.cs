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
namespace ClientWinForms
{
    public partial class Settings : Form
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
        public string URL = "http://localhost:50673";
        private static readonly HttpClient client = new HttpClient();
        public Settings()
        {
            InitializeComponent();
        }

        private async void SaveURLbutton_Click(object sender, EventArgs e)
        {
            URL = URLtextBox.Text;
            try
            {
                var responseString = await client.GetStringAsync(URL + "/api/emploees/validate");
                if(responseString == "1")
                {
                    button1_Click(sender,e);
                }
            }
            catch {
                MessageBox.Show("Server is unavaliable!", "Employee accounting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings_VisibleChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
            URLtextBox.Text = URL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.myMainForm.Enabled = true;
        }
    }
}
