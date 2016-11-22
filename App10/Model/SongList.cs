using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    class SongList : ObservableCollection<Song>
    {
        public SongList() : base()
        {
                Song song1 = new Song("Get up", "Chinese man", "Roskilde14");
        }

    }
}
