﻿
namespace shop_forms
{
    partial class ShopForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.addButton = new System.Windows.Forms.Button();
			this.productsList = new System.Windows.Forms.ListBox();
			this.removeButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.showButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(41)))), ((int)(((byte)(113)))));
			this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addButton.ForeColor = System.Drawing.Color.White;
			this.addButton.Location = new System.Drawing.Point(42, 92);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(159, 62);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "ADD";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// productsList
			// 
			this.productsList.BackColor = System.Drawing.SystemColors.Control;
			this.productsList.FormattingEnabled = true;
			this.productsList.ItemHeight = 15;
			this.productsList.Location = new System.Drawing.Point(246, 12);
			this.productsList.Name = "productsList";
			this.productsList.Size = new System.Drawing.Size(346, 394);
			this.productsList.TabIndex = 1;
			// 
			// removeButton
			// 
			this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(41)))), ((int)(((byte)(113)))));
			this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.removeButton.ForeColor = System.Drawing.Color.White;
			this.removeButton.Location = new System.Drawing.Point(42, 170);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(159, 62);
			this.removeButton.TabIndex = 2;
			this.removeButton.Text = "REMOVE";
			this.removeButton.UseVisualStyleBackColor = false;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// editButton
			// 
			this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(41)))), ((int)(((byte)(113)))));
			this.editButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.editButton.ForeColor = System.Drawing.Color.White;
			this.editButton.Location = new System.Drawing.Point(42, 247);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(159, 62);
			this.editButton.TabIndex = 3;
			this.editButton.Text = "EDIT";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// showButton
			// 
			this.showButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(41)))), ((int)(((byte)(113)))));
			this.showButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.showButton.ForeColor = System.Drawing.Color.White;
			this.showButton.Location = new System.Drawing.Point(42, 325);
			this.showButton.Name = "showButton";
			this.showButton.Size = new System.Drawing.Size(159, 62);
			this.showButton.TabIndex = 4;
			this.showButton.Text = "SHOW";
			this.showButton.UseVisualStyleBackColor = false;
			this.showButton.Click += new System.EventHandler(this.showButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(82, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 37);
			this.label1.TabIndex = 5;
			this.label1.Text = "Shop";
			// 
			// ShopForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(603, 419);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.showButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.productsList);
			this.Controls.Add(this.addButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ShopForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shop";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox productsList;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
    }
}

