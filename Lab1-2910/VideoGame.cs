using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2910
{
    public class VideoGame : IComparable<VideoGame>
    {
        public string Title { get; set; }
        public string Platform { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }

        public int CompareTo(VideoGame other)
        {
            return string.Compare(this.Title, other.Title, StringComparison.Ordinal);
        }



    }

}
