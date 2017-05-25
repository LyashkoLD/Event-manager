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
    public class GuestExtend : INotifyPropertyChanged
    {
        public int Friend { get; set; }

        public string Coment { get; set; }

        [DoNotNotify]
        public Guest Guest { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
