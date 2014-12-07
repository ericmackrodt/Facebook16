using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook16.Models
{
    public class FacebookUserOutput
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int Shares { get; set; }
        public string ProfileLink { get; set; }
        public string Username { get; set; }
    }
}
