
namespace CoffeeShop
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.numCoffee = new System.Windows.Forms.NumericUpDown();
            this.lblDonut = new System.Windows.Forms.Label();
            this.numDonut = new System.Windows.Forms.NumericUpDown();
            this.Order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonut)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter your name";
            this.textBox1.Size = new System.Drawing.Size(224, 27);
            this.textBox1.TabIndex = 0;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMain.Location = new System.Drawing.Point(234, 66);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(213, 46);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Coffee Shop";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(200, 257);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(281, 20);
            this.lblCoffee.TabIndex = 2;
            this.lblCoffee.Text = "Please select how many coffees you want";
            // 
            // numCoffee
            // 
            this.numCoffee.Location = new System.Drawing.Point(265, 306);
            this.numCoffee.Name = "numCoffee";
            this.numCoffee.Size = new System.Drawing.Size(150, 27);
            this.numCoffee.TabIndex = 3;
            // 
            // lblDonut
            // 
            this.lblDonut.AutoSize = true;
            this.lblDonut.Location = new System.Drawing.Point(201, 401);
            this.lblDonut.Name = "lblDonut";
            this.lblDonut.Size = new System.Drawing.Size(278, 20);
            this.lblDonut.TabIndex = 4;
            this.lblDonut.Text = "Please select how many donuts you want";
            // 
            // numDonut
            // 
            this.numDonut.Location = new System.Drawing.Point(265, 451);
            this.numDonut.Name = "numDonut";
            this.numDonut.Size = new System.Drawing.Size(150, 27);
            this.numDonut.TabIndex = 5;
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(265, 530);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(150, 37);
            this.Order.TabIndex = 6;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 603);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.numDonut);
            this.Controls.Add(this.lblDonut);
            this.Controls.Add(this.numCoffee);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.NumericUpDown numCoffee;
        private System.Windows.Forms.Label lblDonut;
        private System.Windows.Forms.NumericUpDown numDonut;
        private System.Windows.Forms.Button Order;
    }
}

