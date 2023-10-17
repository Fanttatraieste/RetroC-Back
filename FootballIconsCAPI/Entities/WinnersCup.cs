﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootballIconsCAPI.Entities
{
    [Table("WinnersCupInfo")]
    [PrimaryKey(nameof(WinnersCupID))]
    public class WinnersCup
    {
        public WinnersCup() { }
        [Required]
        public int WinnersCupID { get; set; }

        public string Winner { get; set; }
        public string RunnerUp { get; set; }
        public string Place { get; set; }
        public int Year { get; set; }
    }
}