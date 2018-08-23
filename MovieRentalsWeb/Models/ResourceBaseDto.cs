using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MovieRentalsWeb.Models
{
    [DataContract(Name = "resourceBaseDto")]
    public abstract class ResourceBaseDto
    {
        [DataMember(Name = "links")]
        public List<LinkDto> Links { get; set; } = new List<LinkDto>();
    }
}
