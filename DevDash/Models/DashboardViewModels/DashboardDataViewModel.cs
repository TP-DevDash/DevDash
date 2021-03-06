﻿using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrelloNet;

namespace DevDash.Models.DashboardViewModels
{
    public class DashboardDataViewModel
    {
        [Required]
        public GithubIssueViewModel Issues { get; set; }

        [Required]
        public TrelloViewModel TrelloViewModel { get; set; } 
    }
}
