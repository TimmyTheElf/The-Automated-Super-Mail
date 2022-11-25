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
    public partial class RecipientsWindow : Form
    {
        private static RecipientsWindow recipientsWindow = null;
        public RecipientsWindow()
        {
            InitializeComponent();
            recipientsWindow = this;
        }
        private void RecipientsWindow_Load(object sender, EventArgs e)
        {
            DataTable managerEmails = new DataTable();
            managerEmails = SQLController.GetManagerEmails();
        
            for(int i = 0; i<20; i++) {
                chkEmails.Items.Add(managerEmails.Rows[i]["EMAIL_ADDRESS"].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> recipients = new List<string>();
            foreach (var item in chkEmails.CheckedItems)
            {
                recipients.Add(item.ToString());
            }
            MainWindow.PopulateStaticRecipients(recipients);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
