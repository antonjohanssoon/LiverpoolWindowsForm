namespace LiverpoolManagerForms
{
    partial class AvailablePlayersForm
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
            availablePlayersListbox = new ListBox();
            availablePlayersLabel = new Label();
            informationLabel = new Label();
            playerNameLabel = new Label();
            playerAgeLabel = new Label();
            playerNationalityLabel = new Label();
            playerShirtNumberLabel = new Label();
            playerBestFootLabel = new Label();
            playerPositionLabel = new Label();
            pictureBox1 = new PictureBox();
            managerMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // availablePlayersListbox
            // 
            availablePlayersListbox.FormattingEnabled = true;
            availablePlayersListbox.ItemHeight = 15;
            availablePlayersListbox.Location = new Point(39, 94);
            availablePlayersListbox.Name = "availablePlayersListbox";
            availablePlayersListbox.Size = new Size(216, 304);
            availablePlayersListbox.TabIndex = 0;
            availablePlayersListbox.SelectedIndexChanged += availablePlayersListbox_SelectedIndexChanged;
            // 
            // availablePlayersLabel
            // 
            availablePlayersLabel.AutoSize = true;
            availablePlayersLabel.Location = new Point(39, 62);
            availablePlayersLabel.Name = "availablePlayersLabel";
            availablePlayersLabel.Size = new Size(296, 15);
            availablePlayersLabel.TabIndex = 1;
            availablePlayersLabel.Text = "Here you can see all your available players in the squad";
            // 
            // informationLabel
            // 
            informationLabel.AutoSize = true;
            informationLabel.Location = new Point(274, 103);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(216, 15);
            informationLabel.TabIndex = 2;
            informationLabel.Text = "Select a player to see more information:";
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.Location = new Point(281, 139);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(38, 15);
            playerNameLabel.TabIndex = 3;
            playerNameLabel.Text = "label1";
            playerNameLabel.Visible = false;
            // 
            // playerAgeLabel
            // 
            playerAgeLabel.AutoSize = true;
            playerAgeLabel.Location = new Point(281, 191);
            playerAgeLabel.Name = "playerAgeLabel";
            playerAgeLabel.Size = new Size(38, 15);
            playerAgeLabel.TabIndex = 4;
            playerAgeLabel.Text = "label2";
            playerAgeLabel.Visible = false;
            // 
            // playerNationalityLabel
            // 
            playerNationalityLabel.AutoSize = true;
            playerNationalityLabel.Location = new Point(281, 240);
            playerNationalityLabel.Name = "playerNationalityLabel";
            playerNationalityLabel.Size = new Size(38, 15);
            playerNationalityLabel.TabIndex = 5;
            playerNationalityLabel.Text = "label3";
            playerNationalityLabel.Visible = false;
            // 
            // playerShirtNumberLabel
            // 
            playerShirtNumberLabel.AutoSize = true;
            playerShirtNumberLabel.Location = new Point(281, 288);
            playerShirtNumberLabel.Name = "playerShirtNumberLabel";
            playerShirtNumberLabel.Size = new Size(38, 15);
            playerShirtNumberLabel.TabIndex = 6;
            playerShirtNumberLabel.Text = "label4";
            playerShirtNumberLabel.Visible = false;
            // 
            // playerBestFootLabel
            // 
            playerBestFootLabel.AutoSize = true;
            playerBestFootLabel.Location = new Point(281, 336);
            playerBestFootLabel.Name = "playerBestFootLabel";
            playerBestFootLabel.Size = new Size(38, 15);
            playerBestFootLabel.TabIndex = 7;
            playerBestFootLabel.Text = "label5";
            playerBestFootLabel.Visible = false;
            // 
            // playerPositionLabel
            // 
            playerPositionLabel.AutoSize = true;
            playerPositionLabel.Location = new Point(281, 383);
            playerPositionLabel.Name = "playerPositionLabel";
            playerPositionLabel.Size = new Size(38, 15);
            playerPositionLabel.TabIndex = 8;
            playerPositionLabel.Text = "label6";
            playerPositionLabel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LFC;
            pictureBox1.Location = new Point(682, 321);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // managerMenuButton
            // 
            managerMenuButton.Location = new Point(682, 34);
            managerMenuButton.Name = "managerMenuButton";
            managerMenuButton.Size = new Size(98, 43);
            managerMenuButton.TabIndex = 10;
            managerMenuButton.Text = "Back to Manager Menu";
            managerMenuButton.UseVisualStyleBackColor = true;
            managerMenuButton.Click += managerMenuButton_Click;
            // 
            // AvailablePlayersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(managerMenuButton);
            Controls.Add(pictureBox1);
            Controls.Add(playerPositionLabel);
            Controls.Add(playerBestFootLabel);
            Controls.Add(playerShirtNumberLabel);
            Controls.Add(playerNationalityLabel);
            Controls.Add(playerAgeLabel);
            Controls.Add(playerNameLabel);
            Controls.Add(informationLabel);
            Controls.Add(availablePlayersLabel);
            Controls.Add(availablePlayersListbox);
            Name = "AvailablePlayersForm";
            Text = "AvailablePlayersForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox availablePlayersListbox;
        private Label availablePlayersLabel;
        private Label informationLabel;
        private Label playerNameLabel;
        private Label playerAgeLabel;
        private Label playerNationalityLabel;
        private Label playerShirtNumberLabel;
        private Label playerBestFootLabel;
        private Label playerPositionLabel;
        private PictureBox pictureBox1;
        private Button managerMenuButton;
    }
}