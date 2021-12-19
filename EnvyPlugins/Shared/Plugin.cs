using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvyPlugins.Shared
{
    public class Plugin
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Version { get; set; }
        public string? ImageUrl { get; set; }
        public float Cost { get; set; }
    }
}
