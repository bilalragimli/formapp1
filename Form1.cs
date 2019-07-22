using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<string> groupList;
        public Form1()
        {
            groupList = new List<string>();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string groupname = txtbox.Text;
            if (groupname.Length!=0)
            {
                groupList.Add(groupname);
                cmb.Items.Clear();
                foreach (var grp in groupList)
                {
                    cmb.Items.Add(grp);
                }

            }
            else
            {
                error.Text = "404 Not found error";
                    error.Visible = true;
            }
        }
    }
}
