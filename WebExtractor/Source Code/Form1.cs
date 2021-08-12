using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace WebExtractor
{
    ///<summary>
    ///-----------------------------------------------
    ///                github --> TNAlotaibi
    ///-----------------------------------------------
    /// The function of this tool extracts emails and phone numbers from a web page.
    /// All you have to do is enter the page link
    /// All rights reserved, I hope not to be erased!
    /// </summary>
    public partial class Form1 : Form
    {
//  -->  Variables to animate the Form  <--
        bool boolean = false;
        int X = 0;
        int Y = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }
        void extracting_strings(string source_code)
        {
            //  -->  Variables Counter for emails and phone numbers  <--
            int email = 0;
            int phone = 0;
            //         -->  Extract Email And Phone Numbers Using Regex --> System.Text.RegularExpressions  <--

            string inserter = "";
            Match match;
            ResultBox.AppendText("--------------Emails----------------" + Environment.NewLine);
            for (match = Regex.Match(source_code, @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}"); match.Success; match = match.NextMatch())
            {
                if (!(ResultBox.Text.Contains(match.Value)))
                {
                    ResultBox.AppendText(match.Value + Environment.NewLine);
                    email++;
                    emailCounter.Text = "Email : " + email.ToString();
                }
            }

            ResultBox.AppendText("--------------Phone Numbers----------------" + Environment.NewLine);
            MatchCollection matches = Regex.Matches(source_code,@"(?:\+?0*?966)?0?5[0-9]{8}");
            MatchCollection matches2 = Regex.Matches(source_code, @"\(?\d{3}\)?-? *\d{1,3}-? *-?\d{7}(?:[-\.\s]?)");
            foreach (Match match1 in matches)
            {
                string ph1 = match1.Value.ToString();
                if (!ResultBox.Text.Contains(ph1))
                {
                    if (ph1.Substring(0, 1) == "5" && ph1.Length == 9)
                    {
                        ResultBox.AppendText("0" + ph1 + Environment.NewLine);
                        phone++;
                        phoneCounter.Text = "Phone : " + phone.ToString();
                    }
                }
            }
            foreach (Match match2 in matches2)
            {
                string ph2 = match2.Value.ToString();
                if (!ResultBox.Text.Contains(ph2))
                {
                    if (ph2.Substring(0, 1) == "9") inserter = "+";
                        ResultBox.AppendText(inserter + ph2.Replace("-", string.Empty) + Environment.NewLine);
                        phone++;
                        phoneCounter.Text = "Phone : " + phone.ToString();
                    }
                inserter = "";
            }
            DialogResult qu = MessageBox.Show($"Done Extracted --> {email.ToString()} Email  | {phone.ToString()} Phone Numbers", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (qu == DialogResult.Yes)
            {
                Directory.CreateDirectory("Result");
                File.AppendAllText(Directory.GetCurrentDirectory() + "\\Result\\" +URLBox.Text.Split('.')[1]+"----"+ DateTime.Now.ToString().Replace("/", "-").Replace(":", "-")+".txt", ResultBox.Text);
            }
            ResultBox.Clear();
        }
        string grab_source_code(string url)
        {
            string response = string.Empty;
            try
            {
                WebClient web = new WebClient();
                response = web.DownloadString(url);
                return response;
            }
            catch (WebException)
            {
                response = null;
            }
            return response;
        }
        void method()
        {
            try
            {
                string response = grab_source_code(URLBox.Text);
                if (!(response == null))
                {
                    extracting_strings(response);
                }
                else
                {
                    MessageBox.Show("Can't get response from website!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in request" , "",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (URLBox.Text == string.Empty) MessageBox.Show("Please Enter url !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else new Thread(method).Start();
        }
        // Animate Form 
        private void lblName_MouseDown(object sender, MouseEventArgs e)
        {
            boolean = true;
            X = e.X;
            Y = e.Y;
        }

        private void lblName_MouseMove(object sender, MouseEventArgs e)
        {
            if (boolean)
            SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
        }

        private void lblName_MouseUp(object sender, MouseEventArgs e)
        {
            boolean = false;
        }
    }
}
