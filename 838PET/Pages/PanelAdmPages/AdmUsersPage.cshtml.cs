using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _838PET.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _838PET.Pages.PanelAdmPages
{
    public class AdmUsersPageModel : PageModel
    {
        [BindProperty]
        public UserManager<UserIdentity> Users { get; set; }

        public void OnGet(string profile)
        {
            //pera ai
        }
    }
}