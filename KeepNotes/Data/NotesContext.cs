using Microsoft.EntityFrameworkCore;
using KeepNotes.Models;

namespace KeepNotes.Data
{
    public class NotesContext : DbContext
    {
        public NotesContext(DbContextOptions<NotesContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
