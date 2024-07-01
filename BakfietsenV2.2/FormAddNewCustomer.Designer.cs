namespace BakfietsenV2._2
{
    partial class FormAddNewCustomer
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
            textBoxComments = new TextBox();
            labelComment = new Label();
            textBoxCity = new TextBox();
            labelCity = new Label();
            textBoxZipcode = new TextBox();
            labelZipcode = new Label();
            labelHouseNumber = new Label();
            textBoxHouseNumber = new TextBox();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            buttonCancel = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxComments
            // 
            textBoxComments.Location = new Point(216, 268);
            textBoxComments.Name = "textBoxComments";
            textBoxComments.Size = new Size(100, 23);
            textBoxComments.TabIndex = 29;
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new Point(114, 271);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(86, 15);
            labelComment.TabIndex = 30;
            labelComment.Text = "Opmerkingen: ";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(216, 229);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(100, 23);
            textBoxCity.TabIndex = 22;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(114, 237);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(36, 15);
            labelCity.TabIndex = 28;
            labelCity.Text = "Stad: ";
            // 
            // textBoxZipcode
            // 
            textBoxZipcode.Location = new Point(216, 194);
            textBoxZipcode.Name = "textBoxZipcode";
            textBoxZipcode.Size = new Size(100, 23);
            textBoxZipcode.TabIndex = 20;
            // 
            // labelZipcode
            // 
            labelZipcode.AutoSize = true;
            labelZipcode.Location = new Point(114, 202);
            labelZipcode.Name = "labelZipcode";
            labelZipcode.Size = new Size(62, 15);
            labelZipcode.TabIndex = 27;
            labelZipcode.Text = "Postcode: ";
            // 
            // labelHouseNumber
            // 
            labelHouseNumber.AutoSize = true;
            labelHouseNumber.Location = new Point(114, 166);
            labelHouseNumber.Name = "labelHouseNumber";
            labelHouseNumber.Size = new Size(80, 15);
            labelHouseNumber.TabIndex = 26;
            labelHouseNumber.Text = "Huisnummer:";
            // 
            // textBoxHouseNumber
            // 
            textBoxHouseNumber.Location = new Point(216, 158);
            textBoxHouseNumber.Name = "textBoxHouseNumber";
            textBoxHouseNumber.Size = new Size(100, 23);
            textBoxHouseNumber.TabIndex = 19;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(216, 120);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 18;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(114, 128);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(73, 15);
            labelAddress.TabIndex = 23;
            labelAddress.Text = "Straatnaam: ";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(109, 93);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(78, 15);
            labelLastName.TabIndex = 21;
            labelLastName.Text = "Achternaam: ";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(216, 85);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 16;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(216, 47);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 15;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(109, 50);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(67, 15);
            labelFirstName.TabIndex = 17;
            labelFirstName.Text = "Voornaam: ";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(60, 323);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(104, 45);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Annuleer";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(228, 323);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 45);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Opslaan";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAddNewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 424);
            Controls.Add(textBoxComments);
            Controls.Add(labelComment);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
            Controls.Add(textBoxZipcode);
            Controls.Add(labelZipcode);
            Controls.Add(labelHouseNumber);
            Controls.Add(textBoxHouseNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(labelLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "FormAddNewCustomer";
            Text = "AddNewCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxComments;
        private Label labelComment;
        private TextBox textBoxCity;
        private Label labelCity;
        private TextBox textBoxZipcode;
        private Label labelZipcode;
        private Label labelHouseNumber;
        private TextBox textBoxHouseNumber;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private Button buttonCancel;
        private Button buttonSave;
    }
}