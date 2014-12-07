using Facebook16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facebook16.ViewModels
{
    public class MainPageViewModel
    {
        public FacebookUser Profile { get; set; }
        public FacebookPost[] Posts { get; set; }
    }
}