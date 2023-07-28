namespace Skynet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonRunAds_Click(object sender, EventArgs e)
        {
            if(RichTextBoxMessage.Text == "")
            {
                MessageBox.Show("Digite a mensagem que deseja enviar aos grupos e contatos no WhatsApp!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RichTextBoxMessage.Focus();
            }
            if(ListBoxGroups.Items.Count == 0) 
            {
                MessageBox.Show("Você não adicionou nenhum grupo ou contato para enviar as mensagens, por favor, preencha a lista de contatos e grupos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxGroupName.Focus();
            }
        }

        private void ListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonAddGroup_Click(object sender, EventArgs e)
        {
            if(TextBoxGroupName.Text == "")
            {
                MessageBox.Show("Digite o nome do grupo ou contato para adicionar na lista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxGroupName.Focus();
            }
            TextBoxGroupName.Clear();
            ListBoxGroups.Items.Add(TextBoxGroupName.Text);
        }
    }
}