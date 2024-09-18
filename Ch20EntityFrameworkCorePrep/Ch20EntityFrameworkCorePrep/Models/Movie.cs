using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ch20EntityFrameworkCorePrep.Models;

[Table("Movie")]
[Index("Title", "Year", Name = "UQ_Movie_Title_Year", IsUnique = true)]
public partial class Movie
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    public int Year { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Rating { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Director { get; set; } = null!;

    public Movie() {
    }

    public Movie(string title, int year, string rating, string director) {
        Title = title;
        Year = year;
        Rating = rating;
        Director = director;
    }

    [InverseProperty("Movie")]
    public virtual ICollection<Credit> Credits { get; set; } = new List<Credit>();

    public override string ToString() {
        return $"Movie - {Id}, {Title}, {Year}, {Rating}, {Director}";
    }
}
