using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace study.Views.Home
{
    public class RsvpForm : PageModel
    {
        private readonly ILogger<RsvpForm> _logger;

        public RsvpForm(ILogger<RsvpForm> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}