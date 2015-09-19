using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypescriptApp.Models
{
    public class Post
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AuthorGravatar { get; set; }
        public string URI { get; set; }
        public DateTime DatePublished { get; set; }
        public string ImageURI { get; set; }
        public string Contents { get; set; }
        #endregion
    }
}