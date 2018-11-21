using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsAndCategories.Models
{
    public class RelationSongCategory
    {
        public string SongId { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public Song Song { get; set; }
    }
}
