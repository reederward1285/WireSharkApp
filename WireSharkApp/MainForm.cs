using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WireSharkApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_GenerateMsgBox_Click(object sender, EventArgs e)
        {
            // textbox is an object type for windows form applications
            string msgBoxText = textBox_TypeInValueToShowOnMsgBox.Text;

            // show the windows messagebox (another windows object type)
            MessageBox.Show(msgBoxText, "Click OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // change the label above the textbox
            label_TypeInValueToShowOnMsgBox.Text = "Finished!";
            label_TypeInValueToShowOnMsgBox.Refresh();

            // pause the application for two seconds so you
            // can see that the label changed
            Thread.Sleep(2000);

            // close the application
            label_TypeInValueToShowOnMsgBox.Text = "Closing Application";
            label_TypeInValueToShowOnMsgBox.Refresh();

            // wait a little longer
            Thread.Sleep(2000);

            // close the application
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_TypeInValueToShowOnMsgBox.Text = "Type in value to show on Windows MessageBox object";
        }
    }
}
