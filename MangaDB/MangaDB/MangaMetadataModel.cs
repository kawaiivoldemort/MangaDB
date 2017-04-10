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
    public class MangaChapters
    {
        public string name { get; set; }
        public List<MangaVolume> volumes { get; set; }
    }
    public class MangaVolume
    {
        public int volumeNumber { get; set; }
        public DateTime releaseDate { get; set; }
        public string isbn { get; set; }
        public List<MangaChapter> chapters { get; set; }
    }
    public class MangaChapter
    {
        public int chapterNumber { get; set; }
        public string chapterName { get; set; }
    }
    public class MangaListItem
    {
        public string name { get; set; }
        public string imageUri { get; set; }
        public string linkName{ get; set; }
    }
}
