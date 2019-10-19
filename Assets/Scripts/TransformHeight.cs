using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformHeight : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject ceiling;
=======
>>>>>>> 791d9f34d61842858b532cd436c2537739d2aef3
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
    }

    public void updateShortHeight() {
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        ceiling.SetActive(true);
=======
        transform.position = transform.position + new Vector3(0,2f,0);
    }

    public void updateShortHeight() {
        transform.position = new Vector3(transform.position.x, 0.5f, transform.position.y);
>>>>>>> 791d9f34d61842858b532cd436c2537739d2aef3
    }

    public void updateNormalHeight()
    {
<<<<<<< HEAD
        transform.localScale = new Vector3(1f, 1f, 1f);
        ceiling.SetActive(true);
=======
        transform.position = new Vector3(transform.position.x, 1.5f, transform.position.y);
>>>>>>> 791d9f34d61842858b532cd436c2537739d2aef3
    }

    public void updatetallHeight()
    {
<<<<<<< HEAD
        transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
        ceiling.SetActive(false);
=======
        transform.position = new Vector3(transform.position.x, 2.5f, transform.position.y);
>>>>>>> 791d9f34d61842858b532cd436c2537739d2aef3
    }
}
