using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //R�cup�re l'objet et utilise son effet lorsqu'il est r�cup�r�
        if(collision.transform.parent.TryGetComponent(out IPickUp pickUp))
        {
            pickUp.PickUp();
        }
    }
}
