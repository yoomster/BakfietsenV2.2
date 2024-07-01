namespace BakfietsenV2._2
{
    partial class FormAddNewBooking
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
            buttonCancel = new Button();
            buttonChooseCustomer = new Button();
            totalDaysLabel = new Label();
            ReturnDatePicker = new DateTimePicker();
            label1 = new Label();
            StartLabel = new Label();
            RentDateLlabel = new Label();
            StartDatePicker = new DateTimePicker();
            ChoiceOfBikes = new ComboBox();
            ListBoxAccessoires = new CheckedListBox();
            ButtonSave = new Button();
            ExtrasLabel = new Label();
            BikeLabel = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 12F);
            buttonCancel.Location = new Point(97, 370);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(147, 43);
            buttonCancel.TabIndex = 40;
            buttonCancel.Text = "Annuleren";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonChooseCustomer
            // 
            buttonChooseCustomer.Location = new Point(438, 290);
            buttonChooseCustomer.Name = "buttonChooseCustomer";
            buttonChooseCustomer.Size = new Size(175, 40);
            buttonChooseCustomer.TabIndex = 39;
            buttonChooseCustomer.Text = "Kies een klant";
            buttonChooseCustomer.UseVisualStyleBackColor = true;
            buttonChooseCustomer.Click += buttonChooseCustomer_Click;
            // 
            // totalDaysLabel
            // 
            totalDaysLabel.AutoSize = true;
            totalDaysLabel.Font = new Font("Segoe UI", 12F);
            totalDaysLabel.Location = new Point(360, 214);
            totalDaysLabel.Name = "totalDaysLabel";
            totalDaysLabel.Size = new Size(147, 21);
            totalDaysLabel.TabIndex = 38;
            totalDaysLabel.Text = "Totaal aantal dagen ";
            // 
            // ReturnDatePicker
            // 
            ReturnDatePicker.Font = new Font("Segoe UI", 12F);
            ReturnDatePicker.Location = new Point(360, 158);
            ReturnDatePicker.Name = "ReturnDatePicker";
            ReturnDatePicker.Size = new Size(253, 29);
            ReturnDatePicker.TabIndex = 37;
            ReturnDatePicker.ValueChanged += ReturnDatePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(379, 134);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 36;
            label1.Text = "Eind";
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.Font = new Font("Segoe UI", 12F);
            StartLabel.Location = new Point(377, 55);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(42, 21);
            StartLabel.TabIndex = 35;
            StartLabel.Text = "Start";
            // 
            // RentDateLlabel
            // 
            RentDateLlabel.AutoSize = true;
            RentDateLlabel.Font = new Font("Segoe UI", 12F);
            RentDateLlabel.Location = new Point(360, 27);
            RentDateLlabel.Name = "RentDateLlabel";
            RentDateLlabel.Size = new Size(94, 21);
            RentDateLlabel.TabIndex = 34;
            RentDateLlabel.Text = "Huur datum";
            // 
            // StartDatePicker
            // 
            StartDatePicker.Font = new Font("Segoe UI", 12F);
            StartDatePicker.Location = new Point(360, 84);
            StartDatePicker.MinDate = new DateTime(2024, 3, 28, 0, 0, 0, 0);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(253, 29);
            StartDatePicker.TabIndex = 33;
            StartDatePicker.ValueChanged += StartDatePicker_ValueChanged;
            // 
            // ChoiceOfBikes
            // 
            ChoiceOfBikes.Font = new Font("Segoe UI", 12F);
            ChoiceOfBikes.FormattingEnabled = true;
            ChoiceOfBikes.Location = new Point(41, 60);
            ChoiceOfBikes.Name = "ChoiceOfBikes";
            ChoiceOfBikes.Size = new Size(252, 29);
            ChoiceOfBikes.TabIndex = 29;
            ChoiceOfBikes.Text = "Urban Arrow 4 pers. € 20";
            ChoiceOfBikes.SelectedIndexChanged += ChoiceOfBikes_SelectedIndexChanged;
            // 
            // ListBoxAccessoires
            // 
            ListBoxAccessoires.CheckOnClick = true;
            ListBoxAccessoires.Font = new Font("Segoe UI", 12F);
            ListBoxAccessoires.FormattingEnabled = true;
            ListBoxAccessoires.Items.AddRange(new object[] { "" });
            ListBoxAccessoires.Location = new Point(41, 147);
            ListBoxAccessoires.Name = "ListBoxAccessoires";
            ListBoxAccessoires.Size = new Size(190, 100);
            ListBoxAccessoires.TabIndex = 31;
            ListBoxAccessoires.ThreeDCheckBoxes = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Enabled = false;
            ButtonSave.Font = new Font("Segoe UI", 12F);
            ButtonSave.Location = new Point(360, 370);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(147, 43);
            ButtonSave.TabIndex = 32;
            ButtonSave.Text = "Opslaan";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ExtrasLabel
            // 
            ExtrasLabel.AutoSize = true;
            ExtrasLabel.Font = new Font("Segoe UI", 12F);
            ExtrasLabel.Location = new Point(41, 114);
            ExtrasLabel.Name = "ExtrasLabel";
            ExtrasLabel.Size = new Size(216, 21);
            ExtrasLabel.TabIndex = 30;
            ExtrasLabel.Text = "Extras toevoegen (kosten p/d)";
            // 
            // BikeLabel
            // 
            BikeLabel.AutoSize = true;
            BikeLabel.Font = new Font("Segoe UI", 12F);
            BikeLabel.Location = new Point(41, 27);
            BikeLabel.Name = "BikeLabel";
            BikeLabel.Size = new Size(226, 21);
            BikeLabel.TabIndex = 28;
            BikeLabel.Text = "Selecteer uw gewenste bakfiets";
            // 
            // FormAddNewBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 439);
            Controls.Add(buttonCancel);
            Controls.Add(buttonChooseCustomer);
            Controls.Add(totalDaysLabel);
            Controls.Add(ReturnDatePicker);
            Controls.Add(label1);
            Controls.Add(StartLabel);
            Controls.Add(RentDateLlabel);
            Controls.Add(StartDatePicker);
            Controls.Add(ChoiceOfBikes);
            Controls.Add(ListBoxAccessoires);
            Controls.Add(ButtonSave);
            Controls.Add(ExtrasLabel);
            Controls.Add(BikeLabel);
            Name = "FormAddNewBooking";
            Text = "FormAddNewBooking";
            Load += FormAddNewBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonChooseCustomer;
        private Label totalDaysLabel;
        private DateTimePicker ReturnDatePicker;
        private Label label1;
        private Label StartLabel;
        private Label RentDateLlabel;
        private DateTimePicker StartDatePicker;
        private ComboBox ChoiceOfBikes;
        private CheckedListBox ListBoxAccessoires;
        private Button ButtonSave;
        private Label ExtrasLabel;
        private Label BikeLabel;
    }
}