using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 1 * Time.deltaTime);

        if (transform.position.y > 15.82)
        {
            transform.position = new Vector3(transform.position.x, -26f);
        }
    }
}
