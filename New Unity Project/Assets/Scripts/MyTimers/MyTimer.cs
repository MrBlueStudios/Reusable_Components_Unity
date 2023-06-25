using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MyTimers
{
    public class MyTimer : MonoBehaviour
    {
        private float elapsedTime;
        private float interval;

        public delegate void TimerEvent();
        public event TimerEvent OnTimerTick;

        public void StartTimer(float interval)
        {
            this.interval = interval;
            elapsedTime = 0f;
            InvokeRepeating("Tick", 0f, interval);
        }

        public void StopTimer()
        {
            CancelInvoke("Tick");
        }

        private void Tick()
        {
            elapsedTime += interval;
            OnTimerTick?.Invoke();
        }
    }

    /*public class MyTimer : MonoBehaviour
    {
        public event Action OnTimerUpdate = delegate { };
        public event Action OnTimerEnd = delegate { };
        public event Action OnTimerStart = delegate { };

        private float _timeValue;
        private float _delay;
        private bool _isRunning = true;
        private bool _repeat = false;

        private void Start()
        {
            OnTimerStart?.Invoke();
        }

        private void Update()
        {
            if (_isRunning)
            {
                OnTimerUpdate?.Invoke();
                Debug.Log("Timer Running | Time left: " + _timeValue);
                if (_timeValue > 0)//
                {
                    _timeValue -= Time.deltaTime;
                }
                else
                {
                    OnTimerEnd?.Invoke();
                    if (_repeat)
                    {
                        _timeValue = _delay;
                    }
                    Debug.Log("Timer Ended | Complete time: " + _delay);
                }
            }
        }

        public void StartTimer(float delay)
        {
            _timeValue = delay;
            _delay = delay;
            _isRunning = true;

            OnTimerStart?.Invoke();
            OnTimerUpdate?.Invoke();
        }

        public void StartTimer(float delay, int amountSycles)
        {
            _timeValue = delay;
            _delay = delay;
            _isRunning = true;
            _repeat = true;

            CountCycles(amountSycles);

            OnTimerStart?.Invoke();
            OnTimerUpdate?.Invoke();
        }

        public void TogleRepeat()
        {
            // if true set to false and vice versa
            _repeat = !_repeat;
        }

        private void CountCycles(int amountSycles)
        {
            if (amountSycles <= 0)
            {
                return;
            }
            amountSycles--;
            OnTimerEnd += () => CountCycles(amountSycles);// this is a lambda expression that is the same as: OnTimerEnd += CountCycles;
        }
    }*/
}
