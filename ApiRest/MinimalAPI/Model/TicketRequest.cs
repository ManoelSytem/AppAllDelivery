namespace MinimalAPI.Model
{
    public class TicketRequest
    {
        public TicketRequest()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Origin { get; set; } = string.Empty;
        public string Destiny { get; set; } = string.Empty;
        public DateTime Departure { get; set; } = DateTime.Now;
        public DateTime Returns { get; set; } = DateTime.Now;
        public string BoxColor { get; set; } = string.Empty;
    }
}
