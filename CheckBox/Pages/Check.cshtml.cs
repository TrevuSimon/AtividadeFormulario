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
        public Dictionary<String,String> Escolhas { get; set; } = new Dictionary<String,String>();

        public CheckModel()
        {
            Cor.Add("Caucassiano");
            Cor.Add("Preto");
            Cor.Add("Pardo");
            Cor.Add("Indigena");

            Sexo.Add("Homem");
            Sexo.Add("Mulher");

            Escolhas.Add("Int","Inteligente");
            Escolhas.Add("Bol","Come bolacha");
            Escolhas.Add("Bis","Come biscouto");
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