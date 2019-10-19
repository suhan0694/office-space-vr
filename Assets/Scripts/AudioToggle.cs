using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    public GameObject LightObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
