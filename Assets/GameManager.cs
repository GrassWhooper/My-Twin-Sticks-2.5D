using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public bool recording = true;


    

    void CheckForRecording()
    {
        if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            recording = false;
            print("XXXxxxXXX");
        }
        else
        {
            recording = true;
        }
    }

	// Use this for initialization
	void Start ()
    {
        PlayerPrefsManager.UnlockLevel(2);
        print(PlayerPrefsManager.IsLevelUnlocked(1));
        print(PlayerPrefsManager.IsLevelUnlocked(2));
        recording = true;

    }
	
	// Update is called once per frame
	void Update ()
    {
        CheckForRecording();
    }
}
