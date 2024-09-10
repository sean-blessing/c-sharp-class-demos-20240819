namespace PRSConsole.Models {
    public class User {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Boolean Reviewer { get; set;}
        public Boolean Admin { get; set; }

        public User(int id, string uname, string pwd, string fName, string lName,
                    string pNumber, string email, Boolean rev, Boolean admin) { 
            Id = id;
            Username = uname;
            Password = pwd;
            FirstName = fName;
            LastName = lName;
            PhoneNumber = pNumber;
            Email = email;
            Reviewer = rev;
            Admin = admin;
        }

        public override string ToString() {
            return $"{Id}:{Username}:{Password}:{FirstName}:{LastName}:{PhoneNumber}:{Email}:{Reviewer}:{Admin}";
        }
    }
}
