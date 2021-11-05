
namespace Milestone_Final
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.itemCounter = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // inventoryBox
            // 
            this.inventoryBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inventoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inventoryBox.FormattingEnabled = true;
            this.inventoryBox.ItemHeight = 16;
            this.inventoryBox.Location = new System.Drawing.Point(15, 54);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(418, 276);
            this.inventoryBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Honeydew;
            this.AddButton.Location = new System.Drawing.Point(223, 354);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 32);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Item";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Honeydew;
            this.RemoveButton.Location = new System.Drawing.Point(320, 354);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(91, 32);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // itemCounter
            // 
            this.itemCounter.AutoSize = true;
            this.itemCounter.Location = new System.Drawing.Point(337, 38);
            this.itemCounter.Name = "itemCounter";
            this.itemCounter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemCounter.Size = new System.Drawing.Size(102, 13);
            this.itemCounter.TabIndex = 3;
            this.itemCounter.Text = "( 0 ) Items Displayed";
            this.itemCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Honeydew;
            this.EditButton.Location = new System.Drawing.Point(124, 354);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(91, 32);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit Item";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Honeydew;
            this.SearchButton.Location = new System.Drawing.Point(25, 354);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 32);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(452, 423);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.itemCounter);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.inventoryBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox inventoryBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label itemCounter;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SearchButton;
    }
}

