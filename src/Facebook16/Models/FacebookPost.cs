using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Facebook16.Models
{
    [DataContract]
    public class FacebookPost
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "caption")]
        public string Caption { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "created_time")]
        public DateTime CreatedTime { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "picture")]
        public string Picture { get; set; }

        [DataMember(Name = "story")]
        public string Story { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "status_type")]
        public string StatusType { get; set; }
        [DataMember(Name = "from")]
        public FacebookUser From { get; set; }

        [JsonIgnore]
        public string Token { get; set; }
    }
}
