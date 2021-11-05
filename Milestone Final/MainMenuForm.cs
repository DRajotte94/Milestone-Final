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
    public partial class MainMenuForm : Form
    {
        // global list variable
        List<Bike> inventory = InventoryManager.createInventory();
        List<Bike> displayed = new List<Bike>();

        public MainMenuForm()
        {
            InitializeComponent();
            displayed = inventory; // sets full inventory as the displayed list
            DisplayList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchInventoryForm searchForm = new SearchInventoryForm(inventory); // object for form
            searchForm.ShowDialog(); // display edit item form
            displayed = searchForm.newList;
            DisplayList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // get selected item values
            if (inventoryBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first.");
            }
            else
            {
                int i = inventoryBox.SelectedIndex;
                Bike bike = displayed[i];

                EditItemForm editItemForm = new EditItemForm(bike); // object for form
                editItemForm.ShowDialog(); // display edit item form

                Bike newBike = editItemForm.result; // pull new bike values from editItem form
                displayed[i] = newBike; // replace bike in displayed list

                // located and replaces bike in inventory list
                int count = 0;
                foreach (Bike b in inventory.ToList())
                {
                    if (b == bike)
                    {
                        inventory[count] = newBike;
                    }
                    count++;
                }
                DisplayList(); // refresh list display
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm(); // object for form
            addItemForm.ShowDialog(); // display add item form

            Bike bike = addItemForm.result; // pull item from addItem form
            inventory.Add(bike); // add new item to list
            DisplayList(); // refresh list display
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // get selected item values
            if (inventoryBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first.");
            }
            else
            {
                int i = inventoryBox.SelectedIndex;
                Bike bike = displayed[i];

                RemoveItemForm removeItemForm = new RemoveItemForm(bike); // object for form
                removeItemForm.ShowDialog(); // display remove item form
                String confirmation = removeItemForm.result;

                // check if confirmed or not
                if (confirmation == "Yes")
                {
                    inventory.Remove(bike);
                    displayed.Remove(bike);
                    DisplayList();
                }
            }
        }

        // displays the inventory list in the listbox
        private void DisplayList()
        {
            // clear current items in display to avoid duplicating
            inventoryBox.Items.Clear();

            // add items to listbox control for displaying
            foreach (Bike i in displayed)
            {
                inventoryBox.Items.Add(i);

                // display number of items
                itemCounter.Text = "( " + inventoryBox.Items.Count.ToString() + " ) Items Displayed";
            }
        }
    }
}
