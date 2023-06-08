using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{

    // following class is for testing delegates
    public class test1
    {
        // Axplenation: 
        public event Action onhealthempty = delegate { }
        public action<float> onhealthchange = delegate { }

        
    }
}
