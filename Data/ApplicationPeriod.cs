using System;
using System.Collections.Generic;

namespace mscfreshman.Data
{
    public class ApplicationPeriod
    {
        public ApplicationPeriod()
        {
        }

        public ApplicationPeriod(int id, string title = "", string description = "", bool userApproved = false)
        {
            Id = id;
            Title = title;
            Description = description;
            UserApproved = userApproved;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool UserApproved { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
            = new HashSet<Application>();
        public virtual ICollection<ApplicationPeriodDataType> PeriodDataTypes { get; set; }
            = new HashSet<ApplicationPeriodDataType>();
    }
}
