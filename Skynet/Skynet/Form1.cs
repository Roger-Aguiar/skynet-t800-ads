namespace Skynet
{
    public partial class Form1 : Form
    {
        List<Contacts> listOfContacts = new();
        private string imagePath = string.Empty;

        public Form1()
        {
            FormSplashScreen splashScreen = new();
            splashScreen.Show();
            Thread.Sleep(5000);
            splashScreen.Close();
            InitializeComponent();
        }

        #region Private methods

        private List<Contacts> GetListOfContacts()
        {
            listOfContacts.Add(new Contacts() { Name = "Roger Aguiar (Claro)", ImagePath = imagePath, Message = "Link do formulário: https://forms.gle/xapoBFxstzGcvRaVA" });
            listOfContacts.Add(new Contacts() { Name = "André", ImagePath = imagePath, Message = "Testando o robô para envio de mensagem com imagem! Huhahahaha - Link do formulário: https://forms.gle/xapoBFxstzGcvRaVA" });
            return listOfContacts;
        }
        #endregion

        private void ButtonRunAds_Click(object sender, EventArgs e)
        {
            Whatsapp whatsapp = new(GetListOfContacts());
            whatsapp.SendMessageWithImage();
        }

        private void ButtonAddGroup_Click(object sender, EventArgs e)
        {
            foreach (var contact in listOfContacts)
                ListBoxGroups.Items.Add(contact.Name);
        }

        private void ListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new();
            open.ShowDialog();
            imagePath = open.FileName;
            MessageBox.Show("Imagem adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}