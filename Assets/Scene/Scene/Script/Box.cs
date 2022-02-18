using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour,  IDamageable
{
    [SerializeField] Potion potionPrefab;

    public void TakeDamage(int amount)
    {

        //Génère un chiffre aléatoire
        int randomInt = Random.Range(1, 4);
        Debug.Log(randomInt);
        if (randomInt == 3)
        {
            //Instancie le prefab lorsque le chiffre tombe sur 3 (une chance sur 3)
            Instantiate(potionPrefab, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }

}
