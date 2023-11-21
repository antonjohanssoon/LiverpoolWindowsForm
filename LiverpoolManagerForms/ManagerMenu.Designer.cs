namespace LiverpoolManagerForms
{
    partial class ManagerMenu
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
            managerMenuLabel = new Label();
            availablePlayersButton = new Button();
            transferMarketButton = new Button();
            pictureBox1 = new PictureBox();
            quitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // managerMenuLabel
            // 
            managerMenuLabel.AutoSize = true;
            managerMenuLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            managerMenuLabel.Location = new Point(189, 73);
            managerMenuLabel.Name = "managerMenuLabel";
            managerMenuLabel.Size = new Size(431, 37);
            managerMenuLabel.TabIndex = 0;
            managerMenuLabel.Text = "Welcome to the Manager Menu!";
            // 
            // availablePlayersButton
            // 
            availablePlayersButton.Location = new Point(189, 172);
            availablePlayersButton.Name = "availablePlayersButton";
            availablePlayersButton.Size = new Size(75, 46);
            availablePlayersButton.TabIndex = 1;
            availablePlayersButton.Text = "Available players";
            availablePlayersButton.UseVisualStyleBackColor = true;
            availablePlayersButton.Click += availablePlayersButton_Click;
            // 
            // transferMarketButton
            // 
            transferMarketButton.Location = new Point(528, 172);
            transferMarketButton.Name = "transferMarketButton";
            transferMarketButton.Size = new Size(75, 46);
            transferMarketButton.TabIndex = 2;
            transferMarketButton.Text = "Transfer market";
            transferMarketButton.UseVisualStyleBackColor = true;
            transferMarketButton.Click += transferMarketButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LFC;
            pictureBox1.Location = new Point(303, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(674, 12);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(115, 40);
            quitButton.TabIndex = 4;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quitButton);
            Controls.Add(pictureBox1);
            Controls.Add(transferMarketButton);
            Controls.Add(availablePlayersButton);
            Controls.Add(managerMenuLabel);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label managerMenuLabel;
        private Button availablePlayersButton;
        private Button transferMarketButton;
        private PictureBox pictureBox1;
        private Button quitButton;
    }
}