using System.ComponentModel.DataAnnotations;

//可以改變網頁顯示的字
using System.ComponentModel.DataAnnotations.Schema;
namespace TodayMovie.Models;

public class Movie
{
    public int Id { get; set; }
    
    [StringLength(60, MinimumLength = 3)]
    [Required]
    [Display(Name = "片名")]
    public string? Title { get; set; }

    [Display(Name = "播放日期")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Display(Name = "票價")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    [Display(Name = "評級")]
    public string Rating { get; set; } = string.Empty;
}