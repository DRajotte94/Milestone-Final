using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Final
{
    public class Bike // class for creating and managing the bike object
    {
        // variables representing the bike
        private String name, size, suspension, color;
        private int quantity;

        // constuctor for random value (used for testing manager)
        public Bike()
        {
            // using random number generation to create random objects
            Random r = new Random(Guid.NewGuid().GetHashCode()); // credit: joppiesaus - https://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values

            // random name
            int numName = r.Next(1, 6);
            if (numName == 1) { this.name = "Diamondback"; }
            else if (numName == 2) { this.name = "Eclipse"; }
            else if (numName == 3) { this.name = "E-Caliber"; }
            else if (numName == 4) { this.name = "Rail"; }
            else { this.name = "Top Fuel"; }

            // random size
            int sizeNum = r.Next(1, 4);
            if (sizeNum == 1) { this.size = "small"; }
            else if (sizeNum == 2) { this.size = "medium"; }
            else if (sizeNum == 3) { this.size = "large"; }

            // random suspension
            int susNum = r.Next(1, 3);
            if (susNum == 1) { this.suspension = "full"; }
            else { this.suspension = "rear"; }

            // random color
            int colorNum = r.Next(1, 7);
            if (colorNum == 1) { this.color = "black"; }
            else if (colorNum == 2) { this.color = "white"; }
            else if (colorNum == 3) { this.color = "red"; }
            else if (colorNum == 4) { this.color = "blue"; }
            else if (colorNum == 5) { this.color = "green"; }
            else if (colorNum == 6) { this.color = "yellow"; }

            // random quantity
            this.quantity = r.Next(1, 10);
        }

        // constructor
        public Bike(String name, String size, String suspension, String color, int quantity)
        {
            this.name = name;
            this.size = size;
            this.suspension = suspension;
            this.color = color;
            this.quantity = quantity;
        }

        // get and set name
        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        // get and set size
        public String getSize()
        {
            return size;
        }

        public void setSize(String size)
        {
            this.size = size;
        }

        // get and set suspension
        public String getSuspension()
        {
            return suspension;
        }

        public void setSuspension(String suspension)
        {
            this.suspension = suspension;
        }

        // get and set color
        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        // get and set quantity
        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        // string value of object
        public override string ToString()
        {
            return this.getName() + " - " + this.getSize() + " - " + this.getSuspension() + " - " + this.getColor() + " - QTY: " + this.getQuantity();
        }
    }
}
