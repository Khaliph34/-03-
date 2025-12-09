using static WinFormsApp1.UsersClasses.InfoEmailSending;
using System.Net;
using System.Windows.Forms;
using WinFormsApp1.UsersClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxEmail.Text = "task_code_development@list.ru";
            textBoxName.Text = "Антон Игоревич";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // Проверка TextBox на наличие значений
            if (String.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                String.IsNullOrWhiteSpace(textBoxName.Text) ||
                String.IsNullOrWhiteSpace(textBoxSubject.Text) ||
                String.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            //Ввод данных с формы в объекты ранее созданных классов
            string smtp = "smtp.mail.ru";
            //Необходимо ввести свой mail.ru адрес!!! И мвоё ФИО
            StringPair fromInfo = new StringPair("official.works@inbox.ru", "Бахмаева Милана Руслановна");
            //Необходимо ввести свой пароль который вывел mail.ru !!!
            string password = "af3i9pkq6g0OTbmJqP0e";

            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text);
            string subject = textBoxSubject.Text;
            string body = $"{DateTime.Now}\n" +
            $"{Dns.GetHostName()}\n" +
            $"{Dns.GetHostEntry(Dns.GetHostName()).AddressList.First()}\n" +
            $"{textBoxBody.Text}";

            InfoEmailSending info =
                new InfoEmailSending(smtp, fromInfo, password, toInfo, subject, body);

            // Отправка данных в виде электронного письма
            SendingEmail sendingEmail = new SendingEmail(info);
            sendingEmail.Send();

            // Уведомление для пользователя и очистка всех TextBox
            MessageBox.Show("Письмо отправлено!");
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }
    }
}