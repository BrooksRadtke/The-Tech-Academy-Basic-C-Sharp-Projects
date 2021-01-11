﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppToAzureChallenge.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Time { get; set; }
        public string Today { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
            Today = DateTime.Now.DayOfWeek.ToString();
        }
    }
}
