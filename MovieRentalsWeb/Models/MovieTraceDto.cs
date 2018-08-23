using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MovieRentalsWeb.Models
{
    [DataContract(Name = "movieTraceDto")]
    public class MovieTraceDto : ResourceBaseDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }


        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "genre")]
        public string Genre { get; set; }
    }
}
