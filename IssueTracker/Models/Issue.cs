using System;


namespace IssueTracker.Models
{
	public class Issue
	{
        public int Id { get; set; }
        public String IssueName { get; set; }
        public String IssueDetail { get; set; }
        public DateTime FirstReported { get; set; }
        public DateTime LastUpdated { get; set; }
        public String Status { get; set; }
        public String ReportedBy { get; set; }
        public String IssueProjectLocation { get; set; }
        public int IssuePriority { get; set; }

        public Issue()
		{
            
		}
	}
}
