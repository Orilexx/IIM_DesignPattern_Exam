using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Implémentation de l'interface IPickUp
public class Key : MonoBehaviour, IPickUp
{

    [SerializeField] GameObject Door;

    // Méthode dont la signature a été implémentée dans l'interface
    public void PickUp()
    {
        //La porte s'ouvre
        Door.SetActive(false);

        //La clé disparait
        Destroy(gameObject);
    }
}
