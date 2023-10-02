using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    private InventoryManager inventory; //Holds the inventory manager for further use
    public Transform itemsParent; //Holds the parent of the itemSlots which will be disabled later on because it has a graphics component
    private InventorySlot[] slots; //Holds all slots of the inventory

    // Start is called before the first frame update
    void Start()
    {
        inventory = InventoryManager.instance; //Gets the instance if the inventory manager
        inventory.onItemChangedCallback += UpdateUI; //Subscribes the UpdateUI function to the Pickup/Delete item functions so the UI updates when an item gets added or removed

        slots = itemsParent.GetComponentsInChildren<InventorySlot>(); //gets all Inventory slots
        UpdateUI(); //Updates the UI once. Without this all slots would be enabled which would show white boxes
    }


    void UpdateUI() //Updates the Icon/Item of every slot
    {
        for (int i = 0; i < slots.Length; i++) //Loops through all item slots and adds the Icon/Item to them or removes them if there is none
        {
            if(i < inventory.items.Count) 
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
