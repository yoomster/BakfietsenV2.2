namespace BakfietsenV2._2
{
    partial class FormHome
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
            label1 = new Label();
            buttonNewCustomer = new Button();
            buttonAllCustomers = new Button();
            buttonNewBooking = new Button();
            buttonAllBookings = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 43);
            label1.Name = "label1";
            label1.Size = new Size(252, 15);
            label1.TabIndex = 9;
            label1.Text = "Welkom Naomi, dit is de Admin home pagina ";
            // 
            // buttonNewCustomer
            // 
            buttonNewCustomer.Location = new Point(69, 179);
            buttonNewCustomer.Name = "buttonNewCustomer";
            buttonNewCustomer.Size = new Size(146, 57);
            buttonNewCustomer.TabIndex = 8;
            buttonNewCustomer.Text = "Nieuwe klant";
            buttonNewCustomer.UseVisualStyleBackColor = true;
            buttonNewCustomer.Click += buttonNewCustomer_Click;
            // 
            // buttonAllCustomers
            // 
            buttonAllCustomers.Location = new Point(69, 91);
            buttonAllCustomers.Name = "buttonAllCustomers";
            buttonAllCustomers.Size = new Size(146, 57);
            buttonAllCustomers.TabIndex = 7;
            buttonAllCustomers.Text = "Alle klanten";
            buttonAllCustomers.UseVisualStyleBackColor = true;
            buttonAllCustomers.Click += buttonAllCustomers_Click;
            // 
            // buttonNewBooking
            // 
            buttonNewBooking.Location = new Point(303, 179);
            buttonNewBooking.Name = "buttonNewBooking";
            buttonNewBooking.Size = new Size(141, 57);
            buttonNewBooking.TabIndex = 6;
            buttonNewBooking.Text = "Nieuwe boeking";
            buttonNewBooking.UseVisualStyleBackColor = true;
            // 
            // buttonAllBookings
            // 
            buttonAllBookings.Location = new Point(303, 91);
            buttonAllBookings.Name = "buttonAllBookings";
            buttonAllBookings.Size = new Size(141, 57);
            buttonAllBookings.TabIndex = 5;
            buttonAllBookings.Text = "Alle boekingen";
            buttonAllBookings.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 303);
            Controls.Add(label1);
            Controls.Add(buttonNewCustomer);
            Controls.Add(buttonAllCustomers);
            Controls.Add(buttonNewBooking);
            Controls.Add(buttonAllBookings);
            Name = "FormHome";
            Text = "Home pagina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonNewCustomer;
        private Button buttonAllCustomers;
        private Button buttonNewBooking;
        private Button buttonAllBookings;
    }
}