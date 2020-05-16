using MyLibrary.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Common.Responses
{
    class GetBookResponse : BaseResponse
    {
        public BookDTO Book { get; set; }
    }
}
