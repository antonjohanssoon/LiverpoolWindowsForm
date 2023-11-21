namespace LiverpoolManagerForms
{
    public partial class ManagerMenu : Form
    {

        AvailablePlayersForm availablePlayersForm;
        TransferMarketForm transferMarketForm;

        public ManagerMenu()
        {
            InitializeComponent();
            Manager manager = new Manager();
            availablePlayersForm = new AvailablePlayersForm(manager);
            transferMarketForm = new TransferMarketForm(manager, availablePlayersForm);
            availablePlayersForm.managerMenu = this;
            transferMarketForm.managerMenu = this;
        }

        private void availablePlayersButton_Click(object sender, EventArgs e)
        {
            Hide();
            availablePlayersForm.Show();
        }

        private void transferMarketButton_Click(object sender, EventArgs e)
        {
            Hide();
            transferMarketForm.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
