
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
        [Header("Object to face")]
        [SerializeField] private Transform facePosition;

        private void Update()
        {
            if (this.facePosition != null)
            {
                FacePosition(facePosition.position);
            }
        }

        private void FacePosition(Vector3 targetPosition)
        {
            Vector3 direction = targetPosition - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = targetRotation;
        }

        // set face position protected
        protected void SetFacePosition(Transform facePosition)
        {
            this.facePosition = facePosition;
        }
    }
}
