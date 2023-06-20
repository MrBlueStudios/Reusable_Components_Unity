using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Entitys.Player.Base
{
    // achievement class
    public class MyAchievement
    {
        // fields
        // name
        [SerializeField] protected string _name;
        // description
        [SerializeField] private string _description;

        // progress
        [SerializeField] private float _progress;

        // id code for achievement
        [SerializeField] private int _id;
    }
}