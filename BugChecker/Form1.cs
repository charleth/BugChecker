using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugChecker
{
    public partial class FormBugChecker : Form
    {
        public FormBugChecker()
        {
            InitializeComponent();
        }

        private void checkBoxC_CheckedChanged(object sender, EventArgs e)
        {
            if
                (checkBoxC.Checked == false)
            {
                checkBoxA.Checked = true;
            }
        }

        private void checkBoxA_CheckedChanged(object sender, EventArgs e)
        {
            if
                (checkBoxA.Checked == false &&
                checkBoxD.Checked == false)
            {
                checkBoxC.AutoCheck = false;
                checkBoxD.AutoCheck = false;

                checkBoxC.Checked = true;
                checkBoxD.Checked = true;

                checkBoxC.AutoCheck = true;
                checkBoxD.AutoCheck = true;
            }
            else if
                (checkBoxA.Checked == false && 
                checkBoxD.Checked == true)
            {
                checkBoxC.AutoCheck = false;
                checkBoxD.AutoCheck = false;
                checkBoxE.AutoCheck = false;

                checkBoxC.Checked = false;
                checkBoxE.Checked = true;
                checkBoxF.Checked = true;

                checkBoxC.AutoCheck = true;
                checkBoxD.AutoCheck = true;
                checkBoxE.AutoCheck = true;
            }
        }

        private void checkBoxD_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxE_CheckedChanged(object sender, EventArgs e)
        {
            if
                (checkBoxE.Checked == false)
            {
                checkBoxC.AutoCheck = false;

                checkBoxC.Checked = true;

                checkBoxC.AutoCheck = true;
            }
        }

        private void checkBoxF_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
