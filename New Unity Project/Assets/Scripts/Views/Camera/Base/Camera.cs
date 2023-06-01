using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

internal class Camera : MonoBehaviour
{
    // serialized fields
    [SerializeField] protected float sensitivity = 100f;
    [SerializeField] protected Transform playerBody;
    [SerializeField] protected Transform camera;

}
