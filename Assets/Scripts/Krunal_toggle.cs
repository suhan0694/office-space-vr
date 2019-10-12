using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krunal_toggle : MonoBehaviour
{
    public Light lightObject;
    public MeshFilter meshObject;
    public Mesh mesh1;
    public Mesh mesh2;
    public AudioSource audioSource1;
    public AudioSource audioSource2;


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
        if (lightObject.isActiveAndEnabled)
        {
            lightObject.enabled = false;
            meshObject.mesh = mesh1;
            audioSource2.Play();
        }
        else {
            lightObject.enabled = true;
            meshObject.mesh = mesh2;
            audioSource1.Play();
        }
    }
}
