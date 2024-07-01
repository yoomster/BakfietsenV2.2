namespace BakfietsenV2._2
{
    partial class FormLogin
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
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            labelPassword = new Label();
            labelUserName = new Label();
            buttonCancel = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(212, 82);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(183, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(212, 43);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(183, 23);
            textBoxUserName.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(85, 82);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(81, 15);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Wachtwoord: ";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(85, 43);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(96, 15);
            labelUserName.TabIndex = 7;
            labelUserName.Text = "Gebruikersnaam:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(111, 139);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(109, 45);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click_1;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(252, 139);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(109, 45);
            buttonOk.TabIndex = 9;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 227);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "FormLogin";
            Text = "Login pagina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private Label labelPassword;
        private Label labelUserName;
        private Button buttonCancel;
        private Button buttonOk;
    }
}