using CourseProvider.Infrastructure.Data.Entities;

namespace CourseProvider.Infrastructure.Models;

public class CourseUpdateRequest
{
    public string Id { get; set; } = null!;
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public string[]? Categories { get; set; }
    public string? Title { get; set; }
    public string? Ingress { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? LikesInProcent { get; set; }
    public string? LikesInNumber { get; set; }
    public string? Hours { get; set; }

    public virtual List<AuthorUpdateReguest>? Authors { get; set; }
    public virtual PricesUpdateReguest? Prices { get; set; }
    public virtual ContentUpdateReguest? Content { get; set; }
}
public class AuthorUpdateReguest
{
    public string? Name { get; set; }
}
public class ContentUpdateReguest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItemUpdateReguset>? ProgramDetails { get; set; }

}
public class PricesUpdateReguest
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }

}
public class ProgramDetailItemUpdateReguset
{
    public int Id { get; set; }

    public string? Title { get; set; }
    public string? Description { get; set; }

}

