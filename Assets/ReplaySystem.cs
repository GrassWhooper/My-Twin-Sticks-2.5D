using UnityEngine;
using System.Collections;

public class ReplaySystem : MonoBehaviour {

    private const int bufferFrames=300;
    private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
    private Rigidbody rigidB;
    private GameManager gameManager;
    private bool selectedInitalFrame = false;
    int startingFrame=0;

    void playBack()
    {
        rigidB.isKinematic = true;
        int frames = Time.frameCount % bufferFrames;
        transform.position = keyFrames[frames].Position;
        transform.rotation = keyFrames[frames].Rotation;
        //print("Playing back : frames : " + frames);
    }

    void Record()
    {
        rigidB.isKinematic = false;
        int frames = Time.frameCount % bufferFrames;
        float time = Time.time;
        keyFrames[frames] = new MyKeyFrame(time,transform.position,transform.rotation);
        //print("recording frames  : "+frames);
    }

	// Use this for initialization
	void Start ()
    {
        rigidB = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
//        selectedInitalFrame = false;
//        startingFrame = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameManager.recording == true)
        {
            Record();
        }
        else
        {
            playBack();
        }

    }
}

public struct MyKeyFrame
{
    public Vector3 Position;
    public Quaternion Rotation;
    public float frameTime;
    
    public MyKeyFrame(float aTime , Vector3 Pos , Quaternion Rot)
    {
        frameTime = aTime;
        Position = Pos;
        Rotation = Rot;
    }
}