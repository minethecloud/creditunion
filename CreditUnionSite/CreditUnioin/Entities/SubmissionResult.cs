using System.Collections.Generic;

namespace CreditUnioin.Entities
{
    public class SubmissionResult
    {
        public int? ReferenceNumber { get; set; }
        public List<string> ValidationErrors { get; set; }
    }
}