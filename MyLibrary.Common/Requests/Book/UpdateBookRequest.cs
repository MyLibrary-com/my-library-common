using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibrary.Common.Requests
{
    public class UpdateBookRequest : BaseRequest
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string eISBN { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must provide a title")]
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public int? SeriesID { get; set; }
        public int? NumberInSeries { get; set; }
        public int? Edition { get; set; }
        public int PublicationFormatID { get; set; }
        public int FictionTypeID { get; set; }
        public int FormTypeID { get; set; }
        public int PublisherIDs { get; set; }
        public byte[] CoverImage { get; set; }
        public List<int> Genres { get; set; }
        public List<int> Authors { get; set; }

        public UpdateBookRequest()
        {
            Genres = new List<int>();
            Authors = new List<int>();
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (string.IsNullOrEmpty(eISBN) && string.IsNullOrEmpty(ISBN))
            {
                results.Add(new ValidationResult("You must provide a ISBN or an eISBN"));
            }

            return results;
        }
    }
}
