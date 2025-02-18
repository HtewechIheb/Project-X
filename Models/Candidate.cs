﻿using System;
using System.Collections.Generic;

namespace Project_X.Models
{
    public class Candidate
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public byte[] ResumeFile { get; set; }
        public string ResumeFileName { get; set; }
        public byte[] PhotoFile { get; set; }
        public string PhotoFileName { get; set; }
        public DateTime? Birthdate { get; set; }
        public string AccountId { get; set; }
        public virtual AppUser Account { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
