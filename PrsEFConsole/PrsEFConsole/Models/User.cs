﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrsEFConsole.Models;

[Table("User")]
[Index("Email", Name = "UQ_User_Email", IsUnique = true)]
[Index("FirstName", "LastName", "PhoneNumber", Name = "UQ_User_Person", IsUnique = true)]
[Index("Username", Name = "UQ_User_Username", IsUnique = true)]
public partial class User
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(75)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    public bool Reviewer { get; set; }

    public bool Admin { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public User(string username, string password, string firstName, string lastName, 
        string phoneNumber, string email, bool reviewer, bool admin ) {
        this.Username = username;
        this.Password = password;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.Reviewer = reviewer;
        this.Admin = admin;
    }
}
