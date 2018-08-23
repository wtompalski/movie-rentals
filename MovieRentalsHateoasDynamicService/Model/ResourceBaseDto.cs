using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalsHateoasDynamicService.Model
{
    public abstract class ResourceBaseDto
    {
        public List<LinkDto> Links { get; } = new List<LinkDto>();
    }
}
