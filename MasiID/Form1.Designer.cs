namespace MasiID
{
    partial class Form1
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
            GetDataFromCard = new Button();
            Date_of_birth = new Label();
            birthBox = new TextBox();
            Name_label = new Label();
            nameBox = new TextBox();
            Error_field = new Label();
            emailBox = new TextBox();
            pinBox = new TextBox();
            Email_Field = new Label();
            Pin_Field = new Label();
            Send = new Button();
            pinConfirmBox = new TextBox();
            Sex_label = new Label();
            cardNbrLabel = new Label();
            sexBox = new TextBox();
            cardNbrBox = new TextBox();
            surnameLabel = new Label();
            surnameBox = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GetDataFromCard
            // 
            GetDataFromCard.BackColor = Color.FromArgb(0, 120, 215);
            GetDataFromCard.Cursor = Cursors.Hand;
            GetDataFromCard.FlatAppearance.BorderSize = 0;
            GetDataFromCard.FlatStyle = FlatStyle.Flat;
            GetDataFromCard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            GetDataFromCard.ForeColor = Color.White;
            GetDataFromCard.Location = new Point(382, 354);
            GetDataFromCard.Name = "GetDataFromCard";
            GetDataFromCard.Size = new Size(135, 40);
            GetDataFromCard.TabIndex = 0;
            GetDataFromCard.Text = "Read Card";
            GetDataFromCard.UseVisualStyleBackColor = false;
            GetDataFromCard.Click += get_Data_From_Card;
            // 
            // Date_of_birth
            // 
            Date_of_birth.AutoSize = true;
            Date_of_birth.Font = new Font("Segoe UI", 10F);
            Date_of_birth.ForeColor = Color.FromArgb(50, 50, 50);
            Date_of_birth.Location = new Point(262, 130);
            Date_of_birth.Name = "Date_of_birth";
            Date_of_birth.Size = new Size(116, 23);
            Date_of_birth.TabIndex = 1;
            Date_of_birth.Text = "Date of birth :";
            // 
            // birthBox
            // 
            birthBox.BackColor = Color.White;
            birthBox.BorderStyle = BorderStyle.FixedSingle;
            birthBox.Font = new Font("Segoe UI", 10F);
            birthBox.ForeColor = Color.Black;
            birthBox.Location = new Point(382, 126);
            birthBox.Name = "birthBox";
            birthBox.PlaceholderText = "Birth Date";
            birthBox.ReadOnly = true;
            birthBox.Size = new Size(202, 30);
            birthBox.TabIndex = 3;
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Segoe UI", 10F);
            Name_label.ForeColor = Color.FromArgb(50, 50, 50);
            Name_label.Location = new Point(230, 244);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(152, 23);
            Name_label.TabIndex = 4;
            Name_label.Text = "Name of the user :";
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.White;
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Font = new Font("Segoe UI", 10F);
            nameBox.ForeColor = Color.Black;
            nameBox.Location = new Point(382, 240);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(202, 30);
            nameBox.TabIndex = 5;
            // 
            // Error_field
            // 
            Error_field.AutoSize = true;
            Error_field.Font = new Font("Segoe UI", 10F);
            Error_field.ForeColor = Color.FromArgb(50, 50, 50);
            Error_field.Location = new Point(513, 406);
            Error_field.Name = "Error_field";
            Error_field.Size = new Size(0, 23);
            Error_field.TabIndex = 6;
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.White;
            emailBox.BorderStyle = BorderStyle.FixedSingle;
            emailBox.Font = new Font("Segoe UI", 10F);
            emailBox.ForeColor = Color.Black;
            emailBox.Location = new Point(382, 278);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Enter email";
            emailBox.Size = new Size(202, 30);
            emailBox.TabIndex = 7;
            // 
            // pinBox
            // 
            pinBox.BackColor = Color.White;
            pinBox.BorderStyle = BorderStyle.FixedSingle;
            pinBox.Font = new Font("Segoe UI", 10F);
            pinBox.ForeColor = Color.Black;
            pinBox.Location = new Point(382, 316);
            pinBox.Name = "pinBox";
            pinBox.PlaceholderText = "Enter PIN code";
            pinBox.Size = new Size(202, 30);
            pinBox.TabIndex = 8;
            pinBox.UseSystemPasswordChar = true;
            pinBox.KeyPress += textBox1_KeyPress;
            // 
            // Email_Field
            // 
            Email_Field.AutoSize = true;
            Email_Field.Font = new Font("Segoe UI", 10F);
            Email_Field.ForeColor = Color.FromArgb(50, 50, 50);
            Email_Field.Location = new Point(316, 282);
            Email_Field.Name = "Email_Field";
            Email_Field.Size = new Size(60, 23);
            Email_Field.TabIndex = 9;
            Email_Field.Text = "Email :";
            // 
            // Pin_Field
            // 
            Pin_Field.AutoSize = true;
            Pin_Field.Font = new Font("Segoe UI", 10F);
            Pin_Field.ForeColor = Color.FromArgb(50, 50, 50);
            Pin_Field.Location = new Point(288, 320);
            Pin_Field.Name = "Pin_Field";
            Pin_Field.Size = new Size(92, 23);
            Pin_Field.TabIndex = 10;
            Pin_Field.Text = "Code PIN :";
            // 
            // Send
            // 
            Send.BackColor = Color.FromArgb(0, 120, 215);
            Send.Cursor = Cursors.Hand;
            Send.FlatAppearance.BorderSize = 0;
            Send.FlatStyle = FlatStyle.Flat;
            Send.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Send.ForeColor = Color.White;
            Send.Location = new Point(455, 308);
            Send.Name = "Send";
            Send.Size = new Size(135, 40);
            Send.TabIndex = 11;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            // 
            // pinConfirmBox
            // 
            pinConfirmBox.BackColor = Color.White;
            pinConfirmBox.BorderStyle = BorderStyle.FixedSingle;
            pinConfirmBox.Font = new Font("Segoe UI", 10F);
            pinConfirmBox.ForeColor = Color.Black;
            pinConfirmBox.Location = new Point(388, 270);
            pinConfirmBox.Name = "pinConfirmBox";
            pinConfirmBox.PlaceholderText = "Confirm PIN";
            pinConfirmBox.Size = new Size(202, 30);
            pinConfirmBox.TabIndex = 12;
            pinConfirmBox.UseSystemPasswordChar = true;
            pinConfirmBox.KeyPress += textBox1_KeyPress;
            // 
            // Sex_label
            // 
            Sex_label.AutoSize = true;
            Sex_label.Font = new Font("Segoe UI", 10F);
            Sex_label.ForeColor = Color.FromArgb(50, 50, 50);
            Sex_label.Location = new Point(323, 168);
            Sex_label.Name = "Sex_label";
            Sex_label.Size = new Size(54, 23);
            Sex_label.TabIndex = 13;
            Sex_label.Text = "Sexe :";
            // 
            // cardNbrLabel
            // 
            cardNbrLabel.AutoSize = true;
            cardNbrLabel.Font = new Font("Segoe UI", 10F);
            cardNbrLabel.ForeColor = Color.FromArgb(50, 50, 50);
            cardNbrLabel.Location = new Point(261, 92);
            cardNbrLabel.Name = "cardNbrLabel";
            cardNbrLabel.Size = new Size(120, 23);
            cardNbrLabel.TabIndex = 14;
            cardNbrLabel.Text = "Card number :";
            // 
            // sexBox
            // 
            sexBox.BackColor = Color.White;
            sexBox.BorderStyle = BorderStyle.FixedSingle;
            sexBox.Font = new Font("Segoe UI", 10F);
            sexBox.ForeColor = Color.Black;
            sexBox.Location = new Point(382, 164);
            sexBox.Name = "sexBox";
            sexBox.PlaceholderText = "Sexe";
            sexBox.ReadOnly = true;
            sexBox.Size = new Size(202, 30);
            sexBox.TabIndex = 15;
            // 
            // cardNbrBox
            // 
            cardNbrBox.BackColor = Color.White;
            cardNbrBox.BorderStyle = BorderStyle.FixedSingle;
            cardNbrBox.Font = new Font("Segoe UI", 10F);
            cardNbrBox.ForeColor = Color.Black;
            cardNbrBox.Location = new Point(382, 89);
            cardNbrBox.Name = "cardNbrBox";
            cardNbrBox.PlaceholderText = "Card number";
            cardNbrBox.ReadOnly = true;
            cardNbrBox.Size = new Size(202, 30);
            cardNbrBox.TabIndex = 16;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI", 10F);
            surnameLabel.ForeColor = Color.FromArgb(50, 50, 50);
            surnameLabel.Location = new Point(292, 206);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(87, 23);
            surnameLabel.TabIndex = 17;
            surnameLabel.Text = "Surname :";
            // 
            // surnameBox
            // 
            surnameBox.BackColor = Color.White;
            surnameBox.BorderStyle = BorderStyle.FixedSingle;
            surnameBox.Font = new Font("Segoe UI", 10F);
            surnameBox.ForeColor = Color.Black;
            surnameBox.Location = new Point(382, 202);
            surnameBox.Name = "surnameBox";
            surnameBox.PlaceholderText = "Surname";
            surnameBox.ReadOnly = true;
            surnameBox.Size = new Size(202, 30);
            surnameBox.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pinConfirmBox);
            panel1.Controls.Add(Send);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(202, 46);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(22, 23, 22, 23);
            panel1.Size = new Size(638, 460);
            panel1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(987, 586);
            Controls.Add(surnameBox);
            Controls.Add(surnameLabel);
            Controls.Add(cardNbrBox);
            Controls.Add(sexBox);
            Controls.Add(cardNbrLabel);
            Controls.Add(Sex_label);
            Controls.Add(Pin_Field);
            Controls.Add(Email_Field);
            Controls.Add(pinBox);
            Controls.Add(emailBox);
            Controls.Add(Error_field);
            Controls.Add(nameBox);
            Controls.Add(Name_label);
            Controls.Add(birthBox);
            Controls.Add(Date_of_birth);
            Controls.Add(GetDataFromCard);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.FromArgb(255, 192, 255);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetDataFromCard;
        private Label Date_of_birth;
        private TextBox birthBox;
        private Label Name_label;
        private TextBox nameBox;
        private Label Error_field;
        private TextBox emailBox;
        private TextBox pinBox;
        private Label Email_Field;
        private Label Pin_Field;
        private Button Send;
        private TextBox pinConfirmBox;
        private Label Sex_label;
        private Label cardNbrLabel;
        private TextBox sexBox;
        private TextBox cardNbrBox;
        private Label surnameLabel;
        private TextBox surnameBox;
        private Panel panel1;
    }
}
