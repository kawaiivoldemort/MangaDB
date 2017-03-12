using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comments
{
    public class Comment
    {
        public string username { get; set; }
        public string uImgSrc { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public List<Reply> replies { get; set; }
    }
    public class Reply
    {
        public string username { get; set; }
        public string uImgSrc { get; set; }
        public string usernameTo { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
    }
}