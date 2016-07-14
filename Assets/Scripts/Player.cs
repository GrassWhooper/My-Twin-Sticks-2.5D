using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    MyKeyFrame keyframe, keyframe2;

	// Use this for initialization
	void Start ()
    {
        Vector3 V = new Vector3();
        float tim = new float();
        Quaternion Q = new Quaternion();
        keyframe2 = new MyKeyFrame(tim, V, Q);
    }
	
	// Update is called once per frame
	void Update ()
    {

	}
}
