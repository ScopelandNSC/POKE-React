using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POKE.App.Config
{
    public class OverwatchApiSettings
    {
        [Required]
        public System.Uri BaseUrl { get; set; }
    }
}
