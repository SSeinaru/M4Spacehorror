using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour,IBeginDragHandler,IDragHandler, IEndDragHandler
{
    public AudioSource Wrench;
    public Image image;
    [HideInInspector]public Transform parentAfterDrag;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begine drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");
        transform.position = Input.mousePosition; 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("not dragging");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        Wrench.Play();
    }

 
}
