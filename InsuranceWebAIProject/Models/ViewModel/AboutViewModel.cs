using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models.ViewModels
{
    public class AboutViewModel
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutSubtitle { get; set; }
        public string AboutDescription1 { get; set; }
        public string AboutDescription2 { get; set; }
        public string AboutSlogan1 { get; set; }
        public string AboutSlogan2 { get; set; }
        public string AboutSlogan3 { get; set; }
        public int? InsurancePoliciesCount { get; set; }
        public int? AwardsCount { get; set; }
        public int? SkilledAgentsCount { get; set; }
        public int? TeamMembersCount { get; set; }
        public string ImageUrl { get; set; }
    }
}