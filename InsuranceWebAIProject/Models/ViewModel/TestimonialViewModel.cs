﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceWebAIProject.Models.ViewModels
{
    public class TestimonialViewModel
    {
        public int TestimonialId { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialSurname { get; set; }
        public string TestimonialJob { get; set; }
        public string TestimonialPoint { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialImageUrl { get; set; }
    }
}