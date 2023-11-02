using FolderCatalog.Models;

namespace FolderCatalog.Interfaces
{
    public interface IFolderRepository
    {
        public List<Folder> GetSubfoldersByFolderId(int folderId);
        public Folder GetFolderById(int folderId);
    }
}
