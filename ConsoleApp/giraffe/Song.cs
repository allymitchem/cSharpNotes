using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace giraffe
{
    public class Song
    {
       public string title;
       public string artist;
       public int duration;
       public static int songCount = 0;
       
       public Song(string aTitle, string aArtist, int aDuration)
       {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++; //every time a song object is created, the song count is incremented
       }

    }
}