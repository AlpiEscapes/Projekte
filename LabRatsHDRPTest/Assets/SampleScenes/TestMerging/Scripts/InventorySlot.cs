using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private Item item; //Holds the item in the slot
    public Image icon; //Holds the icon of the slot

    public void AddItem(Item item) //Adds an item to the slot
    {
        this.item = item; //Sets the passed item as the current item
        icon.sprite = item.icon; //Sets the sprite of the icon to the image of the item
        icon.enabled = true; //Enables the icon
    }

    public void ClearSlot() //Clears the slot from the current item
    {
        item = null; //Removes the item
        icon.sprite = null; //Removes the sprite of the item
        icon.enabled = false; //Disables the icon, else there would be a white box
    }
}
