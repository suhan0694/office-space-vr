using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceProController : MonoBehaviour
{
    public GameObject videoPlayer;



    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("In start");





    }

    protected virtual void Update()
    {
        //light.SetActive(true);
    }

    public void valueChanged(bool a)
    {
        if (videoPlayer.activeSelf)
        {
            videoPlayer.SetActive(false);
        }
        else
        {
            videoPlayer.SetActive(true);
        }
    }
}
