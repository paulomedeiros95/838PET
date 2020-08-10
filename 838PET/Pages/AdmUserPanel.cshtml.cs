using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _838PET.Pages
{
    public class AdmUserPanelModel : PageModel
    {
        public void OnGet(string profile)
        {
            ViewData["Message"] = profile;
        }
    }
}