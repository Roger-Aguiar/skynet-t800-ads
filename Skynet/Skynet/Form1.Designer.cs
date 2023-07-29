namespace Skynet
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
            ListBoxGroups = new ListBox();
            label1 = new Label();
            ButtonAddGroup = new Button();
            ButtonRunAds = new Button();
            RichTextBoxMessage = new RichTextBox();
            TextBoxGroupName = new TextBox();
            label2 = new Label();
            ButtonAddImage = new Button();
            SuspendLayout();
            // 
            // ListBoxGroups
            // 
            ListBoxGroups.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxGroups.FormattingEnabled = true;
            ListBoxGroups.ItemHeight = 20;
            ListBoxGroups.Location = new Point(12, 114);
            ListBoxGroups.Name = "ListBoxGroups";
            ListBoxGroups.Size = new Size(272, 184);
            ListBoxGroups.TabIndex = 0;
            ListBoxGroups.SelectedIndexChanged += ListBoxGroups_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite o nome nome do grupo:";
            // 
            // ButtonAddGroup
            // 
            ButtonAddGroup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAddGroup.Location = new Point(12, 65);
            ButtonAddGroup.Name = "ButtonAddGroup";
            ButtonAddGroup.Size = new Size(272, 43);
            ButtonAddGroup.TabIndex = 2;
            ButtonAddGroup.Text = "Adicionar grupo";
            ButtonAddGroup.UseVisualStyleBackColor = true;
            ButtonAddGroup.Click += ButtonAddGroup_Click;
            // 
            // ButtonRunAds
            // 
            ButtonRunAds.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRunAds.Location = new Point(12, 353);
            ButtonRunAds.Name = "ButtonRunAds";
            ButtonRunAds.Size = new Size(550, 43);
            ButtonRunAds.TabIndex = 3;
            ButtonRunAds.Text = "Anunciar";
            ButtonRunAds.UseVisualStyleBackColor = true;
            ButtonRunAds.Click += ButtonRunAds_Click;
            // 
            // RichTextBoxMessage
            // 
            RichTextBoxMessage.Location = new Point(290, 32);
            RichTextBoxMessage.Name = "RichTextBoxMessage";
            RichTextBoxMessage.Size = new Size(272, 266);
            RichTextBoxMessage.TabIndex = 4;
            RichTextBoxMessage.Text = "";
            RichTextBoxMessage.TextChanged += richTextBox1_TextChanged;
            // 
            // TextBoxGroupName
            // 
            TextBoxGroupName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxGroupName.Location = new Point(12, 32);
            TextBoxGroupName.Name = "TextBoxGroupName";
            TextBoxGroupName.Size = new Size(272, 27);
            TextBoxGroupName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(290, 9);
            label2.Name = "label2";
            label2.Size = new Size(258, 20);
            label2.TabIndex = 6;
            label2.Text = "Digite a mensagem que será enviada:";
            // 
            // ButtonAddImage
            // 
            ButtonAddImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAddImage.Location = new Point(13, 304);
            ButtonAddImage.Name = "ButtonAddImage";
            ButtonAddImage.Size = new Size(550, 43);
            ButtonAddImage.TabIndex = 7;
            ButtonAddImage.Text = "Adicionar imagem";
            ButtonAddImage.UseVisualStyleBackColor = true;
            ButtonAddImage.Click += ButtonAddImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 406);
            Controls.Add(ButtonAddImage);
            Controls.Add(label2);
            Controls.Add(TextBoxGroupName);
            Controls.Add(RichTextBoxMessage);
            Controls.Add(ButtonRunAds);
            Controls.Add(ButtonAddGroup);
            Controls.Add(label1);
            Controls.Add(ListBoxGroups);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "T-800 - Anúncios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxGroups;
        private Label label1;
        private Button ButtonAddGroup;
        private Button ButtonRunAds;
        private RichTextBox RichTextBoxMessage;
        private TextBox TextBoxGroupName;
        private Label label2;
        private Button ButtonAddImage;
    }
}