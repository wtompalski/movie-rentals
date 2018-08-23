
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MovieRentalsWeb.Models
{
    [DataContract(Name = "collectionResourceWrapperDto")]
    public class CollectionResourceWrapperDto<T> : ResourceBaseDto
        where T : ResourceBaseDto
    {
        [DataMember(Name = "values")]
        public IEnumerable<T> Values { get; set; }

        public CollectionResourceWrapperDto(IEnumerable<T> values)
        {
            this.Values = values;
        }
    }
}
