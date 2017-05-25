using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLyashko.EvantManager.Models
{
    [ImplementPropertyChanged]
    public class Event : INotifyPropertyChanged
    {        
        public DateTime Date { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public int NumberOfSeats { get; set; }

        [DoNotNotify]
        public BindingList<Guest> Guest { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
