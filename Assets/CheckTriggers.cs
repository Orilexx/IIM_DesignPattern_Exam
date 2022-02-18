using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTriggers : MonoBehaviour
{
    [SerializeField] MyToggle trigger1;
    [SerializeField] MyToggle trigger2;
    [SerializeField] MyToggle trigger3;

    private void Update()
    {
        //Ouverture de la porte si les leviers sont activés
        if(trigger1.IsActive && trigger2.IsActive && trigger3.IsActive)
        {
            gameObject.SetActive(false);
        }
    }
}
