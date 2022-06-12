﻿using System;

namespace Project_X.DTO.Responses
{
    public class CandidateDTO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
