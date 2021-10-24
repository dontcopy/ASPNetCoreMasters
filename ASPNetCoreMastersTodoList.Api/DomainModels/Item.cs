﻿using System;

namespace DomainModels
{
    public class Item
    {
        public string Text { get; set; }

        public int ItemId { get; set; }

        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
