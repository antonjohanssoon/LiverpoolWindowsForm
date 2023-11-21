namespace LiverpoolManagerForms
{
    public partial class TransferMarketForm : Form
    {
        public Manager manager;
        public ManagerMenu managerMenu;
        public AvailablePlayersForm availablePlayersForm;

        public TransferMarketForm(Manager manager, AvailablePlayersForm availablePlayers)
        {
            InitializeComponent();
            this.manager = manager;
            this.availablePlayersForm = availablePlayers;

            foreach (Player player in manager.playersList)
            {
                transferMarketListbox.Items.Add(player.Name);
            }
        }


        private void buyPlayerButton_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player(nameTextbox.Text, (int)ageUpDown.Value, nationalityTextbox.Text,
                                      (int)shirtnumberUpDown.Value, bestFootTextbox.Text, positionTextbox.Text);
            manager.playersList.Add(newPlayer);
            availablePlayersForm.updateAvailablePlayersListBox(newPlayer);
            transferMarketListbox.Items.Add(newPlayer.Name);
            addedOrRemovedLabel.Text = newPlayer.Name + " has signed for the club!";
            addedOrRemovedLabel.Visible = true;
            nameTextbox.Clear();
            ageUpDown.Value = 0;
            nationalityTextbox.Clear();
            shirtnumberUpDown.Value = 0;
            bestFootTextbox.Clear();
            positionTextbox.Clear();
        }

        private void managerMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            managerMenu.Show();
        }


        private void sellPlayerButton_Click(object sender, EventArgs e)
        {
            int index = transferMarketListbox.SelectedIndex;
            if (index > -1)
            {
                Player player = manager.playersList[index];

                manager.playersList.RemoveAt(index);
                transferMarketListbox.Items.RemoveAt(index);
                availablePlayersForm.sellPlayerUpdate();

                addedOrRemovedLabel.Text = player.Name + " has been sold from the club!";
                addedOrRemovedLabel.Visible = true;
            }
        }

        string folderPath = "playersFolder";
        string path = "playersFolder/availablePlayers.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(folderPath);

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("Name, Age, Nationality, Shirtnumber, Best foot, Position");

                foreach (Player player in manager.playersList)
                {
                    streamWriter.WriteLine(player.getCSV());
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            manager.playersList.Clear();
            transferMarketListbox.Items.Clear();

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    streamReader.ReadLine();
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        string[] strings = line.Split(',');

                        string Name = strings[0];
                        int Age = Convert.ToInt32(strings[1]);
                        string Nationality = strings[2];
                        int Shirtnumber = Convert.ToInt32(strings[3]);
                        string BestFoot = strings[4];
                        string Position = strings[5];

                        Player player = new Player(Name, Age, Nationality, Shirtnumber, BestFoot, Position);
                        manager.playersList.Add(player);
                        transferMarketListbox.Items.Add(player.Name);
                        availablePlayersForm.updateAvailablePlayersListBox(player);
                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}