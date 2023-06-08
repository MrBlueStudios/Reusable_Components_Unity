
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    public class Entity : MonoBehaviour
    {
        // serialized fields
        [SerializeField] protected float health;

        protected virtual void Initialize()
        {
            Debug.Log("Entity Initialize");
        }

        protected virtual void Update()
        {

        }
    }
}
