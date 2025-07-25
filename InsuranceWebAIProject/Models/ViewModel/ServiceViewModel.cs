using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models.ViewModels
{
    public class ServiceViewModel
    {
        public int ServicesId { get; set; }
        public string ServicesCardImageUrl { get; set; }
        public string ServicesCardTitle { get; set; }
        public string ServicesCardDescription { get; set; }
        public string ServicesCardIcon { get; set; }
        public string ServiceImagePrompt { get; set; }
    }
}