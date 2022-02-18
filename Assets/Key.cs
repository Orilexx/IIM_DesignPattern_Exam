using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Impl�mentation de l'interface IPickUp
public class Key : MonoBehaviour, IPickUp
{

    [SerializeField] GameObject Door;

    // M�thode dont la signature a �t� impl�ment�e dans l'interface
    public void PickUp()
    {
        //La porte s'ouvre
        Door.SetActive(false);

        //La cl� disparait
        Destroy(gameObject);
    }
}
