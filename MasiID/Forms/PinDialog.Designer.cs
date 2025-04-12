using MaterialSkin.Controls;

namespace MasiID.Forms
{
    partial class PinDialog
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

        private MaterialTextBox2 PinBox;
        private MaterialButton okButton;
        private MaterialButton cancelButton;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PinBox = new MaterialTextBox2();
            okButton = new MaterialButton();
            cancelButton = new MaterialButton();
            SuspendLayout();
            // 
            // PinBox
            // 
            PinBox.AnimateReadOnly = false;
            PinBox.BackgroundImageLayout = ImageLayout.None;
            PinBox.CharacterCasing = CharacterCasing.Normal;
            PinBox.Depth = 0;
            PinBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PinBox.HideSelection = true;
            PinBox.Hint = "PIN code";
            PinBox.LeadingIcon = null;
            PinBox.Location = new Point(29, 81);
            PinBox.Margin = new Padding(2, 2, 2, 2);
            PinBox.MaxLength = 4;
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
            PinBox.Size = new Size(208, 48);
            PinBox.TabIndex = 0;
            PinBox.TabStop = false;
            PinBox.TextAlign = HorizontalAlignment.Left;
            PinBox.TrailingIcon = null;
            PinBox.UseSystemPasswordChar = true;
            // 
            // okButton
            // 
            okButton.AutoSize = false;
            okButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            okButton.Density = MaterialButton.MaterialButtonDensity.Default;
            okButton.Depth = 0;
            okButton.HighEmphasis = true;
            okButton.Icon = null;
            okButton.Location = new Point(29, 145);
            okButton.Margin = new Padding(2, 3, 2, 3);
            okButton.MouseState = MaterialSkin.MouseState.HOVER;
            okButton.Name = "okButton";
            okButton.NoAccentTextColor = Color.Empty;
            okButton.Size = new Size(90, 36);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.Type = MaterialButton.MaterialButtonType.Contained;
            okButton.UseAccentColor = false;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = false;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(147, 145);
            cancelButton.Margin = new Padding(2, 3, 2, 3);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(90, 36);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Annuler";
            cancelButton.Type = MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // PinDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 203);
            Controls.Add(PinBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PinDialog";
            Padding = new Padding(2, 32, 2, 2);
            Text = "Enter Card PIN";
            ResumeLayout(false);
        }

        #endregion
    }
}