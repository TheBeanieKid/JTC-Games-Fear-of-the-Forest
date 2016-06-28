using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    float speed = 4.0f;
    public bool move = true;
    Vector3 pos;
    Transform tr;

    public bool currentPosEquals = true;

    public bool up = true;
    public bool down = true;
    public bool left = true;
    public bool right = true;

    void Start()
    {
        pos = transform.position;
        tr = transform;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D) && tr.position == pos)
        {
            if (right == true)
            {
                pos += Vector3.right;
            }
        }
        else if (Input.GetKey(KeyCode.A) && tr.position == pos)
        {
            if (left == true)
            {
                pos += Vector3.left;
            }
        }
        else if (Input.GetKey(KeyCode.W) && tr.position == pos)
        {
            if (up == true)
            {
                pos += Vector3.up;
            }
        }
        else if (Input.GetKey(KeyCode.S) && tr.position == pos)
        {
            if (down == true)
            {
                pos += Vector3.down;
            }
        }

        if (move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
            move = true;
        }
        else
        {
            transform.position = transform.position;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        //if (coll.gameObject.tag == "Collide")
        //{
        //    move = false;
        //    StartCoroutine(Wait());
        //}

    }

    void OnCollisionStay()
    {
        //for (int i = 1; i > 0; i++)
        //{
        //    StartCoroutine(Wait());
        //    //move = false;
        //}
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.0000001f);
        move = true;
    }
}
