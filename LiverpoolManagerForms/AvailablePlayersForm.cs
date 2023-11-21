namespace LiverpoolManagerForms
{
    public partial class AvailablePlayersForm : Form
    {
        public ManagerMenu managerMenu;
        public TransferMarketForm transferMarketForm;
        public Manager manager;
        public Player player;

        public AvailablePlayersForm(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;

            foreach (Player player in manager.playersList)
            {
                availablePlayersListbox.Items.Add(player.Name);
            }
        }

        public void updateAvailablePlayersListBox(Player player)
        {
            availablePlayersListbox.Items.Add(player.Name);
        }
        public void sellPlayerUpdate()
        {
            availablePlayersListbox.Items.Clear();

            foreach (Player player in manager.playersList)
            {
                availablePlayersListbox.Items.Add(player.Name);
            }
        }

        public void managerMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            managerMenu.Show();
        }


        public void availablePlayersListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = availablePlayersListbox.SelectedIndex;
            if (index >= 0)
            {
                string selectedPlayerName = (string)availablePlayersListbox.SelectedItem;
                Player selectedPlayer = manager.playersList.Find(player => player.Name == selectedPlayerName);

                if (selectedPlayer != null)
                {
                    playerNameLabel.Text = "Name: " + selectedPlayer.Name;
                    playerAgeLabel.Text = "Age: " + selectedPlayer.Age;
                    playerNationalityLabel.Text = "Nationality: " + selectedPlayer.Nationality;
                    playerShirtNumberLabel.Text = "Shirtnumber: " + selectedPlayer.ShirtNumber;
                    playerBestFootLabel.Text = "Best foot: " + selectedPlayer.BestFoot;
                    playerPositionLabel.Text = "Position: " + selectedPlayer.Position;
                    playerNameLabel.Show();
                    playerAgeLabel.Show();
                    playerNationalityLabel.Show();
                    playerShirtNumberLabel.Show();
                    playerBestFootLabel.Show();
                    playerPositionLabel.Show();
                }

            }
        }
    }
}
