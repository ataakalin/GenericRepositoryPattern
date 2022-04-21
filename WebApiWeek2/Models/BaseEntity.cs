﻿using System;

namespace WebApiWeek2.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
