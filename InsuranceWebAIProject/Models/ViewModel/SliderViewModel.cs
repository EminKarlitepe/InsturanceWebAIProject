using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models.ViewModels
{
    public class SliderViewModel
    {
        public int SliderId { get; set; }
        public string SliderTitle { get; set; }
        public string SliderSubtitle { get; set; }
        public string SliderDescription { get; set; }
        public string SliderImageUrl { get; set; }
    }
}