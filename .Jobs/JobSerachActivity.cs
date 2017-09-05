using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchTracker.Model.Jobs
{
    class JobSerachActivity
    {
        public int JobSearchActivityId { get; set; }

        [Required]
        public JobSearchActivityType JobSearchActivityType { get; set; }
    }
}
