using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalsHateoasDynamicService.Model
{
    public class LinkDto
    {
        public string Href { get; }

        public string Rel { get; }

        public string Method { get; }

        public LinkDto(string href, string rel, string method)
        {
            this.Href = href;
            this.Rel = rel;
            this.Method = method;
        }

    }
}
