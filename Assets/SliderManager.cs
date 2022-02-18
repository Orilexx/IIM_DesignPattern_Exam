using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManager : MonoBehaviour
{
   public void UpdateSlider(float value)
    {
        //Met à jour la valeur du slider
        transform.GetComponent<Slider>().value = value;
    }
}
