namespace JobTracker.Domain;

public class StatusHistory
{
    public int Id { get; set; }
    public int JobApplicationId { get; set; }
    public ApplicationStatus Status { get; set; }
    public DateTime ChangedAt { get; set; }
    public JobApplication JobApplication { get; set; }
}
