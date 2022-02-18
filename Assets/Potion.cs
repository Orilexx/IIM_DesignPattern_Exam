using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour, IPickUp
{

    private GameObject player;

    private void Start()
    {
        //Récupère le joueur
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void PickUp()
    {
        //Soin du joueur
        if (player.TryGetComponent(out Health health))
        {
            health.Heal();

            //La potion disparait
            Destroy(gameObject);
        }
    }
}
