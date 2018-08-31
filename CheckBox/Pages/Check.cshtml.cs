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

        public List<String> Cor { get; set; } = new List<String>();
        public List<String> Sexo { get; set; } = new List<String>();
        public Dictionary<String,String> Escolhas { get; set; } = new Dictionary<String,String>();

        public CheckModel()
        {
            Cor.Add("Caucassiano");
            Cor.Add("Preto");
            Cor.Add("Pardo");
            Cor.Add("Indigena");

            Sexo.Add("horme");
            Sexo.Add("Mulher");

            Escolhas.Add("Int","Inteligente");
            Escolhas.Add("Bol","Come bolacha");
        }

        public void OnGet()
        {

        }
    }
}