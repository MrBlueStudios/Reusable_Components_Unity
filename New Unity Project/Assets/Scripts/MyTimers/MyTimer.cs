using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MyTimers
{
    public class MyTimer
    {
        public event Action OnTimerUpdate = delegate { };
        public event Action OnTimerEnd = delegate { };
        public event Action OnTimerStart = delegate { };

        private float _timeValue;
        private float _completeTime;
        private bool _isRunning;

        private void Start()
        {
            OnTimerStart?.Invoke();
        }

        private void Update()
        {
            if (_isRunning)
            {
                _timeValue -= Time.deltaTime;
                if (_timeValue <= 0)
                {
                    _isRunning = false;
                    OnTimerEnd?.Invoke();
                    Debug.Log("Timer Ended | Complete time: " + _completeTime);
                }
                else
                {
                    OnTimerUpdate?.Invoke();
                }
            }
        }

        public void StartTimer(float delay)
        {
            _timeValue = delay;
            _completeTime = delay;
            _isRunning = true;

            OnTimerStart?.Invoke();
            OnTimerUpdate?.Invoke();
        }
    }
}
