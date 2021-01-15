using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDragger : MonoBehaviour
{    
    Vector2 dragStartPosition;

    [SerializeField] Lean.Gui.LeanDrag dragArea = default;

    private bool dragAvailable = false;
    public bool DragAvailable 
    { 
        get => dragAvailable;
        set
        {
            dragArea.interactable = value;
            dragAvailable = value;
        }
    }

    public void OnDragBegin()
    {
        dragStartPosition = transform.position;
    }

    public void OnDragEnd()
    {
        var collidingDropSlots = Physics2D.OverlapCircleAll(transform.position, 40f);

        Debug.Log("Number of collisions: " + collidingDropSlots.Length);

        foreach (var dropSlot in collidingDropSlots)
        {
            //Debug.Log("Dropping on" + collider.GetComponent<Card>().Data);
            Debug.Log("Object name: " + dropSlot.transform.parent.name);
        }
    }
}
