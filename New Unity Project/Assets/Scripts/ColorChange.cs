

using TMPro;
using UnityEngine;
// using my timer
using Assets.Scripts.MyTimers;
using System;
using Random = UnityEngine.Random;

namespace Assets.Scripts
{
    // auto add timer and textmeshpro
    [RequireComponent(typeof(MyTimer))]
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ColorChange : MonoBehaviour
    {
        private TextMeshProUGUI textMeshPro;
        private Color[] colors;
        private int currentColorIndex;
        private Color currentColor;
        private MyTimer timer;

        private void Start()
        {
            currentColorIndex = 0;
            textMeshPro = GetComponent<TextMeshProUGUI>();
            colors = GetRandomColors(5);
            timer = GetComponent<MyTimer>();
            timer.OnTimerTick += ChangeColor;
            timer.StartTimer(1f);
        }

        private void OnDestroy()
        {
            timer.OnTimerTick -= ChangeColor;
            timer.StopTimer();
        }

        private void ChangeColor()
        {
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
            textMeshPro.color = colors[currentColorIndex];
        }

        private Color[] GetRandomColors(int count)
        {
            Color[] colors = new Color[count];
            for (int i = 0; i < count; i++)
            {
                colors[i] = new Color(Random.value, Random.value, Random.value);
            }
            Debug.Log("Color: " + colors[0] + " " + colors[1] + " " + colors[2] + " " + colors[3] + " " + colors[4]);
            return colors;
        }
    }
    /*using TMPro;
    using UnityEngine;

    public class ColorChange : MonoBehaviour
    {
        private TextMeshProUGUI tMPGUI;
        private MyTimer _myTimer;

        private event Action _onColorChange = delegate { };

        public void ColChangeEffectTXT(TextMeshProUGUI textMeshProUGUI)
        {
            tMPGUI = textMeshProUGUI;

            // Start the color off randomly
            textMeshProUGUI.color = new Color32(255, 128, 0, 255);

            _myTimer = new MyTimer();
            _myTimer.OnTimerEnd += UpdateColor;
            // start timer for 3 seconds
            _myTimer.StartTimer(3);
            _myTimer.TogleRepeat();
            Debug.Log("ColorChangeTimerStarted");
        }

       public void UpdateColor()
        {
            Debug.Log("ColorUpdate");
            if (tMPGUI == null)
            {
                return;
            }

            // Update the color
            tMPGUI.color = new Color (GetNewColorValue((byte)tMPGUI.color.r), GetNewColorValue((byte)tMPGUI.color.g), GetNewColorValue((byte)tMPGUI.color.b), (byte)1f);

            // Start a new timer for the next color change
            _myTimer.StartTimer(Random.Range(0, 10)); // Start the timer for a random duration between 10 and 15 seconds
        }

        private byte GetNewColorValue(byte currentValue)
        {
            // If the current color value is 255 or higher, set it to 0; otherwise, increment it by 1
            return currentValue += (byte)1;
        }

    }*/
    /* public class ColorChange
     {
         private TextMeshProUGUI tMPGUI;
         private MyTimer _myTimer;

         public void ColChangeEffectTXT(TextMeshProUGUI textMeshProUGUI)
         {
             tMPGUI = textMeshProUGUI;

             // Start the color off randomly
             tMPGUI.color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);

             _myTimer = new MyTimer();
             _myTimer.OnTimerEnd += ColorUpdate; // Subscribe to the OnTimerEnd event
             _myTimer.StartTimer(Random.Range(10, 16)); // Start the timer for a random duration between 10 and 15 seconds
         }

         internal void ColorUpdate()
         {
             if (tMPGUI == null)
             {
                 return;
             }

             // Update the color
             tMPGUI.color = new Color32(GetNewColorValue(tMPGUI.color.r), GetNewColorValue(tMPGUI.color.g), GetNewColorValue(tMPGUI.color.b), 255);

             // Start a new timer for the next color change
             _myTimer.StartTimer(Random.Range(10, 16)); // Start the timer for a random duration between 10 and 15 seconds
         }

         private byte GetNewColorValue(float currentValue)
         {
             // If the current color value is 255 or higher, set it to 0; otherwise, increment it by 1
             return currentValue >= 255 ? (byte)0 : (byte)(currentValue + 1);
         }


     }*/
    /*public class ColorChange
    {
        private TextMeshProUGUI tMPGUI;
        private MyTimer _myTimer;
        public void ColChangeEffectTXT(TextMeshProUGUI textMeshProUGUI)
        {
            tMPGUI = textMeshProUGUI;
            // start the color off randomly
            tMPGUI.color = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)255);

            _myTimer = new MyTimer();

        }

        private event Action OnChangeColor = delegate { };

        // update the color
        public void ColorUpdate()
        {
            if (tMPGUI == null)
            {
                return;
            }
            // if color R is 255 or higher, set to 0
            if (tMPGUI.color.r >= (byte)255)
            {
                tMPGUI.color = new Color32((byte)0, (byte)tMPGUI.color.g, (byte)tMPGUI.color.b, (byte)255);
            }
            // if color G is 255 or higher, set to 0
            if (tMPGUI.color.g >= 255)
            {
                tMPGUI.color = new Color32((byte)tMPGUI.color.r, (byte)0, (byte)tMPGUI.color.b, (byte)255);
            }
            // if color B is 255 or higher, set to 0
            if (tMPGUI.color.b >= 255)
            {
                tMPGUI.color = new Color32((byte)tMPGUI.color.r, (byte)tMPGUI.color.g, (byte)0, (byte)255);
            }

            if (_myTimer == null)
            {
                _myTimer = new MyTimer();
                _myTimer.StartTimer(UnityEngine.Random.Range(1,3));
                //MyTimer.OnTimerUpdate += UpdateColor;
            }

        }
    }*/
}
