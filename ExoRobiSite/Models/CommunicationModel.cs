using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoRobiSite.Models
{
    public class CommunicationModel
    {
        public string Command { get; set; }
        public List<string> CommandQueue { get; set; }
    }
}