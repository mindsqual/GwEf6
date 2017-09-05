using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchTracker.Model
{
    public class JobSearchActivity
    {
        public int Id { get; set; }

        public int ContactPersonId { get; set; }
        
        public int JobLeadId { get; set; }

        [Column("HappenedOn")]
        public DateTime Created { get; set; }

        public JobSearchActivityType JobSearchActivityType { get; set; }

        public int CompanyId { get; set; }
        
        
        //Nav properties
        public virtual Company Company { get; set; }
        public virtual ContactPerson ContactPerson { get; set; }
    }
}
