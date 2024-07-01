namespace BakfietsenV2._2
{
    partial class FormShowAllCustomers
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
            dataGridViewCustomers = new DataGridView();
            buttonChooseCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(88, 37);
            dataGridViewCustomers.MultiSelect = false;
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.Size = new Size(604, 331);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // buttonChooseCustomer
            // 
            buttonChooseCustomer.Location = new Point(572, 381);
            buttonChooseCustomer.Name = "buttonChooseCustomer";
            buttonChooseCustomer.Size = new Size(146, 57);
            buttonChooseCustomer.TabIndex = 1;
            buttonChooseCustomer.Text = "Kies klant";
            buttonChooseCustomer.UseVisualStyleBackColor = true;
            buttonChooseCustomer.Click += buttonChooseCustomer_Click;
            // 
            // FormShowAllCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 450);
            Controls.Add(buttonChooseCustomer);
            Controls.Add(dataGridViewCustomers);
            Name = "FormShowAllCustomers";
            Text = "Alle klanten";
            Load += FormShowAllCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private ListBox listBoxViewCustomers;
        private Button buttonChooseCustomer;
    }
}