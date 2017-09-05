using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchTracker.Model.Jobs
{
    public class JobDescription
    {
        //private ICollection<JobSkill> _skills;
        public JobDescription()
        {
            //_skills = new List<JobSkill>();
        }

        [Key]
        [Column("Id")]
        public int JobDescriptionId { get; set; }

        [Required]
        [StringLength(255)]
        public string JobTitle { get; set; }
        public string Summary { get; set; }

        //[Key, ForeignKey("JobLead")]
        //public int JobLeadId { get; set; }
        //public int CompanyId { get; set; }

        #region//Nav properties
        /* Relation between job description and company is
         * [1 JobDescription] to [0..1 Company]
         */
        //public virtual JobLead JobLead { get; set; }
        #endregion
    }
}
