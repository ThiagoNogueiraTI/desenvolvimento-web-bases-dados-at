using at.Models;
using at.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace at.Pages
{
    public class ViewNotesModel : PageModel
    {
        private readonly NoteServiceTXT _noteService;

        public ViewNotesModel(NoteServiceTXT noteService)
        {
            _noteService = noteService;
        }

        [BindProperty]
        [Required(ErrorMessage = "O nome da nota é obrigatório.")]
        public string NoteName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "O conteúdo é obrigatório.")]
        public string Content { get; set; }

        public List<string> Files { get; set; } = new List<string>();
        public string SelectedContent { get; set; }
        public string SelectedFileName { get; set; }

        public void OnGet(string fileName)
        {
            Files = _noteService.LoadNotes();

            if (!string.IsNullOrEmpty(fileName))
            {
                SelectedFileName = fileName;
                SelectedContent = _noteService.ReadNote(fileName);
            }
        }

        public IActionResult OnPost()
        {
            Files = _noteService.LoadNotes();

            if (!ModelState.IsValid)
                return Page();


            _noteService.SaveNote(NoteName, Content);
            TempData["Message"] = $"Nota '{NoteName}' salva com sucesso.";

            return RedirectToPage("ViewNotes");
        }
    }
}
