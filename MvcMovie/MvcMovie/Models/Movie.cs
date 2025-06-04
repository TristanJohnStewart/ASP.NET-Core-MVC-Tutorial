using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Required, StringLength(60, MinimumLength = 3)]
    public string? Title { get; set; }

    [DataType(DataType.Date), Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Column(TypeName = "decimal(18, 2)"), DataType(DataType.Currency), Range(1, 100)]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
    public string? Genre { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(5)]
    public string? Rating { get; set; }
}
