namespace Assets.Scripts.Entitys.Player.Base
{
    using System.Collections.Generic;
    using UnityEngine;
    using static UnityEditor.Progress;

    public class Inventory : MonoBehaviour
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Debug.Log("Item added: " + item.name);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
            Debug.Log("Item removed: " + item.name);
        }

        public void OpenInventory()
        {
            Debug.Log("Opening inventory...");
            // Implement your logic to open the inventory UI or perform other actions
        }
    }
}