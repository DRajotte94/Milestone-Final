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
    public partial class EditItemForm : Form
    {
        public Bike result { get; set; } // return value

        // create variables
        String name;
        String size;
        String suspension;
        String color;
        int quantity;

        public EditItemForm(Bike bike)
        {
            InitializeComponent();

            // populate variables for reset
            name = bike.getName();
            size = bike.getSize();
            suspension = bike.getSuspension();
            color = bike.getColor();
            quantity = bike.getQuantity();

            // populate boxes with existing values
            nameBox.Text = name;
            sizeBox.Text = size;
            suspensionBox.Text = suspension;
            colorBox.Text = color;
            quantityBox.Text = quantity.ToString();
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(quantityBox.Text, out quantity))
            {
                Bike bike = new Bike(nameBox.Text, sizeBox.Text, suspensionBox.Text, colorBox.Text, quantity);
                result = bike;

                this.Close();
            }
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            // resets values back to original values
            nameBox.Text = name;
            sizeBox.Text = size;
            suspensionBox.Text = suspension;
            colorBox.Text = color;
            quantityBox.Text = quantity.ToString();
        }
    }
}
