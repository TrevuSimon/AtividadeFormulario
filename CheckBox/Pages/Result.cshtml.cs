using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CheckBox.Pages
{
    public class ResultModel : PageModel
    {
        public String Nome { get; set; }
        public List<String> Cor { get; set; } = new List<String>();
        public List<String> Sexo { get; set; } = new List<String>();
        public Dictionary<String, String> Escolhas { get; set; } = new Dictionary<String, String>();

        public void OnGet(
            String Nome,
            List<String> Cor,
            List<String> Sexo,
            Dictionary<String, String> Escolhas)
        {
            this.Nome = Nome;
            this.Cor = Cor;
            this.Sexo = Sexo;
            this.Escolhas = Escolhas;

        }
    }
}