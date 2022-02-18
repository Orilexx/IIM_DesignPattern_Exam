using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityBlock : MonoBehaviour
{
    [SerializeField] bool isBlocking = false;


    public void Block()
    {
        //Lève ou baisse le bouclier
        isBlocking = !isBlocking;
    }



    public bool GetIsBlocking()
    {
        return isBlocking;
    }

    
}
