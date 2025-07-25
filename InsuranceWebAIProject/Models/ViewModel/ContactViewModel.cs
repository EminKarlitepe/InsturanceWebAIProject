using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models.ViewModels
{
    public class ContactViewModel
    {
        public int CommunicationId { get; set; }
        public string Adress { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
    }
}