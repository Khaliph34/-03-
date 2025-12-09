using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1.UsersClasses
{
    public class InfoEmailSending
    {
        public InfoEmailSending(string smtpClientAddress,
        StringPair emailAddressFrom,
        string emailPassword,
        StringPair emailAddressTo,
        string subject,
        string body)
        {
            SmtpClientAddress = String.IsNullOrWhiteSpace(smtpClientAddress) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
                smtpClientAddress;
            EmailAddressFrom = emailAddressFrom ?? throw new ArgumentNullException(nameof(emailAddressFrom));
            EmailPassword = String.IsNullOrWhiteSpace(emailPassword) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
                emailPassword;
            EmailAddressTo = emailAddressTo ?? throw new ArgumentNullException(nameof(emailAddressTo));
            Subject = subject ?? throw new ArgumentNullException(nameof(Subject));
            Body = body ?? throw new ArgumentNullException(nameof(Body));
        }

        public string SmtpClientAddress { get; set; }
        public StringPair EmailAddressFrom { get; set; }
        public string EmailPassword { get; set; }
        public StringPair EmailAddressTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class StringPair
    {
        public StringPair(string emailAdress, string name)
        {
            EmailAdress = String.IsNullOrWhiteSpace(emailAdress) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
                emailAdress;
            Name = String.IsNullOrWhiteSpace(name) ?
                throw new Exception("Нельзя вставлять пробелы или пустое значение!") :
                name;
        }

        public string EmailAdress { get; set; }
        public string Name { get; set; }
    }
}
