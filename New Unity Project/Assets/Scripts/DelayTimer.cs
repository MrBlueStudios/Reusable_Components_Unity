// dalay timer class for when a delay is needed

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class DelayTimer : MonoBehaviour
    {
        /*private float timer = 0f;
        private float delay = 0f;
        private bool isDone = false;

        public bool IsDone { get => isDone; set => isDone = value; }

        public void StartTimer(float delay)
        {
            this.delay = delay+=Time.deltaTime;
            timer = 0f;
            isDone = false;
        }

        public void Update()
        {
            if (isDone)
            {
                return;
            }
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                Debug.Log("DelayTimer.Update() timer >= delay");
                isDone = true;
            }
        }*/

        public static async void StartTimer(int durationInSeconds, Action onTimerComplete)
        {
            await Task.Delay(durationInSeconds * 1000); // Delay for the specified duration

            // Call the provided action when the timer is complete
            onTimerComplete?.Invoke();
        }
    }
}