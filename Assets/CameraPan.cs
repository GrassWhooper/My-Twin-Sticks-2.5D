using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {
    GameObject player;
    Camera myCamera;
    Vector3 offSet;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
       // myCamera = GetComponent<Camera>();
       // offSet = transform.position - player.transform.position;

    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void LateUpdate()
    {
        //transform.position = player.transform.position+offSet;
        transform.LookAt(player.transform);
    }
}
