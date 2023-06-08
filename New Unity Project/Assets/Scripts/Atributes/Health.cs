using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Atributes
{
    // health class using delegates and events
    public class Health
    {
        // fields
        [SerializeField] private float health;
        [SerializeField] private float maxHealth;

        // properties
        public float HealthValue
        {
            get => health;
            set
            {
                health = value;
                OnHealthChanged?.Invoke(health);
            }
        }

        public float MaxHealth
        {
            get => maxHealth;
            set
            {
                maxHealth = value;
                OnMaxHealthChanged?.Invoke(maxHealth);
            }
        }
                                                                     //     _____________________________________________________________________________________________________
                                                                     //     |NOTES|                                                                                             |
        // events                                                    //     |[1]:delegate { } is an empty delegate. It is used to prevent null reference exceptions.            |
        public event Action<float> OnHealthChanged = delegate { };   //     |[2]:The += operator is used to add a method to the invocation list of a delegate instance.         |
        public event Action<float> OnMaxHealthChanged = delegate { };//     |    The -= operator is used to remove a method from the invocation list of a delegate instance.    |
                                                                     //     |[3]:The Invoke method is used to invoke the methods in the invocation list of a delegate instance. |
                                                                     //     |    The methods are invoked in the same order in which they are added to the invocation list.      |
                                                                     //     |___________________________________________________________________________________________________|
        // constructor

        private Health()
        {
            this.health = health;
            this.maxHealth = maxHealth;
        }

        // methods
        public void Heal(float amount)
        {
            HealthValue += amount;
        }

        public void Damage(float amount)
        {
            HealthValue -= amount;
        }
    }
}
