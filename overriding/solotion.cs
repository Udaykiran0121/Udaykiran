using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    public partial class solotion : Component
    {
        public solotion()
        {
            InitializeComponent();
        }

        public solotion(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
