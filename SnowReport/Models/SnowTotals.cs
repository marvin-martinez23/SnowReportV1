using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;


namespace SnowReport.Models
{
    public class SnowTotals
    {
        public ICollection<UserFeedback> Feedbacks { get; set; }
        public int ID { get; set; }
        [Display(Name = "Mountain Name")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string MountainName { get; set; }
        [Display(Name = "New snow fall (inches)")]
        [Required]
        public int NewSnow { get; set; }
        [Required]
        public string City { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required]
        [Display(Name = "State")]

        public string State { get; set; }

        public static List<SnowTotals> GetAll()
        {
            return new List<SnowTotals>
            {
                new SnowTotals { ID = 1, MountainName = "Mountain A", NewSnow = 10, City = "City A", State = "State A" },
                new SnowTotals { ID = 2, MountainName = "Mountain B", NewSnow = 5, City = "City B", State = "State B" },
            new SnowTotals { ID = 3, MountainName = "Mountain C", NewSnow = 20, City = "City C", State = "State C" },
            };
        }
    }
}

