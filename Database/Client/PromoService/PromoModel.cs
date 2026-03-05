public class PromoModel
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public decimal DiscountPercent { get; set; }
    public bool IsActive { get; set; }
}