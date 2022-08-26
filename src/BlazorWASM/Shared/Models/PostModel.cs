using System.ComponentModel.DataAnnotations;

namespace BlazorWASM.Shared.Models;

public class PostModel
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Subtitle { get; set; }

    [Required]
    public string Preview { get; set; }

    [Required]
    public string ImageName { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.Now;

    [Required]
    public string Post { get; set; }
}
