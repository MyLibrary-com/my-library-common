using MyLibrary.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Common.Responses
{
    public class GetBooksResponse : BaseResponse
    {
        public List<BookListItemDTO> Books { get; set; }

        public GetBooksResponse()
        {
            Books = new List<BookListItemDTO>();
        }
    }
}
