using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private int _numberOfWeapons = 0;
    private int _numberOfAbilities = 0;
    private int _space = 9;
    public List<ItemPickUp> items = new List<ItemPickUp>();

    public bool Add (ItemPickUp item)
    {

            if (items.Count >= _space)
            {
                //More code needed
                Debug.Log("Swap here");
                return false;
            }
            items.Add(item);

            if(onItemChangedCallback != null)
                onItemChangedCallback.Invoke();


        string type = item.PickUpType;
        if (type == "Weapon")
        {
            if (_numberOfWeapons == 3)
            {
                GameObject.Find("WeaponSlot1").GetComponent<Image>().GetComponent<Image>().sprite = item.Photo;
            }
            else
            {
                string nameOfObject = "WeaponSlot" + (_numberOfWeapons + 1); 

                    GameObject.Find(nameOfObject).GetComponent<Image>().GetComponent<Image>().sprite = item.Photo;
                _numberOfWeapons++;

            }
               
        }
        if (type == "Ability")
        {
            if (_numberOfAbilities == 3)
            {
                GameObject.Find("AbilitySlot1").GetComponent<Image>().GetComponent<Image>().sprite = item.Photo;
            }
            else
            {
                string nameOfObject = "AbilitySlot" + (_numberOfAbilities + 1);

                GameObject.Find(nameOfObject).GetComponent<Image>().GetComponent<Image>().sprite = item.Photo;
                _numberOfAbilities++;

            }

        }
        return true;

    }

    public void Remove (ItemPickUp item)
    {
        items.Remove(item);
    }
}
