using System;

namespace KeepNotes.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int FontSize { get; set; }
        public bool Archived { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
