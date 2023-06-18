using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Atributes
{
    public class LookAt : MonoBehaviour
    {
        [SerializeField] private Transform target;

        private void Update()
        {
            if (target != null)
            {
                Vector3 direction = target.position - transform.position;
                transform.rotation = Quaternion.LookRotation(direction);
            }
        }

            
        [SerializeField] private float sphereDiameter = 1f;

           
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, sphereDiameter / 2f);
        }
        
    }
}
