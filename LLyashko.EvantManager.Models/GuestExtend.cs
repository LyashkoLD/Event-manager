using PropertyChanged;
using System;
using System.ComponentModel;

namespace LLyashko.EvantManager.Models
{
    [ImplementPropertyChanged]
    public class GuestExtend : INotifyPropertyChanged
    {
        Guid Id { get; set; }

        public int Friend { get; set; }

        public string Coment { get; set; }

        Guid GuestId { get; set; }

        [DoNotNotify]
        public Guest Guest { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
