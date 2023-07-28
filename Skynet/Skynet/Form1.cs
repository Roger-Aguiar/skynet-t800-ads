namespace Skynet
{
    public partial class Form1 : Form
    {
        List<string> listOfContacts = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonRunAds_Click(object sender, EventArgs e)
        {
            Whatsapp whatsapp = new(listOfContacts, RichTextBoxMessage.Text, "C:\\Users\\roger\\OneDrive\\Área de Trabalho\\LaptopFiles\\Agendamentos de RG\\anuncio.PNG");
            whatsapp.SendMessageWithImage();               
        }

        private void ButtonAddGroup_Click(object sender, EventArgs e)
        {
            if (TextBoxGroupName.Text == "")
            {
                MessageBox.Show("Digite o nome do grupo ou contato para adicionar na lista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxGroupName.Focus();
            }
            else
            {                
                ListBoxGroups.Items.Add(TextBoxGroupName.Text);
                listOfContacts.Add(TextBoxGroupName.Text);
                TextBoxGroupName.Clear();
            }            
        }

        private void ListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        
    }
}