using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateSample.Model
{
    public class Track
    {
        public Track(string name)
        {
            this.TrackName = name;
        }
        public String TrackName{get;set;}
    }
}
