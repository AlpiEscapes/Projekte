using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //Simple Singleton pattern
    #region singleton
    public static InventoryManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void onItemChanged();
    public onItemChanged onItemChangedCallback;

    public int space = 12; //Max inventory space (UI space is 24 slots)
    public List<Item> items = new List<Item>(); //Holds all items that were picked up

    public bool Pickup(Item item)
    {
        if(items.Count >= space) //If the inventory has no space left
        {
            Debug.Log("Inv is full"); 
            return false; //Return false, so the item dosnt get destroyed and can still be picked up later on
        }
        else
        {
            Debug.Log("Pickup");
            items.Add(item); //Add the item
            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
            return true; //Return true so the item can be destroyed
        }
    }

    public void Remove(Item item)
    {
        items.Remove(item); //Removes an item from the list
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }


    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag.Equals("HealItem"))
        {
            if (GetComponent<PlayerStats>().HealItemAmount < 3)
            {
                GetComponent<PlayerStats>().HealItemAmount++;
                Debug.Log("Item amnt: " + GetComponent<PlayerStats>().HealItemAmount);
                GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameHandler>().UpdateHPItemsUI();
                Destroy(hit.gameObject);
            }           
        }

        if (hit.gameObject.tag.Equals("Item")) //Checks if the collided object is a item
        {
            InteractableItem temp = hit.gameObject.GetComponent<InteractableItem>(); //Saves the item in a temporary variable
            TonbandScript tonband = hit.gameObject.GetComponent<TonbandScript>(); // Saves the TonbandScript in a temporary variable                    
            if(tonband != null) //If the triggered object is a Tonband
            {
                tonband.PlaySound(); //Play the sound of the Tonband
            }else if (Pickup(temp.item)) //If the item was picked up and added to the inventory
            {
                Destroy(temp.gameObject);
            }
        }
    }


}
