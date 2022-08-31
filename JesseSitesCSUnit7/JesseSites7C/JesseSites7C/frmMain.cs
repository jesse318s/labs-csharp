using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JesseSites7C
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        List<ContactEntry> contactList = new List<ContactEntry>();

        private void frmMain_Load(object sender, EventArgs e)
        {
            StreamReader streamreader = new StreamReader(@"contacts.txt");
            int x = 0;

            while (!streamreader.EndOfStream)
            {
                ContactEntry contact = new ContactEntry();
                contactList.Add(contact);
                contactList[x].Name = streamreader.ReadLine();
                contactList[x].Email = streamreader.ReadLine();
                contactList[x].Phone = streamreader.ReadLine();
                lbxNames.Items.Add(contactList[x].Name);
                x++;
            }
            streamreader.Close();
        }

        private void lbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = lbxNames.SelectedIndex;
            MessageBox.Show("Name: " + contactList[x].Name + "\nEmail: " + contactList[x].Email + "\nPhone: " + contactList[x].Phone);
            lblContact.Text = "Name: " + contactList[x].Name + "\nEmail: " + contactList[x].Email + "\nPhone: " + contactList[x].Phone;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblContact.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
