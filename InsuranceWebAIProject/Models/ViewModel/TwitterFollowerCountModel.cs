using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models
{
    public class TwitterLegacy
    {
        public int followers_count { get; set; }
    }

    public class TwitterResult
    {
        public TwitterLegacy legacy { get; set; }
    }

    public class TwitterRoot
    {
        public TwitterResult result { get; set; }

    }
}