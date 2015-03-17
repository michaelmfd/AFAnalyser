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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
