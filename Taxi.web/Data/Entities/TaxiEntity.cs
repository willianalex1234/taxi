﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Taxi.Web.Data.Entities;

namespace Taxi.web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }
        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Plaque { get; set; }

        public ICollection<TripEntity> Trips { get; set; }
    }
}