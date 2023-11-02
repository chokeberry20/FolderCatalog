using FolderCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace FolderCatalog.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Folder> Folders => Set<Folder>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Folder>().HasData(
                new Folder { Id = 1, FolderName = "Creating Digital Images", ParentFolderId = 0},
                new Folder { Id = 2, FolderName = "Resources", ParentFolderId = 1 },
                new Folder { Id = 3, FolderName = "Evidence", ParentFolderId = 1 },
                new Folder { Id = 4, FolderName = "Graphic Products", ParentFolderId = 1 },
                new Folder { Id = 5, FolderName = "Primary Sources", ParentFolderId = 2 },
                new Folder { Id = 6, FolderName = "Secondary Sources", ParentFolderId = 2 },
                new Folder { Id = 7, FolderName = "Process", ParentFolderId = 4},
                new Folder { Id = 8, FolderName = "Final Product", ParentFolderId = 4 }
            );
        }

        
    }
}
