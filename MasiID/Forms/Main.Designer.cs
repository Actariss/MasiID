using MaterialSkin.Controls;

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
            GetDataFromCardButton = new MaterialButton();
            BirthDateBox = new MaterialTextBox2();
            NameBox = new MaterialTextBox2();
            ErrorLabel = new MaterialLabel();
            EmailBox = new MaterialTextBox2();
            PinBox = new MaterialTextBox2();
            SexBox = new MaterialTextBox2();
            CardNbrBox = new MaterialTextBox2();
            SurnameBox = new MaterialTextBox2();
            SendDataButton = new MaterialButton();
            PinConfirmBox = new MaterialTextBox2();
            MunicipalityBox = new MaterialTextBox2();
            StreetAndNumberBox = new MaterialTextBox2();
            ZipBox = new MaterialTextBox2();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // GetDataFromCardButton
            // 
            GetDataFromCardButton.AutoSize = false;
            GetDataFromCardButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GetDataFromCardButton.Density = MaterialButton.MaterialButtonDensity.Default;
            GetDataFromCardButton.Depth = 0;
            GetDataFromCardButton.HighEmphasis = true;
            GetDataFromCardButton.Icon = null;
            GetDataFromCardButton.Location = new Point(132, 544);
            GetDataFromCardButton.Margin = new Padding(4, 5, 4, 5);
            GetDataFromCardButton.MouseState = MaterialSkin.MouseState.HOVER;
            GetDataFromCardButton.Name = "GetDataFromCardButton";
            GetDataFromCardButton.NoAccentTextColor = Color.Empty;
            GetDataFromCardButton.Size = new Size(135, 35);
            GetDataFromCardButton.TabIndex = 0;
            GetDataFromCardButton.Text = "Read Card";
            GetDataFromCardButton.Type = MaterialButton.MaterialButtonType.Contained;
            GetDataFromCardButton.UseAccentColor = false;
            GetDataFromCardButton.Click += ReadDataFromCard;
            // 
            // BirthDateBox
            // 
            BirthDateBox.AnimateReadOnly = false;
            BirthDateBox.BackgroundImageLayout = ImageLayout.None;
            BirthDateBox.CharacterCasing = CharacterCasing.Normal;
            BirthDateBox.Depth = 0;
            BirthDateBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            BirthDateBox.HideSelection = true;
            BirthDateBox.Hint = "Birth Date";
            BirthDateBox.LeadingIcon = null;
            BirthDateBox.Location = new Point(293, 296);
            BirthDateBox.MaxLength = 32767;
            BirthDateBox.MouseState = MaterialSkin.MouseState.OUT;
            BirthDateBox.Name = "BirthDateBox";
            BirthDateBox.PasswordChar = '\0';
            BirthDateBox.PrefixSuffixText = null;
            BirthDateBox.ReadOnly = true;
            BirthDateBox.RightToLeft = RightToLeft.No;
            BirthDateBox.SelectedText = "";
            BirthDateBox.SelectionLength = 0;
            BirthDateBox.SelectionStart = 0;
            BirthDateBox.ShortcutsEnabled = true;
            BirthDateBox.Size = new Size(200, 48);
            BirthDateBox.TabIndex = 8;
            BirthDateBox.TabStop = false;
            BirthDateBox.TextAlign = HorizontalAlignment.Left;
            BirthDateBox.TrailingIcon = null;
            BirthDateBox.UseSystemPasswordChar = false;
            // 
            // NameBox
            // 
            NameBox.AnimateReadOnly = false;
            NameBox.BackgroundImageLayout = ImageLayout.None;
            NameBox.CharacterCasing = CharacterCasing.Normal;
            NameBox.Depth = 0;
            NameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NameBox.HideSelection = true;
            NameBox.Hint = "Name";
            NameBox.LeadingIcon = null;
            NameBox.Location = new Point(67, 188);
            NameBox.MaxLength = 32767;
            NameBox.MouseState = MaterialSkin.MouseState.OUT;
            NameBox.Name = "NameBox";
            NameBox.PasswordChar = '\0';
            NameBox.PrefixSuffixText = null;
            NameBox.ReadOnly = true;
            NameBox.RightToLeft = RightToLeft.No;
            NameBox.SelectedText = "";
            NameBox.SelectionLength = 0;
            NameBox.SelectionStart = 0;
            NameBox.ShortcutsEnabled = true;
            NameBox.Size = new Size(200, 48);
            NameBox.TabIndex = 3;
            NameBox.TabStop = false;
            NameBox.TextAlign = HorizontalAlignment.Left;
            NameBox.TrailingIcon = null;
            NameBox.UseSystemPasswordChar = false;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Depth = 0;
            ErrorLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ErrorLabel.Location = new Point(67, 484);
            ErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(426, 37);
            ErrorLabel.TabIndex = 6;
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailBox
            // 
            EmailBox.AnimateReadOnly = false;
            EmailBox.BackgroundImageLayout = ImageLayout.None;
            EmailBox.CharacterCasing = CharacterCasing.Normal;
            EmailBox.Depth = 0;
            EmailBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EmailBox.HideSelection = true;
            EmailBox.Hint = "Enter email";
            EmailBox.LeadingIcon = null;
            EmailBox.Location = new Point(67, 368);
            EmailBox.MaxLength = 32767;
            EmailBox.MouseState = MaterialSkin.MouseState.OUT;
            EmailBox.Name = "EmailBox";
            EmailBox.PasswordChar = '\0';
            EmailBox.PrefixSuffixText = null;
            EmailBox.ReadOnly = false;
            EmailBox.RightToLeft = RightToLeft.No;
            EmailBox.SelectedText = "";
            EmailBox.SelectionLength = 0;
            EmailBox.SelectionStart = 0;
            EmailBox.ShortcutsEnabled = true;
            EmailBox.Size = new Size(200, 48);
            EmailBox.TabIndex = 9;
            EmailBox.TabStop = false;
            EmailBox.TextAlign = HorizontalAlignment.Left;
            EmailBox.TrailingIcon = null;
            EmailBox.UseSystemPasswordChar = false;
            // 
            // PinBox
            // 
            PinBox.AnimateReadOnly = false;
            PinBox.BackgroundImageLayout = ImageLayout.None;
            PinBox.CharacterCasing = CharacterCasing.Normal;
            PinBox.Depth = 0;
            PinBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PinBox.HideSelection = true;
            PinBox.Hint = "Enter new account PIN";
            PinBox.LeadingIcon = null;
            PinBox.Location = new Point(67, 422);
            PinBox.MaxLength = 32767;
            PinBox.MouseState = MaterialSkin.MouseState.OUT;
            PinBox.Name = "PinBox";
            PinBox.PasswordChar = '●';
            PinBox.PrefixSuffixText = null;
            PinBox.ReadOnly = false;
            PinBox.RightToLeft = RightToLeft.No;
            PinBox.SelectedText = "";
            PinBox.SelectionLength = 0;
            PinBox.SelectionStart = 0;
            PinBox.ShortcutsEnabled = true;
            PinBox.Size = new Size(200, 48);
            PinBox.TabIndex = 10;
            PinBox.TabStop = false;
            PinBox.TextAlign = HorizontalAlignment.Left;
            PinBox.TrailingIcon = null;
            PinBox.UseSystemPasswordChar = true;
            PinBox.KeyPress += CheckDigits;
            // 
            // SexBox
            // 
            SexBox.AnimateReadOnly = false;
            SexBox.BackgroundImageLayout = ImageLayout.None;
            SexBox.CharacterCasing = CharacterCasing.Normal;
            SexBox.Depth = 0;
            SexBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SexBox.HideSelection = true;
            SexBox.Hint = "Sexe";
            SexBox.LeadingIcon = null;
            SexBox.Location = new Point(293, 134);
            SexBox.MaxLength = 32767;
            SexBox.MouseState = MaterialSkin.MouseState.OUT;
            SexBox.Name = "SexBox";
            SexBox.PasswordChar = '\0';
            SexBox.PrefixSuffixText = null;
            SexBox.ReadOnly = true;
            SexBox.RightToLeft = RightToLeft.No;
            SexBox.SelectedText = "";
            SexBox.SelectionLength = 0;
            SexBox.SelectionStart = 0;
            SexBox.ShortcutsEnabled = true;
            SexBox.Size = new Size(200, 48);
            SexBox.TabIndex = 2;
            SexBox.TabStop = false;
            SexBox.TextAlign = HorizontalAlignment.Left;
            SexBox.TrailingIcon = null;
            SexBox.UseSystemPasswordChar = false;
            // 
            // CardNbrBox
            // 
            CardNbrBox.AnimateReadOnly = false;
            CardNbrBox.BackgroundImageLayout = ImageLayout.None;
            CardNbrBox.CharacterCasing = CharacterCasing.Normal;
            CardNbrBox.Depth = 0;
            CardNbrBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CardNbrBox.HideSelection = true;
            CardNbrBox.Hint = "Card number";
            CardNbrBox.LeadingIcon = null;
            CardNbrBox.Location = new Point(67, 134);
            CardNbrBox.MaxLength = 32767;
            CardNbrBox.MouseState = MaterialSkin.MouseState.OUT;
            CardNbrBox.Name = "CardNbrBox";
            CardNbrBox.PasswordChar = '\0';
            CardNbrBox.PrefixSuffixText = null;
            CardNbrBox.ReadOnly = true;
            CardNbrBox.RightToLeft = RightToLeft.No;
            CardNbrBox.SelectedText = "";
            CardNbrBox.SelectionLength = 0;
            CardNbrBox.SelectionStart = 0;
            CardNbrBox.ShortcutsEnabled = true;
            CardNbrBox.Size = new Size(200, 48);
            CardNbrBox.TabIndex = 1;
            CardNbrBox.TabStop = false;
            CardNbrBox.TextAlign = HorizontalAlignment.Left;
            CardNbrBox.TrailingIcon = null;
            CardNbrBox.UseSystemPasswordChar = false;
            // 
            // SurnameBox
            // 
            SurnameBox.AnimateReadOnly = false;
            SurnameBox.BackgroundImageLayout = ImageLayout.None;
            SurnameBox.CharacterCasing = CharacterCasing.Normal;
            SurnameBox.Depth = 0;
            SurnameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SurnameBox.HideSelection = true;
            SurnameBox.Hint = "Surname";
            SurnameBox.LeadingIcon = null;
            SurnameBox.Location = new Point(293, 188);
            SurnameBox.MaxLength = 32767;
            SurnameBox.MouseState = MaterialSkin.MouseState.OUT;
            SurnameBox.Name = "SurnameBox";
            SurnameBox.PasswordChar = '\0';
            SurnameBox.PrefixSuffixText = null;
            SurnameBox.ReadOnly = true;
            SurnameBox.RightToLeft = RightToLeft.No;
            SurnameBox.SelectedText = "";
            SurnameBox.SelectionLength = 0;
            SurnameBox.SelectionStart = 0;
            SurnameBox.ShortcutsEnabled = true;
            SurnameBox.Size = new Size(200, 48);
            SurnameBox.TabIndex = 4;
            SurnameBox.TabStop = false;
            SurnameBox.TextAlign = HorizontalAlignment.Left;
            SurnameBox.TrailingIcon = null;
            SurnameBox.UseSystemPasswordChar = false;
            // 
            // SendDataButton
            // 
            SendDataButton.AutoSize = false;
            SendDataButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendDataButton.Density = MaterialButton.MaterialButtonDensity.Default;
            SendDataButton.Depth = 0;
            SendDataButton.HighEmphasis = true;
            SendDataButton.Icon = null;
            SendDataButton.Location = new Point(293, 544);
            SendDataButton.Margin = new Padding(4, 5, 4, 5);
            SendDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            SendDataButton.Name = "SendDataButton";
            SendDataButton.NoAccentTextColor = Color.Empty;
            SendDataButton.Size = new Size(135, 35);
            SendDataButton.TabIndex = 11;
            SendDataButton.Text = "Send";
            SendDataButton.Type = MaterialButton.MaterialButtonType.Contained;
            SendDataButton.UseAccentColor = false;
            SendDataButton.UseVisualStyleBackColor = false;
            SendDataButton.Click += Send_Click;
            // 
            // PinConfirmBox
            // 
            PinConfirmBox.AnimateReadOnly = false;
            PinConfirmBox.BackgroundImageLayout = ImageLayout.None;
            PinConfirmBox.CharacterCasing = CharacterCasing.Normal;
            PinConfirmBox.Depth = 0;
            PinConfirmBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PinConfirmBox.HideSelection = true;
            PinConfirmBox.Hint = "Confirm account PIN";
            PinConfirmBox.LeadingIcon = null;
            PinConfirmBox.Location = new Point(293, 422);
            PinConfirmBox.MaxLength = 32767;
            PinConfirmBox.MouseState = MaterialSkin.MouseState.OUT;
            PinConfirmBox.Name = "PinConfirmBox";
            PinConfirmBox.PasswordChar = '●';
            PinConfirmBox.PrefixSuffixText = null;
            PinConfirmBox.ReadOnly = false;
            PinConfirmBox.RightToLeft = RightToLeft.No;
            PinConfirmBox.SelectedText = "";
            PinConfirmBox.SelectionLength = 0;
            PinConfirmBox.SelectionStart = 0;
            PinConfirmBox.ShortcutsEnabled = true;
            PinConfirmBox.Size = new Size(200, 48);
            PinConfirmBox.TabIndex = 11;
            PinConfirmBox.TabStop = false;
            PinConfirmBox.TextAlign = HorizontalAlignment.Left;
            PinConfirmBox.TrailingIcon = null;
            PinConfirmBox.UseSystemPasswordChar = true;
            PinConfirmBox.KeyPress += CheckDigits;
            // 
            // MunicipalityBox
            // 
            MunicipalityBox.AnimateReadOnly = false;
            MunicipalityBox.BackgroundImageLayout = ImageLayout.None;
            MunicipalityBox.CharacterCasing = CharacterCasing.Normal;
            MunicipalityBox.Depth = 0;
            MunicipalityBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            MunicipalityBox.HideSelection = true;
            MunicipalityBox.Hint = "Municipality";
            MunicipalityBox.LeadingIcon = null;
            MunicipalityBox.Location = new Point(67, 296);
            MunicipalityBox.MaxLength = 32767;
            MunicipalityBox.MouseState = MaterialSkin.MouseState.OUT;
            MunicipalityBox.Name = "MunicipalityBox";
            MunicipalityBox.PasswordChar = '\0';
            MunicipalityBox.PrefixSuffixText = null;
            MunicipalityBox.ReadOnly = true;
            MunicipalityBox.RightToLeft = RightToLeft.No;
            MunicipalityBox.SelectedText = "";
            MunicipalityBox.SelectionLength = 0;
            MunicipalityBox.SelectionStart = 0;
            MunicipalityBox.ShortcutsEnabled = true;
            MunicipalityBox.Size = new Size(200, 48);
            MunicipalityBox.TabIndex = 7;
            MunicipalityBox.TabStop = false;
            MunicipalityBox.TextAlign = HorizontalAlignment.Left;
            MunicipalityBox.TrailingIcon = null;
            MunicipalityBox.UseSystemPasswordChar = false;
            // 
            // StreetAndNumberBox
            // 
            StreetAndNumberBox.AnimateReadOnly = false;
            StreetAndNumberBox.BackgroundImageLayout = ImageLayout.None;
            StreetAndNumberBox.CharacterCasing = CharacterCasing.Normal;
            StreetAndNumberBox.Depth = 0;
            StreetAndNumberBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            StreetAndNumberBox.HideSelection = true;
            StreetAndNumberBox.Hint = "Street and number";
            StreetAndNumberBox.LeadingIcon = null;
            StreetAndNumberBox.Location = new Point(67, 242);
            StreetAndNumberBox.MaxLength = 32767;
            StreetAndNumberBox.MouseState = MaterialSkin.MouseState.OUT;
            StreetAndNumberBox.Name = "StreetAndNumberBox";
            StreetAndNumberBox.PasswordChar = '\0';
            StreetAndNumberBox.PrefixSuffixText = null;
            StreetAndNumberBox.ReadOnly = true;
            StreetAndNumberBox.RightToLeft = RightToLeft.No;
            StreetAndNumberBox.SelectedText = "";
            StreetAndNumberBox.SelectionLength = 0;
            StreetAndNumberBox.SelectionStart = 0;
            StreetAndNumberBox.ShortcutsEnabled = true;
            StreetAndNumberBox.Size = new Size(200, 48);
            StreetAndNumberBox.TabIndex = 5;
            StreetAndNumberBox.TabStop = false;
            StreetAndNumberBox.TextAlign = HorizontalAlignment.Left;
            StreetAndNumberBox.TrailingIcon = null;
            StreetAndNumberBox.UseSystemPasswordChar = false;
            // 
            // ZipBox
            // 
            ZipBox.AnimateReadOnly = false;
            ZipBox.BackgroundImageLayout = ImageLayout.None;
            ZipBox.CharacterCasing = CharacterCasing.Normal;
            ZipBox.Depth = 0;
            ZipBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ZipBox.HideSelection = true;
            ZipBox.Hint = "Zip";
            ZipBox.LeadingIcon = null;
            ZipBox.Location = new Point(293, 242);
            ZipBox.MaxLength = 32767;
            ZipBox.MouseState = MaterialSkin.MouseState.OUT;
            ZipBox.Name = "ZipBox";
            ZipBox.PasswordChar = '\0';
            ZipBox.PrefixSuffixText = null;
            ZipBox.ReadOnly = true;
            ZipBox.RightToLeft = RightToLeft.No;
            ZipBox.SelectedText = "";
            ZipBox.SelectionLength = 0;
            ZipBox.SelectionStart = 0;
            ZipBox.ShortcutsEnabled = true;
            ZipBox.Size = new Size(200, 48);
            ZipBox.TabIndex = 6;
            ZipBox.TabStop = false;
            ZipBox.TextAlign = HorizontalAlignment.Left;
            ZipBox.TrailingIcon = null;
            ZipBox.UseSystemPasswordChar = false;
            // 
            // pictureBox
            // 
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(554, 136);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(172, 208);
            pictureBox.TabIndex = 22;
            pictureBox.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(792, 621);
            Controls.Add(pictureBox);
            Controls.Add(ZipBox);
            Controls.Add(StreetAndNumberBox);
            Controls.Add(MunicipalityBox);
            Controls.Add(SurnameBox);
            Controls.Add(CardNbrBox);
            Controls.Add(SexBox);
            Controls.Add(PinBox);
            Controls.Add(EmailBox);
            Controls.Add(ErrorLabel);
            Controls.Add(NameBox);
            Controls.Add(BirthDateBox);
            Controls.Add(GetDataFromCardButton);
            Controls.Add(PinConfirmBox);
            Controls.Add(SendDataButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Padding = new Padding(0);
            Sizable = false;
            Text = "Amazi ID";
            TransparencyKey = Color.FromArgb(255, 192, 255);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialButton GetDataFromCardButton;
        private MaterialButton SendDataButton;
        private MaterialTextBox2 BirthDateBox;
        private MaterialTextBox2 NameBox;
        private MaterialTextBox2 EmailBox;

        private MaterialTextBox2 PinBox;
        private MaterialTextBox2 PinConfirmBox;
        private MaterialTextBox2 SexBox;
        private MaterialTextBox2 CardNbrBox;
        private MaterialTextBox2 SurnameBox;

        private MaterialLabel ErrorLabel;

        private MaterialTextBox2 MunicipalityBox;
        private MaterialTextBox2 StreetAndNumberBox;
        private MaterialTextBox2 ZipBox;

        private PictureBox pictureBox;
    }
}
