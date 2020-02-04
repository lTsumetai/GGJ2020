using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isFacingRight = true;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("Walking",true);
            anim.SetBool("Idle",false);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow)) 
        {
            anim.SetBool("Idle",true);
            anim.SetBool("Walking",false);
        }
    }
    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        isFacingRight = false;
    }

    void Unflip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        isFacingRight = true;
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Snode"))
        {
            Flip();
            Debug.Log("bisa");
        }
        if (target.gameObject.CompareTag("Sunode"))
        {
            Debug.Log("test");
            Unflip();
        }
    }
}
