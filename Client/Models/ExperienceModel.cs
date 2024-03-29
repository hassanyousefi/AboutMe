﻿using Bit.BlazorUI;

namespace AboutMe.Client.Models
{
    public class ExperienceModel
    {
        public string PostTitle { get; set; }
        public string CompanyName { get; set; }
        public BitDateRangePickerValue WorkDateRange { get; set; }
        public string CompanySiteAddress { get; set; }
        public List<string> WorkDescriptions { get; set; }
        public int Id { get; set; }
    }
}
