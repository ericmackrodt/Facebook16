using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Facebook16.Models
{
    [DataContract]
    public class FacebookPostComments
    {
        [DataMember(Name = "data")]
        public FacebookComment[] Comments { get; set; }

        [DataMember(Name = "paging")]
        public FacebookPaging Paging { get; set; }
    }
}
