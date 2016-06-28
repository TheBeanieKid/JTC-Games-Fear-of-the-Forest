using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

	void Start ()
    {
	    
	}
	
	void Update ()
    {
        float transformX = transform.position.x;
        float transformY = transform.position.y;

        transformX = GameObject.Find("Player").transform.position.x;
        transformY = GameObject.Find("Player").transform.position.y;
    }
}
