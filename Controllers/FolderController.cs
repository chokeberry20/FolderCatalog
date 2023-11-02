using FolderCatalog.Interfaces;
using FolderCatalog.Models;
using FolderCatalog.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FolderCatalog.Controllers
{
    [Route("/")]
    public class FolderController: Controller
    {
        private readonly IFolderRepository _folderRepository;

        public FolderController(IFolderRepository folderRepository)
        {
            _folderRepository = folderRepository;
        }

        [Route("/{folderId}")]
        public ActionResult Subfolders(int folderId)
        {
            var subfolders = _folderRepository.GetSubfoldersByFolderId(folderId);
            var mainFolder = _folderRepository.GetFolderById(folderId);

            var model = new FolderViewModel
            {
                MainFolder = mainFolder,
                Subfolders = subfolders
            };

            return View(model);
        }
    }
}
