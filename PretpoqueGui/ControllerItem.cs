using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PretpoqueGui
{
    class ControllerItem
    {
        public string Name { get; private set; }

        public int Index { get; private set; }

        public ControllerItem(int controllerIndex)
        {
            this.Name = string.Format("Controller {0}", controllerIndex);
            this.Index = controllerIndex;
        }
    }
}
