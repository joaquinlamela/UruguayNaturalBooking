﻿using System;

namespace Domain
{
    public class TouristSpot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public virtual Region Region { get; set; }

        public virtual List<CategoryTouristSpot> ListOfCategories { get; set; }

        public TouristSpot() { }
    }
}
