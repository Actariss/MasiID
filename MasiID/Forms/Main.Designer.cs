namespace MasiID
{
    partial class Main
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
            GetDataFromCardButton = new Button();
            DateOfBirthLabel = new Label();
            birthBox = new TextBox();
            NameLabel = new Label();
            NameBox = new TextBox();
            ErrorLabel = new Label();
            EmailBox = new TextBox();
            PinBox = new TextBox();
            EmailLabel = new Label();
            PinLabel = new Label();
            SexLabel = new Label();
            CardNbrLabel = new Label();
            SexBox = new TextBox();
            CardNbrBox = new TextBox();
            SurnameLabel = new Label();
            SurnameBox = new TextBox();
            SendDataButton = new Button();
            PinConfirmBox = new TextBox();
            SuspendLayout();
            // 
            // GetDataFromCardButton
            // 
            GetDataFromCardButton.BackColor = Color.FromArgb(0, 120, 215);
            GetDataFromCardButton.Cursor = Cursors.Hand;
            GetDataFromCardButton.FlatAppearance.BorderSize = 0;
            GetDataFromCardButton.FlatStyle = FlatStyle.Flat;
            GetDataFromCardButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            GetDataFromCardButton.ForeColor = Color.White;
            GetDataFromCardButton.Location = new Point(357, 395);
            GetDataFromCardButton.Name = "GetDataFromCardButton";
            GetDataFromCardButton.Size = new Size(135, 40);
            GetDataFromCardButton.TabIndex = 0;
            GetDataFromCardButton.Text = "Read Card";
            GetDataFromCardButton.UseVisualStyleBackColor = false;
            GetDataFromCardButton.Click += get_Data_From_Card;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Font = new Font("Segoe UI", 10F);
            DateOfBirthLabel.ForeColor = Color.FromArgb(50, 50, 50);
            DateOfBirthLabel.Location = new Point(201, 173);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(94, 19);
            DateOfBirthLabel.TabIndex = 1;
            DateOfBirthLabel.Text = "Date of birth :";
            // 
            // birthBox
            // 
            birthBox.BackColor = Color.White;
            birthBox.BorderStyle = BorderStyle.FixedSingle;
            birthBox.Font = new Font("Segoe UI", 10F);
            birthBox.ForeColor = Color.Black;
            birthBox.Location = new Point(321, 169);
            birthBox.Name = "birthBox";
            birthBox.PlaceholderText = "Birth Date";
            birthBox.ReadOnly = true;
            birthBox.Size = new Size(200, 25);
            birthBox.TabIndex = 3;
            birthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 10F);
            NameLabel.ForeColor = Color.FromArgb(50, 50, 50);
            NameLabel.Location = new Point(169, 287);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(122, 19);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name of the user :";
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.White;
            NameBox.BorderStyle = BorderStyle.FixedSingle;
            NameBox.Font = new Font("Segoe UI", 10F);
            NameBox.ForeColor = Color.Black;
            NameBox.Location = new Point(321, 283);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Name";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(200, 25);
            NameBox.TabIndex = 5;
            NameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 10F);
            ErrorLabel.ForeColor = Color.FromArgb(50, 50, 50);
            ErrorLabel.Location = new Point(452, 449);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 19);
            ErrorLabel.TabIndex = 6;
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.White;
            EmailBox.BorderStyle = BorderStyle.FixedSingle;
            EmailBox.Font = new Font("Segoe UI", 10F);
            EmailBox.ForeColor = Color.Black;
            EmailBox.Location = new Point(321, 321);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Enter email";
            EmailBox.Size = new Size(200, 25);
            EmailBox.TabIndex = 7;
            EmailBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PinBox
            // 
            PinBox.BackColor = Color.White;
            PinBox.BorderStyle = BorderStyle.FixedSingle;
            PinBox.Font = new Font("Segoe UI", 10F);
            PinBox.ForeColor = Color.Black;
            PinBox.Location = new Point(321, 359);
            PinBox.Name = "PinBox";
            PinBox.PlaceholderText = "Enter PIN code";
            PinBox.Size = new Size(200, 25);
            PinBox.TabIndex = 8;
            PinBox.TextAlign = HorizontalAlignment.Center;
            PinBox.UseSystemPasswordChar = true;
            PinBox.KeyPress += textBox1_KeyPress;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 10F);
            EmailLabel.ForeColor = Color.FromArgb(50, 50, 50);
            EmailLabel.Location = new Point(255, 325);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(48, 19);
            EmailLabel.TabIndex = 9;
            EmailLabel.Text = "Email :";
            // 
            // PinLabel
            // 
            PinLabel.AutoSize = true;
            PinLabel.Font = new Font("Segoe UI", 10F);
            PinLabel.ForeColor = Color.FromArgb(50, 50, 50);
            PinLabel.Location = new Point(227, 363);
            PinLabel.Name = "PinLabel";
            PinLabel.Size = new Size(74, 19);
            PinLabel.TabIndex = 10;
            PinLabel.Text = "Code PIN :";
            // 
            // SexLabel
            // 
            SexLabel.AutoSize = true;
            SexLabel.Font = new Font("Segoe UI", 10F);
            SexLabel.ForeColor = Color.FromArgb(50, 50, 50);
            SexLabel.Location = new Point(250, 211);
            SexLabel.Name = "SexLabel";
            SexLabel.Size = new Size(43, 19);
            SexLabel.TabIndex = 13;
            SexLabel.Text = "Sexe :";
            // 
            // CardNbrLabel
            // 
            CardNbrLabel.AutoSize = true;
            CardNbrLabel.Font = new Font("Segoe UI", 10F);
            CardNbrLabel.ForeColor = Color.FromArgb(50, 50, 50);
            CardNbrLabel.Location = new Point(200, 135);
            CardNbrLabel.Name = "CardNbrLabel";
            CardNbrLabel.Size = new Size(97, 19);
            CardNbrLabel.TabIndex = 14;
            CardNbrLabel.Text = "Card number :";
            // 
            // SexBox
            // 
            SexBox.BackColor = Color.White;
            SexBox.BorderStyle = BorderStyle.FixedSingle;
            SexBox.Font = new Font("Segoe UI", 10F);
            SexBox.ForeColor = Color.Black;
            SexBox.Location = new Point(321, 207);
            SexBox.Name = "SexBox";
            SexBox.PlaceholderText = "Sexe";
            SexBox.ReadOnly = true;
            SexBox.Size = new Size(200, 25);
            SexBox.TabIndex = 15;
            SexBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CardNbrBox
            // 
            CardNbrBox.BackColor = Color.White;
            CardNbrBox.BorderStyle = BorderStyle.FixedSingle;
            CardNbrBox.Font = new Font("Segoe UI", 10F);
            CardNbrBox.ForeColor = Color.Black;
            CardNbrBox.Location = new Point(321, 132);
            CardNbrBox.Name = "CardNbrBox";
            CardNbrBox.PlaceholderText = "Card number";
            CardNbrBox.ReadOnly = true;
            CardNbrBox.Size = new Size(200, 25);
            CardNbrBox.TabIndex = 16;
            CardNbrBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 10F);
            SurnameLabel.ForeColor = Color.FromArgb(50, 50, 50);
            SurnameLabel.Location = new Point(231, 249);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(70, 19);
            SurnameLabel.TabIndex = 17;
            SurnameLabel.Text = "Surname :";
            // 
            // SurnameBox
            // 
            SurnameBox.BackColor = Color.White;
            SurnameBox.BorderStyle = BorderStyle.FixedSingle;
            SurnameBox.Font = new Font("Segoe UI", 10F);
            SurnameBox.ForeColor = Color.Black;
            SurnameBox.Location = new Point(321, 245);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.PlaceholderText = "Surname";
            SurnameBox.ReadOnly = true;
            SurnameBox.Size = new Size(200, 25);
            SurnameBox.TabIndex = 18;
            SurnameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SendDataButton
            // 
            SendDataButton.BackColor = Color.FromArgb(0, 120, 215);
            SendDataButton.Cursor = Cursors.Hand;
            SendDataButton.FlatAppearance.BorderSize = 0;
            SendDataButton.FlatStyle = FlatStyle.Flat;
            SendDataButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SendDataButton.ForeColor = Color.White;
            SendDataButton.Location = new Point(559, 395);
            SendDataButton.Name = "SendDataButton";
            SendDataButton.Size = new Size(135, 40);
            SendDataButton.TabIndex = 11;
            SendDataButton.Text = "Send";
            SendDataButton.UseVisualStyleBackColor = false;
            SendDataButton.Click += Send_Click;
            // 
            // PinConfirmBox
            // 
            PinConfirmBox.BackColor = Color.White;
            PinConfirmBox.BorderStyle = BorderStyle.FixedSingle;
            PinConfirmBox.Font = new Font("Segoe UI", 10F);
            PinConfirmBox.ForeColor = Color.Black;
            PinConfirmBox.Location = new Point(529, 359);
            PinConfirmBox.Name = "PinConfirmBox";
            PinConfirmBox.PlaceholderText = "Confirm PIN";
            PinConfirmBox.Size = new Size(200, 25);
            PinConfirmBox.TabIndex = 12;
            PinConfirmBox.TextAlign = HorizontalAlignment.Center;
            PinConfirmBox.UseSystemPasswordChar = true;
            PinConfirmBox.KeyPress += textBox1_KeyPress;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(245, 245, 245);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(932, 678);
            Controls.Add(SurnameBox);
            Controls.Add(SurnameLabel);
            Controls.Add(CardNbrBox);
            Controls.Add(SexBox);
            Controls.Add(CardNbrLabel);
            Controls.Add(SexLabel);
            Controls.Add(PinLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PinBox);
            Controls.Add(EmailBox);
            Controls.Add(ErrorLabel);
            Controls.Add(NameBox);
            Controls.Add(NameLabel);
            Controls.Add(birthBox);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(GetDataFromCardButton);
            Controls.Add(PinConfirmBox);
            Controls.Add(SendDataButton);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Sizable = false;
            Text = "Amazi ID";
            TransparencyKey = Color.FromArgb(255, 192, 255);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetDataFromCardButton;
        private Button SendDataButton;

        private Label DateOfBirthLabel;
        private TextBox birthBox;

        private Label NameLabel;
        private TextBox NameBox;

        private Label EmailLabel;
        private TextBox EmailBox;

        private TextBox PinBox;
        private TextBox PinConfirmBox;
        private Label PinLabel;

        private Label SexLabel;
        private TextBox SexBox;

        private Label CardNbrLabel;
        private TextBox CardNbrBox;

        private Label SurnameLabel;
        private TextBox SurnameBox;

        private Label ErrorLabel;
    }
}
