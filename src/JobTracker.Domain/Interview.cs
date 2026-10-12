namespace JobTracker.Domain;

public class Interview
{
    public int Id { get; set; }
    public int JobApplicationId { get; set; }
    public InterviewType Type { get; set; }
    public DateTime ScheduledAt { get; set; }
    public InterviewMode Mode { get; set; }
    public string InterviewerName { get; set; } = string.Empty;
    public required JobApplication JobApplication { get; set; }


}
