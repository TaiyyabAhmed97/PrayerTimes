﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrayerTimes.Models
{
    public class Masjid
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Address { get; set; }

        public string PHnum { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime Fajr { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime Zuhr { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime Asr { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime Maghrib { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime Isha { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime Jummah_1 { get; set; }

        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime Jummah_2 { get; set; }



    }
}