using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_MusicProgram.Entities
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public Performer Performer { get; set; }
        public Genre Genre { get; set; }
        public Playlist? Playlist { get; set; }

        public override string ToString()
        {
            return $"{Id+1}\t{Name}\t{Performer.Name}\t{Genre.Name}\t{Duration}s.";
        }
    }
}
