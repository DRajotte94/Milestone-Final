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
    public partial class AddItemForm : Form
    {
        public Bike result { get; set; } // return value

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String size = sizeBox.Text;
            String suspension = suspensionBox.Text;
            String color = colorBox.Text;
            int quantity;

            if (int.TryParse(quantityBox.Text, out quantity))
            {
                Bike bike = new Bike(name, size, suspension, color, quantity);
                result = bike;

                this.Close();
            }
        }

        private void clearInputsButton_Click(object sender, EventArgs e)
        {
            // clears all inputs
            nameBox.Clear();
            sizeBox.Clear();
            suspensionBox.Clear();
            colorBox.Clear();
            quantityBox.Clear();
        }
    }
}
