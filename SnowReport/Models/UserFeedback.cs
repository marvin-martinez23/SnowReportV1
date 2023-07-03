using System;
using System.ComponentModel.DataAnnotations;

namespace SnowReport.Models
{
    public class UserFeedback
    {

        public int Id { get; set; }
        public string Rider { get; set; }
        public string MointainName { get; set; }
        public string Name { get; set; }
        public DateTime VisitDate { get; set; }
        [StringLength(100)]
        public string Feedback { get; set; }
        public UserFeedback()
        {

        }

        public UserFeedback(string rider, string name, DateTime visitDate, string feedback)
        {
            Rider = rider;
            Name = name;
            VisitDate = visitDate;
            Feedback = feedback;
        }   
    }
}
