using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Model
{
    public class Song
    {
        public string songName { get; set; }//Navn på sangen
        public string artistName { get; set; }// kunstner navn
        public string fromWhere { get; set; } // Fundet sangen i eller fra

        public Song(string songName, string artistName , string fromWhere)
        {
            this.songName = songName;
            this.artistName = artistName;
            this.fromWhere = fromWhere;

        }

        public override string ToString()
        {
            return songName + " " + artistName;
        }


    }
}
