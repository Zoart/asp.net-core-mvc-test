using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace study.Views.Home
{
    public class Thanks : PageModel
    {
        private readonly ILogger<Thanks> _logger;

        public Thanks(ILogger<Thanks> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}