using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-3 * Time.deltaTime, 0, 0);
        if (transform.position.x < -19.2f)
        {
            transform.Translate(19.2f, 0, 0);
        }
    }
}
