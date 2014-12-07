using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Facebook16.Models
{
    [DataContract]
    public class FacebookPaging
    {
        [DataMember(Name = "next")]
        public string Next { get; set; }
        [DataMember(Name = "previous")]
        public string Previous { get; set; }
    }
}
