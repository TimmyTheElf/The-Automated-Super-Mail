using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Automated_Super_Mail
{
    public partial class MainWindow : Form
    {
        private static MainWindow mainWindow= null;
        private List<string> recipientsList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
        }

        private WebBrowser webBrowser1;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public static void PopulateStaticRecipients(List<string> items)
        {
            if (mainWindow != null)
                mainWindow.PopulateRecipients(items);
        }

        private void PopulateRecipients(List<string> items)
        {

            rtbRecipients.Text = String.Join("; ", items);

        }

        private void btnRecipients_Click(object sender, EventArgs e)
        {
            var recipientWindow = new RecipientsWindow();
            recipientWindow.Show();
        }
    }
}
