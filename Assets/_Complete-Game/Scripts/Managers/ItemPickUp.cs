using UnityEngine;

public class ItemPickUp : Interactable {

    public Item item;


    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        
    }
}
