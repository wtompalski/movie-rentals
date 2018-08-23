using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MovieRentalsWeb.Models
{
    [DataContract(Name = "linkDto")]
    public class LinkDto
    {
        [DataMember(Name = "href")]
        public string Href { get; set; }

        [DataMember(Name = "rel")]
        public string Rel { get; set; }

        [DataMember(Name = "method")]
        public string Method { get; set; }

        public LinkDto(string href, string rel, string method)
        {
            this.Href = href;
            this.Rel = rel;
            this.Method = method;
        }

    }
}
