using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangaMetadata
{
    public class MangaInfo
    {
        public string name { get; set; }
        public string japaneseName { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int volumeCount { get; set; }
        public int chapterCount { get; set; }
        public string imageUri { get; set; }
        public string website { get; set; }
        public string fansite { get; set; }
    }
    public class MangaSummary
    {
        public string name { get; set; }
        public string summary { get; set; }
    }
}
