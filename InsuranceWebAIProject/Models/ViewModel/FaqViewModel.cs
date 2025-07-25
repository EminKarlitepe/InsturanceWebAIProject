using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models.ViewModels
{
    public class FaqViewModel
    {
        public int FaqId { get; set; }
        public string Questioon { get; set; }
        public string Answer { get; set; }
    }
}