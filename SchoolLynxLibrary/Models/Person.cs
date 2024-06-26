﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SchoolLynxLibrary.Models
{
    public partial class Person
    {
        public Person()
        {
            Confirmations = new HashSet<Confirmation>();
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string Lastname { get; set; } = null!;
        public bool Isteacher { get; set; }
        public int? ClassgroupId { get; set; }

        public virtual Classgroup? Classgroup { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Confirmation> Confirmations { get; set; }
        
        public virtual ICollection<Message> Messages { get; set; }
    }
}