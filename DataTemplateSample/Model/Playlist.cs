using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateSample.Model
{
    public class Playlist
    {
        public Playlist(string name, int count)
        {
            this.SongName = name;
            this.Count = count;
        }
        public string SongName { get; set; }
        public int Count { get; set; }
    }
}
