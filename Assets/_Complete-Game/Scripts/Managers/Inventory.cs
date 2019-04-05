using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one inventory");
            instance = this;
        }
    }
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20;
    public List<Item> items = new List<Item>();

    public bool Add (Item item)
    {
       

        if (!item.isDefaultItem) 
        {
            if (items.Count >= space)
            {
                //More code needed
                Debug.Log("Swap here");
                return false;
            }
            items.Add(item);

            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
        }
        Debug.Log("Return true");
        return true;

    }

    public void Remove (Item item)
    {
        items.Remove(item);
    }
}
