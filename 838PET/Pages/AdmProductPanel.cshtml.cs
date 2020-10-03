using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _838PET.Areas.Application.Data;
using _838PET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _838PET.Pages
{
    public class AdmProductPanelModel : PageModel
    {


        [BindProperty]
        public string ProductValue { get; set; }

        public async Task OnGet()
        {
            using (var context = new ApplicationDBContext())
            {
                var x = context.Produtos.FirstOrDefault();
                ProductValue = x.Valor.ToString();
            }
        }
    }
}