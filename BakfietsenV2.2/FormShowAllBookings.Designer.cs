namespace BakfietsenV2._2
{
    partial class FormShowAllBookings
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
            dataGridBookings = new DataGridView();
            button1 = new Button();
            buttonNewCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridBookings).BeginInit();
            SuspendLayout();
            // 
            // dataGridBookings
            // 
            dataGridBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBookings.Location = new Point(61, 46);
            dataGridBookings.Name = "dataGridBookings";
            dataGridBookings.Size = new Size(656, 295);
            dataGridBookings.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(488, 404);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonNewCustomer
            // 
            buttonNewCustomer.Location = new Point(571, 369);
            buttonNewCustomer.Name = "buttonNewCustomer";
            buttonNewCustomer.Size = new Size(146, 57);
            buttonNewCustomer.TabIndex = 9;
            buttonNewCustomer.Text = "Nieuwe klant";
            buttonNewCustomer.UseVisualStyleBackColor = true;
            // 
            // FormShowAllBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNewCustomer);
            Controls.Add(button1);
            Controls.Add(dataGridBookings);
            Name = "FormShowAllBookings";
            Text = "Alle boekingen";
            Load += FormShowAllBookings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridBookings;
        private Button button1;
        private Button buttonNewCustomer;
    }
}