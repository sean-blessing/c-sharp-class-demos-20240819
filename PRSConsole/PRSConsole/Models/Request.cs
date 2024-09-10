namespace PRSConsole.Models {
    public class Request {
        public int Id { get; set; }
        public User User { get; set; }
        public string RequestNumber { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public DateOnly DateNeeded { get; set; }
        public string DeliveryMode { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string ReasonForRejection { get; set; }

        public Request(int id, User u, string reqNum, string desc, string justification, DateOnly dateNeeded,
                       string dlvMode, string status, decimal total, DateTime subDate, string reason) {
            Id = id;
            User = u;
            RequestNumber = reqNum;
            Description = desc;
            Justification = justification;
            DateNeeded = dateNeeded;
            DeliveryMode = dlvMode;
            Status = status;
            Total = total;
            SubmittedDate = subDate;
            ReasonForRejection = reason;
        }

        public override string ToString() {
            return $"{Id}:{User.Username}:{RequestNumber}:{Description}:{Justification}:{DateNeeded}:" +
                $"{DeliveryMode}:{Status}:{Total}:{SubmittedDate}:{ReasonForRejection}";
        }
    }
}
