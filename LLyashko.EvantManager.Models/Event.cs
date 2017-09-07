using PropertyChanged;
using System;
using System.ComponentModel;

namespace LLyashko.EvantManager.Models
{
    [ImplementPropertyChanged]
    public class Event : INotifyPropertyChanged
    {
        Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public int NumberOfSeats { get; set; }

        [DoNotNotify]
        public BindingList<Guest> Guest { get; set; }

        [DoNotNotify]
        public BindingList<Guest> GuestExtendets { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
