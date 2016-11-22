using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using App10.Model;

namespace App10.ModelView
{

    class SongViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }


        }
        #endregion

        public SongList SongList1 { get; set; }

        public AddSongCommand AddSongCommand { get; set;}

        public SongViewModel()
        {
            SongList Songlist1 = new SongList();
            AddSongCommand AddS1 = new AddSongCommand();
            
        }

    }
}
                                    