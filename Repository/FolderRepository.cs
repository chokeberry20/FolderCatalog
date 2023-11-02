using FolderCatalog.Data;
using FolderCatalog.Interfaces;
using FolderCatalog.Models;

namespace FolderCatalog.Repository
{
    public class FolderRepository : IFolderRepository
    {
        private readonly DataContext _context;

        public FolderRepository(DataContext context)
        {
            _context = context;
        }
        public Folder GetFolderById(int folderId)
        {
            return _context.Folders.FirstOrDefault(f => f.Id == folderId);
        }

        public List<Folder> GetSubfoldersByFolderId(int folderId)
        {
            return _context.Folders.Where(f => f.ParentFolderId == folderId).ToList();
        }
    }
}
