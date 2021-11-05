using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Final
{
    public partial class RemoveItemForm : Form
    {
        public String result { get; set; } // return value

        public RemoveItemForm(Bike bike)
        {
            InitializeComponent();

            itemLabel.Text = bike.ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            result = "Yes";
            this.Close();
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            result = "No";
            this.Close();
        }
    }
}
