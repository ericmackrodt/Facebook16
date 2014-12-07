using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook16.Models
{
    public class FacebookProfile
    {
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public string AccessToken { get; set; }
        public bool IsPage { get; set; }
        public string Id { get; set; }
    }
}
