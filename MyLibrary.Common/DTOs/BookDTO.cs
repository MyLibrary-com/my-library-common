using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Common.DTOs
{
    public class BookDTO
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string eISBN { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public int? SeriesID { get; set; }
        public int? NumberInSeries { get; set; }
        public string Edition { get; set; }
        public int PublicationFormat { get; set; }
        public int FictionType { get; set; }
        public int FormType { get; set; }
        public int Publisher { get; set; }
        public byte[] CoverImage { get; set; }
    }
}
