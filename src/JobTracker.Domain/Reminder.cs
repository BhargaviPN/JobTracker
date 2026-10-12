namespace JobTracker.Domain;

public class Reminder
{
    public int Id { get; set; }
    public int JobApplicationId { get; set; }
    public DateTime ReminderDate { get; set; }
    public string Note { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public required JobApplication JobApplication { get; set; }
}
