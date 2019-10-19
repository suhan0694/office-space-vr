using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lamp_toggle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;
    private TextMeshPro One, OneText, Two, TwoText;



    // Start is called before the first frame update


    protected virtual void Update()
    {
        //light.SetActive(true);
    }

    public void valueChanged(bool a)
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
