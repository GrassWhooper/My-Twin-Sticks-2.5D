using UnityEngine;
using System.Collections;


namespace UnityStandardAssets.CrossPlatformInput
{
    public class RecordPhone : MonoBehaviour
    {

        public string Name = "Fire1";
        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
        }



        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}