using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public bool ground = false;
    float preposition;
    float nowposition;

    // Start is called before the first frame update
    void Start()
    {
        preposition = transform.position.y;
        nowposition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        nowposition = transform.position.y;
        if (Input.GetKeyDown(KeyCode.Space) && ground == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
            GetComponent<Animator>().SetBool("jump", true);
            GetComponent<Animator>().SetBool("ground", false);
            ground = false;
        }
        if (nowposition<preposition&& GetComponent<Animator>().GetBool("ground") == false)
        {
            GetComponent<Animator>().SetBool("jumpdown", true);
        }
        preposition = nowposition;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "ground")
        {
            ground = true;
            GetComponent<Animator>().SetBool("ground", true);
            GetComponent<Animator>().SetBool("jump", false);
            GetComponent<Animator>().SetBool("jumpdown", false);
        }
    }
}
