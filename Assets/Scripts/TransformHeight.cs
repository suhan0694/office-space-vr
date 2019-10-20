using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformHeight : MonoBehaviour
{
    public GameObject ceiling;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateLocation()
    {
        transform.position = new Vector3(0, 0, 0);
        ceiling.SetActive(true);
    }
    public void updateShortHeight() {
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        ceiling.SetActive(true);
    }

    public void updateNormalHeight()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
        ceiling.SetActive(true);
    }

    public void updatetallHeight()
    {
        transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
        ceiling.SetActive(false);
    }
}
