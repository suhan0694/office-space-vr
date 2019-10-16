using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformHeight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0,2f,0);
    }

    public void updateShortHeight() {
        transform.position = new Vector3(transform.position.x, 0.5f, transform.position.y);
    }

    public void updateNormalHeight()
    {
        transform.position = new Vector3(transform.position.x, 1.5f, transform.position.y);
    }

    public void updatetallHeight()
    {
        transform.position = new Vector3(transform.position.x, 2.5f, transform.position.y);
    }
}
