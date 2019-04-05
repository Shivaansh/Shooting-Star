using UnityEditor.SceneManagement;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Inventory Inventory;
    public string Name;
    public Sprite Photo;
    public string PickUpType;
    void OnMouseDown()
    {
        //Destroy(GameObject.Find("BubbleBlaster"));
        PickUp();
    }
    void PickUp()
    {
        //Debug.Log("Picking up " + item.name);
        //bool wasPickedUp = Inventory.instance.Add(item);
        //if (wasPickedUp)
        //{

        if (GameObject.Find(Name) == null)
        {
            Debug.Log("cant find");
        }
        else
        {
            Debug.Log("ok");
           
            Inventory.Add(this);
            Debug.Log(Inventory.items.Count);
            Destroy(GameObject.Find(Name));
       
        }

       // }
    }
}
