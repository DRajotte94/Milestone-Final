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
    public partial class SearchInventoryForm : Form
    {
        // global variable
        public List<Bike> newList = new List<Bike>();
        //public List<Bike> result { get; set; }

        public SearchInventoryForm(List<Bike> inventory)
        {
            InitializeComponent();

            foreach (Bike i in inventory)
            {
                newList.Add(i); // save values to new list
            }
            
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            criteriaBox.Items.Clear(); // ensures entries are cleared if option is changed
            if (categoryBox.SelectedIndex == 0) // name
            {
                // adds options to search combobox
                String[] names = { "Diamondback", "Eclipse", "E-Caliber", "Rail", "Top Fuel" };
                criteriaBox.Items.AddRange(names);
            }
            else if (categoryBox.SelectedIndex == 1) // size
            {
                // adds options to search combobox
                String[] sizes = { "small", "medium", "large" };
                criteriaBox.Items.AddRange(sizes);
            }
            else if (categoryBox.SelectedIndex == 2) // suspension
            {
                // adds options to search combobox
                String[] suspension = { "full", "rear" };
                criteriaBox.Items.AddRange(suspension);
            }
            else if (categoryBox.SelectedIndex == 3) // color
            {
                // adds options to search combobox
                String[] color = { "black", "white", "red", "blue", "green", "yellow" };
                criteriaBox.Items.AddRange(color);
            }
            else
            {
                MessageBox.Show("Please select a search option.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (categoryBox.SelectedIndex == 0) // name
            {
                foreach (Bike i in newList.ToList()) // iterates through each input in new list
                {
                    String s = criteriaBox.SelectedItem.ToString(); // saves selected value to a string for comparison
                    if (!s.Equals(i.getName())) // compares selected option to value of bike
                    {
                        newList.Remove(i); // removes item if it does not meet requirements
                    }
                }
                this.Close();
            }
            else if (categoryBox.SelectedIndex == 1) // size
            {
                foreach (Bike i in newList.ToList()) // iterates through each input in new list
                {
                    String s = criteriaBox.SelectedItem.ToString(); // saves selected value to a string for comparison
                    if (!s.Equals(i.getSize())) // compares selected option to value of bike
                    {
                        newList.Remove(i); // removes item if it does not meet requirements
                    }
                }
                this.Close();
            }
            else if (categoryBox.SelectedIndex == 2) // suspension
            {
                foreach (Bike i in newList.ToList()) // iterates through each input in new list
                {
                    String s = criteriaBox.SelectedItem.ToString(); // saves selected value to a string for comparison
                    if (!s.Equals(i.getSuspension())) // compares selected option to value of bike
                    {
                        newList.Remove(i); // removes item if it does not meet requirements
                    }
                }
                this.Close();
            }
            else if (categoryBox.SelectedIndex == 3) // color
            {
                foreach (Bike i in newList.ToList()) // iterates through each input in new list
                {
                    String s = criteriaBox.SelectedItem.ToString(); // saves selected value to a string for comparison
                    if (!s.Equals(i.getColor())) // compares selected option to value of bike
                    {
                        newList.Remove(i); // removes item if it does not meet requirements
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a search option.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // this will clear all search parameters and display the full inventory
            this.Close();
        }
    }
}
