using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace myBrowser
{
    public partial class Form1 : Form
    {
        private Form2 historyForm;
        public string URL = string.Empty;
        public string HOME_URL = "https://www.google.com";
        private string BOOPATH = @"C:\Users\Public\Documents\bookmarks.txt";
        public Form1()
        {
            InitializeComponent();
            historyForm = new Form2(this);
            browserControl();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void browserControl()
        {
            webBrowser1.DocumentTitleChanged += new EventHandler(webpage_DocumentTitleChanged);
            webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webpage_Navigated);
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webpage_DocumentCompleted);
            webBrowser1.Navigate(HOME_URL);
        }
        private void webpage_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle.ToString();
        }
        private void webpage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                button1.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (webBrowser1.CanGoForward)
            {
                button2.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
        private void webpage_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
        public void navigateFromHistory(string hURL)
        {
            webBrowser1.Navigate(hURL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button3, new Point(0, button3.Height));
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyForm.ShowDialog();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (textBox1.Text != "") URL = textBox1.Text;
                historyForm.initRow(URL);
                webBrowser1.Navigate(URL);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(BOOPATH))
            {
                using (StreamReader bookmarksReader = new StreamReader(BOOPATH))
                {
                    string bookmarksContents = bookmarksReader.ReadToEnd();
                    if (bookmarksContents.Contains(URL))
                    {
                        MessageBox.Show("Uzhe dobavleno...");
                    }
                    else
                    {
                        using (StreamWriter bookmarksWritter = new StreamWriter(BOOPATH))
                        {
                            bookmarksWritter.WriteLine(URL);
                            bookmarksWritter.Dispose();
                            bookmarksReader.Dispose();
                        }
                    }
                }
            }
            else
            {
                File.Create(BOOPATH).Dispose();
                using (StreamWriter bookmarksWritter = new StreamWriter(BOOPATH))
                {
                    bookmarksWritter.WriteLine(URL);
                    bookmarksWritter.Dispose();
                }
            }
            
        }
    }
}
