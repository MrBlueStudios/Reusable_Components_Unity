using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    using UnityEngine;
    // following class is for testing inspector attributes

    [RequireComponent(typeof(Rigidbody))] // this will add a rigidbody component to the gameobject if it doesn't have one
    public class test1
    {
        // This integer will be shown as a slider,
        // with the range of 1 to 6 in the Inspector
        [Range(1, 6)]
        public int sliderInt;
        // this can also be used for floats
        [Range(1, 6)]
        public float sliderFloat;

        // context menu is used to add a function to the context menu.
        // you can find it by right clicking on the component or clicking on the 3 dots of the component in the inspector
        [ContextMenu("Do Something")]
        void DoSomething()
        {
            Debug.Log("Perform operation");
        }

        [Space(10)] // this will add a space of 10 pixels in the inspector

        // this will add a header to the inspector
        [Header("This is a header")]
        public int headerInt;




    }
}
