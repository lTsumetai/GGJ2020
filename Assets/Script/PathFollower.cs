using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    Node[] PathNode;
    public GameObject Player;
    public float MoveSpeed;
    float Timer;
    static Vector3 CurrentPositionHolder;
    static Vector3 BeforePositionHolder;
    public Vector2 startPosition;
    bool move = false;
    bool Lmove = false;
    
    //Rigidbody2D rb;
     
   
    int CurrentNode;
    int BeforeNode;
    // Start is called before the first frame update
    void Start()
    {
        PathNode = GetComponentsInChildren<Node>();
        CheckNode();
        //rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        
    }

    void CheckNode()
    {
        Timer = 0;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
        startPosition = Player.transform.position;
        BeforePositionHolder = PathNode[BeforeNode].transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            move = true;

        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            move = false;
        }
        if (move)
        {   
            
            Timer += Time.deltaTime * MoveSpeed;
            if (Player.transform.position != CurrentPositionHolder)
            {
                Player.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder, Timer);
                //rb.velocity = new Vector2(1f, 0);
            }
            else
            {
                if (CurrentNode < PathNode.Length - 1)
                {
                    CurrentNode++;
                    CheckNode();
                }
                else
                {
                move = false;
                Debug.Log("Sudah sampai!");

                }
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Lmove = true;

        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Lmove = false;
        }
        if (Lmove)
        {   
            
            Timer += Time.deltaTime * MoveSpeed;
            if (Player.transform.position != BeforePositionHolder)
            {

                Player.transform.position = Vector3.Lerp(startPosition, BeforePositionHolder, Timer);
                //rb.velocity = new Vector2(1f, 0);
            }
            else
            {
                if (BeforeNode > PathNode.Length - 1)
                {
                    BeforeNode--;
                    CheckNode();
                }
                else
                {
                Lmove = false;
                Debug.Log("Sudah sampai!");

                }
            }
        }
    }
}
