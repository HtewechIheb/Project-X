﻿using System;
using System.Text.Json.Serialization;

namespace Project_X.Models
{
    public class RefreshToken
    {
        public string Token { get; set; }
        public string JwtId { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        [JsonIgnore]
        public virtual AppUser User { get; set; }
    }
}
