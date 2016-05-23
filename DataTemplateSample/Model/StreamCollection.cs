using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateSample.Model
{
    public class StreamCollection
    {
        public StreamCollection(Playlist list, Track track)
        {
            this.PlayList = list;
            this.Track = track;
        }
        public Playlist PlayList { get; set; }
        public Track Track { get; set; }
    }
}
