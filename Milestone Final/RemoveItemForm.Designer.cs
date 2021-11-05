
namespace Milestone_Final
{
    partial class RemoveItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveItemForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to remove ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "this item from the inventory?";
            // 
            // itemLabel
            // 
            this.itemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(12, 102);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(316, 27);
            this.itemLabel.TabIndex = 2;
            this.itemLabel.Text = "item description";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Honeydew;
            this.confirmButton.Location = new System.Drawing.Point(84, 162);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(77, 33);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.BackColor = System.Drawing.Color.Silver;
            this.declineButton.Location = new System.Drawing.Point(182, 162);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(77, 33);
            this.declineButton.TabIndex = 3;
            this.declineButton.Text = "Cancel";
            this.declineButton.UseVisualStyleBackColor = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // RemoveItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(353, 269);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveItemForm";
            this.Text = "Remove Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button declineButton;
    }
}