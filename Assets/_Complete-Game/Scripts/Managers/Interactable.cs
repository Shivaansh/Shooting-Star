using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 1.5f;
    public Transform interactionTransform;
    public Item item;

    bool isFocus = false;
    Transform player;

    public virtual void Interact()
    {
        Debug.Log("Interact with +");
        bool wasPickedUp = Inventory.instance.Add(item);
        Debug.Log("wasPickedUp = " + wasPickedUp);
        if (wasPickedUp)
        {
            Destroy(this.gameObject);
        }
    }

    void OnDrawGizmosSelected()
    {
        if(interactionTransform == null)
        {
            interactionTransform = transform;
        }
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    
}
