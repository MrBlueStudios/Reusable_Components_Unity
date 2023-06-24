using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using Assets.Scripts.Entitys.Player.Base;


namespace Assets.Scripts.HandelingCredits.TheCredits
{
    using Assets.Scripts.Entitys.Player.Base;
    using Unity.VisualScripting;

    public class ThanksPlayer : MonoBehaviour
    {
        public TextMeshProUGUI ThxCredit(Transform parent, Player player)
        {
            if (player == null)
            {
                throw new Exception("Player not found");
            }
            GameObject childObject = new GameObject();
            // layer is ui
            childObject.layer = 5;
            // set rect transform
            childObject.AddComponent<RectTransform>();
            // width is 67,7% of screen width
            // height is 4,629% of screen height
            childObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width * 0.677f, Screen.height * 0.05901f);
            // add text mesh pro text to it
            TextMeshProUGUI textMeshProUGUI = childObject.AddComponent<TextMeshProUGUI>();
            // set the font style
            textMeshProUGUI.fontStyle = FontStyles.Bold;
            // get random color
            // set the color
            textMeshProUGUI.color = Color.black;
            // set how clear the text is
            textMeshProUGUI.alpha = 1;
            // set the size
            textMeshProUGUI.fontSize = 50;
            // set the text
            textMeshProUGUI.text = "Special thanks to: " + player.playerName;
            // set the alignment
            textMeshProUGUI.alignment = TextAlignmentOptions.Center;
            // set the material
            textMeshProUGUI.fontMaterial = Resources.Load<Material>("Fonts & Materials/LiberationSans SDF");
            // set the parent
            childObject.transform.SetParent(transform);
            return textMeshProUGUI;
        }
        public TextMeshProUGUI ThxCredit(Transform parent)
        {
            // find player
            Player player = FindObjectOfType<Player>(); if (player == null) throw new Exception("Player not found");

            GameObject childObject = new GameObject();
            // layer is ui
            childObject.layer = 5;
            // set rect transform
            childObject.AddComponent<RectTransform>();
            // width is 67,7% of screen width
            // height is 4,629% of screen height
            childObject.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width * 0.677f, Screen.height * 0.05901f);
            // add text mesh pro text to it
            TextMeshProUGUI textMeshProUGUI = childObject.AddComponent<TextMeshProUGUI>();
            
            // set the material
            textMeshProUGUI.fontMaterial = Resources.Load<Material>("Fonts & Materials/LiberationSans SDF");
            // set the font style
            textMeshProUGUI.fontStyle = FontStyles.Bold;
            
            // set how clear the text is
            textMeshProUGUI.alpha = 1;
            // set the size
            textMeshProUGUI.fontSize = 50;
            // auto size on
            textMeshProUGUI.enableAutoSizing = true;
            // set the text
            textMeshProUGUI.text = "Special thanks to: " + player.playerName;
            // set the alignment
            textMeshProUGUI.alignment = TextAlignmentOptions.Center;
            
            // set the parent
            childObject.transform.SetParent(parent);

            // set the color
            textMeshProUGUI.color = Color.black;

            return textMeshProUGUI;
        }
    }
}
