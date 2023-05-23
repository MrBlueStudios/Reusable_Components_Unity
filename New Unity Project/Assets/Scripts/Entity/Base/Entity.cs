using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Entity.Base
{
    public abstract class Entity : MonoBehaviour, IEntity
    {
        public virtual void Initialize()
        {
            // Initialization logic for the entity
        }

        public virtual void Update()
        {
            // Update logic for the entity
        }
    }
}
