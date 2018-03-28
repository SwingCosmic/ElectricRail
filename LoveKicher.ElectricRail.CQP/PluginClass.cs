using Newbe.Mahua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveKicher.ElectricRail.CQP
{
    public class PluginClass : IPluginInfo
    {
        public string Version {  get; set; } = "1.0";
        public string Name {  get; set; } = "test";
        public string Author {  get; set; } = "l";
        public string Id {  get; set; } = "LoveKicher.ElectricRail.CQP";
        public string Description {  get; set; } = "";
    }
}
