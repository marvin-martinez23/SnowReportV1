using System.Collections.Generic;
using SnowReport.Pages;

namespace SnowReport.Models
{
    public class HomeModel : PeaksModel
    {
        public new ICollection<SnowTotals> SnowTotals { get; set; }
    }

}
