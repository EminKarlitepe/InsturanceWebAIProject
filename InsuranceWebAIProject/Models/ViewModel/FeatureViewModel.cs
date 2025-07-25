using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models.ViewModels
{
    public class FeatureViewModel
    {
        public int FeatureId { get; set; }
        public string FeatureCardIcon { get; set; }
        public string FeatureCardTitle { get; set; }
        public string FeatureCardDescription { get; set; }
    }
}