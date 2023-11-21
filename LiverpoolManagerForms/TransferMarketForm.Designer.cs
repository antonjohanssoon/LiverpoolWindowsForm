namespace LiverpoolManagerForms
{
    partial class TransferMarketForm
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
            managerMenuButton = new Button();
            pictureBox1 = new PictureBox();
            transferMarketListbox = new ListBox();
            nameTextbox = new TextBox();
            nationalityTextbox = new TextBox();
            bestFootTextbox = new TextBox();
            positionTextbox = new TextBox();
            ageUpDown = new NumericUpDown();
            shirtnumberUpDown = new NumericUpDown();
            ageLabel = new Label();
            shirtnumberLabel = new Label();
            buyPlayerLabel = new Label();
            buyPlayerButton = new Button();
            addedOrRemovedLabel = new Label();
            sellPlayerButton = new Button();
            sellPlayerLabel = new Label();
            saveButton = new Button();
            loadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shirtnumberUpDown).BeginInit();
            SuspendLayout();
            // 
            // managerMenuButton
            // 
            managerMenuButton.Location = new Point(660, 30);
            managerMenuButton.Name = "managerMenuButton";
            managerMenuButton.Size = new Size(110, 60);
            managerMenuButton.TabIndex = 0;
            managerMenuButton.Text = "Back to Manager Menu";
            managerMenuButton.UseVisualStyleBackColor = true;
            managerMenuButton.Click += managerMenuButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LFC;
            pictureBox1.Location = new Point(682, 321);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // transferMarketListbox
            // 
            transferMarketListbox.FormattingEnabled = true;
            transferMarketListbox.ItemHeight = 15;
            transferMarketListbox.Location = new Point(310, 60);
            transferMarketListbox.Name = "transferMarketListbox";
            transferMarketListbox.Size = new Size(172, 319);
            transferMarketListbox.TabIndex = 11;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(62, 84);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.PlaceholderText = "Name";
            nameTextbox.Size = new Size(100, 23);
            nameTextbox.TabIndex = 12;
            // 
            // nationalityTextbox
            // 
            nationalityTextbox.Location = new Point(62, 186);
            nationalityTextbox.Name = "nationalityTextbox";
            nationalityTextbox.PlaceholderText = "Nationality";
            nationalityTextbox.Size = new Size(100, 23);
            nationalityTextbox.TabIndex = 13;
            // 
            // bestFootTextbox
            // 
            bestFootTextbox.Location = new Point(62, 286);
            bestFootTextbox.Name = "bestFootTextbox";
            bestFootTextbox.PlaceholderText = "Best foot";
            bestFootTextbox.Size = new Size(100, 23);
            bestFootTextbox.TabIndex = 14;
            // 
            // positionTextbox
            // 
            positionTextbox.Location = new Point(62, 356);
            positionTextbox.Name = "positionTextbox";
            positionTextbox.PlaceholderText = "Position";
            positionTextbox.Size = new Size(100, 23);
            positionTextbox.TabIndex = 15;
            // 
            // ageUpDown
            // 
            ageUpDown.Location = new Point(91, 135);
            ageUpDown.Name = "ageUpDown";
            ageUpDown.Size = new Size(71, 23);
            ageUpDown.TabIndex = 16;
            // 
            // shirtnumberUpDown
            // 
            shirtnumberUpDown.Location = new Point(91, 236);
            shirtnumberUpDown.Name = "shirtnumberUpDown";
            shirtnumberUpDown.Size = new Size(71, 23);
            shirtnumberUpDown.TabIndex = 17;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(57, 137);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(28, 15);
            ageLabel.TabIndex = 18;
            ageLabel.Text = "Age";
            // 
            // shirtnumberLabel
            // 
            shirtnumberLabel.AutoSize = true;
            shirtnumberLabel.Location = new Point(12, 238);
            shirtnumberLabel.Name = "shirtnumberLabel";
            shirtnumberLabel.Size = new Size(73, 15);
            shirtnumberLabel.TabIndex = 19;
            shirtnumberLabel.Text = "Shirtnumber";
            // 
            // buyPlayerLabel
            // 
            buyPlayerLabel.AutoSize = true;
            buyPlayerLabel.Location = new Point(12, 41);
            buyPlayerLabel.Name = "buyPlayerLabel";
            buyPlayerLabel.Size = new Size(263, 15);
            buyPlayerLabel.TabIndex = 20;
            buyPlayerLabel.Text = "Fill in the following information about the player";
            // 
            // buyPlayerButton
            // 
            buyPlayerButton.Location = new Point(62, 406);
            buyPlayerButton.Name = "buyPlayerButton";
            buyPlayerButton.Size = new Size(75, 23);
            buyPlayerButton.TabIndex = 21;
            buyPlayerButton.Text = "Buy player!";
            buyPlayerButton.UseVisualStyleBackColor = true;
            buyPlayerButton.Click += buyPlayerButton_Click;
            // 
            // addedOrRemovedLabel
            // 
            addedOrRemovedLabel.AutoSize = true;
            addedOrRemovedLabel.Location = new Point(310, 397);
            addedOrRemovedLabel.Name = "addedOrRemovedLabel";
            addedOrRemovedLabel.Size = new Size(38, 15);
            addedOrRemovedLabel.TabIndex = 22;
            addedOrRemovedLabel.Text = "label1";
            addedOrRemovedLabel.Visible = false;
            // 
            // sellPlayerButton
            // 
            sellPlayerButton.Location = new Point(494, 356);
            sellPlayerButton.Name = "sellPlayerButton";
            sellPlayerButton.Size = new Size(75, 23);
            sellPlayerButton.TabIndex = 23;
            sellPlayerButton.Text = "Sell player!";
            sellPlayerButton.UseVisualStyleBackColor = true;
            sellPlayerButton.Click += sellPlayerButton_Click;
            // 
            // sellPlayerLabel
            // 
            sellPlayerLabel.AutoSize = true;
            sellPlayerLabel.Location = new Point(494, 321);
            sellPlayerLabel.Name = "sellPlayerLabel";
            sellPlayerLabel.Size = new Size(0, 15);
            sellPlayerLabel.TabIndex = 24;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(660, 129);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 25;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(660, 186);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 26;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // TransferMarketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(sellPlayerLabel);
            Controls.Add(sellPlayerButton);
            Controls.Add(addedOrRemovedLabel);
            Controls.Add(buyPlayerButton);
            Controls.Add(buyPlayerLabel);
            Controls.Add(shirtnumberLabel);
            Controls.Add(ageLabel);
            Controls.Add(shirtnumberUpDown);
            Controls.Add(ageUpDown);
            Controls.Add(positionTextbox);
            Controls.Add(bestFootTextbox);
            Controls.Add(nationalityTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(transferMarketListbox);
            Controls.Add(pictureBox1);
            Controls.Add(managerMenuButton);
            Name = "TransferMarketForm";
            Text = "TransferMarketForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)shirtnumberUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button managerMenuButton;
        private PictureBox pictureBox1;
        private ListBox transferMarketListbox;
        private TextBox nameTextbox;
        private TextBox nationalityTextbox;
        private TextBox bestFootTextbox;
        private TextBox positionTextbox;
        private NumericUpDown ageUpDown;
        private NumericUpDown shirtnumberUpDown;
        private Label ageLabel;
        private Label shirtnumberLabel;
        private Label buyPlayerLabel;
        private Button buyPlayerButton;
        private Label addedOrRemovedLabel;
        private Button sellPlayerButton;
        private Label sellPlayerLabel;
        private Button saveButton;
        private Button loadButton;
    }
}