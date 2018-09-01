using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CheckBox.Pages
{
    public class CheckModel : PageModel
    {
        [BindProperty]
        public String Nome { get; set; }

        [BindProperty]
        public List<String> Cor { get; set; } = new List<String>();

        [BindProperty]
        public List<String> Sexo { get; set; } = new List<String>();

        [BindProperty]
        public List<String> Escolhas { get; set; } = new List<String>();

        public CheckModel()
        {
            Cor.Add("Caucassiano");
            Cor.Add("Preto");
            Cor.Add("Pardo");
            Cor.Add("Indigena");

            Sexo.Add("Homem");
            Sexo.Add("Mulher");

            Escolhas.Add("Inteligente");
            Escolhas.Add("Come bolacha");
            Escolhas.Add("Come biscouto");
        }

        public void OnGet()
        {

        }

        public RedirectToPageResult OnPost()
        {
            return RedirectToPage("Result", new{Nome,Cor, Sexo, Escolhas});
        }
    }
}