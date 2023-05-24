using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMachine
{
    enum BoksType
    {
           LilleBoks,
           MellemBoks,
           StorBoks,
    }
    public class Boks //Makes a recipe for what a box has of properties.
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public BoksType Type { get; set; }
    }
}
