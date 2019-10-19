using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectToggler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;



    // Start is called before the first frame update
   

    protected virtual void Update()
    {
        //light.SetActive(true);
    }

    public void toggleState(bool a)
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
