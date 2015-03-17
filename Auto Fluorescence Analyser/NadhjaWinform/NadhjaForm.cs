using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadhjaWinform
{
    public partial class NadhjaForm : Form
    {
        /// <summary>
        /// Constructor: NadhjaForm
        /// Description: Initialize all winform controlls.
        /// </summary>
        public NadhjaForm()
        {
            //Initialize all forms
            InitializeComponent();
        }
        /// <summary>
        /// Method: btnExit_Click()
        /// Description: The application will be finished.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
