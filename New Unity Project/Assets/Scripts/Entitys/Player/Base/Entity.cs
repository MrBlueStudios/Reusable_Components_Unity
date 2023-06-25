
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Atributes;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Entitys.Player.Base
{
    // all entities face towards something so that means Entity inherits from FaceTowards
    public class Entity : FaceTowards
    {

        // an entity needs to have a rigidbody to move and a collider to interact with other colliders. its always 3d
        [Header("Entity Components")]
        [SerializeField] private Rigidbody rigidbody;
        [SerializeField] private Collider collider;
        // health
        [Header("Entity Health")]
        [SerializeField] private Health health;

    }
}
