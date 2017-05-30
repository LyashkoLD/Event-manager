using PropertyChanged;
using System.ComponentModel;

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
