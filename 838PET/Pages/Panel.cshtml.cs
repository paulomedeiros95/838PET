using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _838PET
{
    public class PanelModel : PageModel
    {

        private readonly ILogger<PanelModel> _logger;

        public PanelModel(ILogger<PanelModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}