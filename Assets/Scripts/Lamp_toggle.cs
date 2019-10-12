using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp_toggle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LightObject;



    // Start is called before the first frame update
   

    protected virtual void Update()
    {
        //light.SetActive(true);
    }

    public void valueChanged(bool a)
    {
        if (LightObject.activeSelf)
        {
            LightObject.SetActive(false);
        }
        else
        {
            LightObject.SetActive(true);
        }
    }
}
