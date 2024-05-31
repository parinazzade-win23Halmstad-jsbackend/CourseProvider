using CourseProvider.Infrastructure.Data.Entities;

namespace CourseProvider.Infrastructure.Models;

public class CourseCreateRequest
{
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

    public virtual List<AuthorCreateReguest>? Authors { get; set; }
    public virtual PricesCreateReguest? Prices { get; set; }
    public virtual ContentCreateReguest? Content { get; set; }
}
public class AuthorCreateReguest
{
    public string? Name { get; set; }
}
public class ContentCreateReguest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItemCreateReguset>? ProgramDetails { get; set; }

}
public class PricesCreateReguest
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }

}
public class ProgramDetailItemCreateReguset
{
    public int Id { get; set; }

    public string? Title { get; set; }
    public string? Description { get; set; }

}
