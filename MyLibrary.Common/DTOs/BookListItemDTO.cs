using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Common.DTOs
{
    public class BookListItemDTO
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string eISBN { get; set; }
        public string Title { get; set; }
        public string FormatType { get; set; }
        public string FictionType { get; set; }
    }
}
