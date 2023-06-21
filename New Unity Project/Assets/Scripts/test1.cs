using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    using UnityEngine;
    // following class is for testing inspector attributes
    public class test1
    {
        // This integer will be shown as a slider,
        // with the range of 1 to 6 in the Inspector
        [Range(1, 6)]
        public int sliderInt;
        // this can also be used for floats
        [Range(1, 6)]
        public float sliderFloat;





    }
}
