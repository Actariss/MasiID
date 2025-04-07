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
            birthBox = new MaterialTextBox2();
            NameBox = new MaterialTextBox2();
            ErrorLabel = new MaterialLabel();
            EmailBox = new MaterialTextBox2();
            PinBox = new MaterialTextBox2();
            SexBox = new MaterialTextBox2();
            CardNbrBox = new MaterialTextBox2();
            SurnameBox = new MaterialTextBox2();
            SendDataButton = new MaterialButton();
            PinConfirmBox = new MaterialTextBox2();
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
            GetDataFromCardButton.Location = new Point(332, 442);
            GetDataFromCardButton.Margin = new Padding(4, 5, 4, 5);
            GetDataFromCardButton.MouseState = MaterialSkin.MouseState.HOVER;
            GetDataFromCardButton.Name = "GetDataFromCardButton";
            GetDataFromCardButton.NoAccentTextColor = Color.Empty;
            GetDataFromCardButton.Size = new Size(135, 35);
            GetDataFromCardButton.TabIndex = 0;
            GetDataFromCardButton.Text = "Read Card";
            GetDataFromCardButton.Type = MaterialButton.MaterialButtonType.Contained;
            GetDataFromCardButton.UseAccentColor = false;
            GetDataFromCardButton.Click += get_Data_From_Card;
            // 
            // birthBox
            // 
            birthBox.AnimateReadOnly = false;
            birthBox.BackgroundImageLayout = ImageLayout.None;
            birthBox.CharacterCasing = CharacterCasing.Normal;
            birthBox.Depth = 0;
            birthBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            birthBox.HideSelection = true;
            birthBox.Hint = "Birth Date";
            birthBox.LeadingIcon = null;
            birthBox.Location = new Point(403, 118);
            birthBox.MaxLength = 32767;
            birthBox.MouseState = MaterialSkin.MouseState.OUT;
            birthBox.Name = "birthBox";
            birthBox.PasswordChar = '\0';
            birthBox.PrefixSuffixText = null;
            birthBox.ReadOnly = true;
            birthBox.RightToLeft = RightToLeft.No;
            birthBox.SelectedText = "";
            birthBox.SelectionLength = 0;
            birthBox.SelectionStart = 0;
            birthBox.ShortcutsEnabled = true;
            birthBox.Size = new Size(200, 48);
            birthBox.TabIndex = 3;
            birthBox.TabStop = false;
            birthBox.TextAlign = HorizontalAlignment.Left;
            birthBox.TrailingIcon = null;
            birthBox.UseSystemPasswordChar = false;
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
            NameBox.Location = new Point(197, 172);
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
            NameBox.TabIndex = 5;
            NameBox.TabStop = false;
            NameBox.TextAlign = HorizontalAlignment.Left;
            NameBox.TrailingIcon = null;
            NameBox.UseSystemPasswordChar = false;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Depth = 0;
            ErrorLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ErrorLabel.Location = new Point(197, 400);
            ErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(406, 37);
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
            EmailBox.Location = new Point(197, 280);
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
            EmailBox.TabIndex = 7;
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
            PinBox.Hint = "Enter PIN code";
            PinBox.LeadingIcon = null;
            PinBox.Location = new Point(197, 334);
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
            PinBox.TabIndex = 8;
            PinBox.TabStop = false;
            PinBox.TextAlign = HorizontalAlignment.Left;
            PinBox.TrailingIcon = null;
            PinBox.UseSystemPasswordChar = true;
            PinBox.KeyPress += textBox1_KeyPress;
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
            SexBox.Location = new Point(197, 226);
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
            SexBox.TabIndex = 15;
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
            CardNbrBox.Location = new Point(197, 118);
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
            CardNbrBox.TabIndex = 16;
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
            SurnameBox.Location = new Point(403, 172);
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
            SurnameBox.TabIndex = 18;
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
            SendDataButton.Location = new Point(332, 487);
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
            PinConfirmBox.Hint = "Confirm PIN";
            PinConfirmBox.LeadingIcon = null;
            PinConfirmBox.Location = new Point(403, 334);
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
            PinConfirmBox.TabIndex = 12;
            PinConfirmBox.TabStop = false;
            PinConfirmBox.TextAlign = HorizontalAlignment.Left;
            PinConfirmBox.TrailingIcon = null;
            PinConfirmBox.UseSystemPasswordChar = true;
            PinConfirmBox.KeyPress += textBox1_KeyPress;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 600);
            Controls.Add(SurnameBox);
            Controls.Add(CardNbrBox);
            Controls.Add(SexBox);
            Controls.Add(PinBox);
            Controls.Add(EmailBox);
            Controls.Add(ErrorLabel);
            Controls.Add(NameBox);
            Controls.Add(birthBox);
            Controls.Add(GetDataFromCardButton);
            Controls.Add(PinConfirmBox);
            Controls.Add(SendDataButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Padding = new Padding(3, 56, 3, 3);
            Sizable = false;
            Text = "Amazi ID";
            TransparencyKey = Color.FromArgb(255, 192, 255);
            ResumeLayout(false);
        }

        #endregion

        private MaterialButton GetDataFromCardButton;
        private MaterialButton SendDataButton;
        private MaterialTextBox2 birthBox;
        private MaterialTextBox2 NameBox;
        private MaterialTextBox2 EmailBox;

        private MaterialTextBox2 PinBox;
        private MaterialTextBox2 PinConfirmBox;
        private MaterialTextBox2 SexBox;
        private MaterialTextBox2 CardNbrBox;
        private MaterialTextBox2 SurnameBox;

        private MaterialLabel ErrorLabel;
    }
}
