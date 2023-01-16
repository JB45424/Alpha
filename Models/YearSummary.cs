// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alpha.Models
{
    public class YearSummary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        #nullable disable
        public string Year { get; set; }
        #nullable restore        
        public string? LeagueRecord { get; set; }
        public string? RegularSeasonRecord { get; set; }
        public string? PostSeasonRecord { get; set; }
        public string? FullSeasonRecord { get; set; }
        public string? League { get; set; }        
        public string? HeadCoach { get; set; }        
        public string? Notes { get; set; }
    }        
}