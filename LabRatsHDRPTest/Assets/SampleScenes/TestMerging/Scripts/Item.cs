using UnityEngine;

//Scriptable items for Items
[CreateAssetMenu(fileName ="New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name; //ItemName
    public Sprite icon = null; //ItemIcon
    //Further Properties




}
