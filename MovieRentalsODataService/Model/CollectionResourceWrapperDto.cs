using MovieRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalsHateoasStaticService.Model
{
    public class CollectionResourceWrapperDto<T> : ResourceBaseDto
        where T : ResourceBaseDto
    {
        public IEnumerable<T> Values { get; set; }

        public CollectionResourceWrapperDto(IEnumerable<T> values)
        {
            this.Values = values;
        }
    }
}
