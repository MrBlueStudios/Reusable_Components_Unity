using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Atributes
{
    public class FaceTowards : MonoBehaviour
    {
        // header
        [Header("Object to face")]
        [SerializeField] private Transform target;

        private void LateUpdate()// late 
        {
            if (target != null)
            {
                Vector3 direction = target.position - transform.position;
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }        
    }
}
