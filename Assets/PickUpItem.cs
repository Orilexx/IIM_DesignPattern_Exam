using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Récupère l'objet et utilise son effet lorsqu'il est récupéré
        if(collision.transform.parent.TryGetComponent(out IPickUp pickUp))
        {
            pickUp.PickUp();
        }
    }
}
