using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float speed = 4.0f;
    public bool move = true;
    Vector3 pos;
    Transform tr;
    Animator anim;

    public bool currentPosEquals = true;

    public bool up = true;
    public bool down = true;
    public bool left = true;
    public bool right = true;

    private Vector3 mousePosition;
    private Vector3 direction;
    private float distanceFromObject;

    void Start()
    {
        pos = transform.position;
        tr = transform;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z));
        GetComponent<Rigidbody2D>().transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg - 90);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetInteger("move", 1);
            transform.Translate(0, 1 * speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //pos = transform.position;
    }

    void OnCollisionStay2D()
    {
        //pos = transform.position;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.0000001f);
        move = true;
    }
}
