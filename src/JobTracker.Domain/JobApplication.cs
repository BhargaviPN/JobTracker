namespace JobTracker.Domain;

public class JobApplication
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string JobTitle { get; set; } = string.Empty;
    public string? Location { get; set; }
    public DateTime PostedDate { get; set; }
    public DateTime AppliedDate { get; set; }
    public DateTime ApplicationDeadline { get; set; }
    public decimal Salary { get; set; }
    public ApplicationStatus Status { get; set; }
    public required Company Company { get; set; }
}
