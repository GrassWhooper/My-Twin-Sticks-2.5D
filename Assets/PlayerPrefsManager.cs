using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY="Master Volume";
    const string UNLOCK_LEVEL_KEY = "Unlock_Level_";
    const string CURRENT_lEVEL_KEY = "Current_Level_";


    public static void SetCurrentLevel(int level)
    {
        if (level >= 0 && level <= SceneManager.sceneCountInBuildSettings)
        {
            PlayerPrefs.SetInt(CURRENT_lEVEL_KEY, level );
        }
        else
        {
            Debug.LogWarning("Level out of Range");
        }
    }

    public static int GetCurrentLevel()
    {
            int thecurlevel = PlayerPrefs.GetInt(CURRENT_lEVEL_KEY);
            return thecurlevel;
    }

    public static void ReSetLevelUnlocks(int[] AllLevelsArray)
    {
        PlayerPrefs.SetInt(CURRENT_lEVEL_KEY, 0);
        foreach (int item in AllLevelsArray)
        {
            PlayerPrefs.SetInt(UNLOCK_LEVEL_KEY + item, 0);
        }
    }

    public static int IsLevelUnlocked(int level)
    {
        if (level <= SceneManager.sceneCountInBuildSettings - 1 && level >= 0)
        {
            return PlayerPrefs.GetInt(UNLOCK_LEVEL_KEY + level);
        }
        else
        {
            Debug.Log(SceneManager.sceneCountInBuildSettings - 1);

            // use 0 for false. and/or out of range
            Debug.LogWarning("Level Out OF Range");
            return 0;
        }
    }
    public static void UnlockLevel(int level)
    {

        //1 for true
        if (SceneManager.sceneCountInBuildSettings - 1 >= level  && level>=0)
        {
            print("level" + level + "-----" +"Unlcked");
            
            PlayerPrefs.SetInt(UNLOCK_LEVEL_KEY + level, 1);
        }
        else
        {
            Debug.LogWarning("Level Out OF Range");
        }
        
    }

    public  static  void SetMasterVolume(float volume)
    {
        if (volume>=0 &&volume<=1)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
    }
    public  static  float GetMasterVolume()
    {
       return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);

    }

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
