using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Facebook16.Models
{
    [DataContract]
    public class FacebookComment
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "created_time")]
        public string CreatedTime { get; set; }
        [DataMember(Name = "from")]
        public FacebookUser From { get; set; }
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
