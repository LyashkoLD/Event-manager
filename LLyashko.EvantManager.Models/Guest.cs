using PropertyChanged;
using System.ComponentModel;
using System.Net.Mail;

namespace LLyashko.EvantManager.Models
{
    [ImplementPropertyChanged]
    public class Guest : INotifyPropertyChanged
    {
        string Name { get; set; }

        string SureName { get; set; }

        string PhoneNumber { get; set; }

        MailAddress MailAddress { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
