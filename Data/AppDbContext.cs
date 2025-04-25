using ToDo_list.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDo_list.Data;


public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
    public DbSet<TodoItem> TodoItems { get; set; }
}