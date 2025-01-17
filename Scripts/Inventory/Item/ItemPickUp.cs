using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zain.Inventory
{
    public class ItemPickUp : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Item item = other.GetComponent<Item>();

            if (item != null)
            {
                if (item.itemDetails.canPickedup)
                {
                    //ʰȡ��Ʒ
                    InventoryManager.Instance.AddItem(item, true);

                    //TODO:UI��ʾ
                    EventHandler.CallInitPickedItemEffect(item.itemDetails);

                    EventHandler.CallPlaySoundEvent(SoundName.Pickup);
                }
            }
        }
    }
}

