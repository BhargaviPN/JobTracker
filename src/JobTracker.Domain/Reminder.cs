namespace JobTracker.Domain;

public class Reminder
{
    public int Id { get; set; }
    public int JobApplicationId { get; set; }
    public DateTime ReminderDate { get; set; }
    public string Note { get; set; }
    public bool IsCompleted { get; set; }
    public JobApplication JobApplication { get; set; }
}
