namespace WorkHourCalculator.Domain
{
    public class WorkerService
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
