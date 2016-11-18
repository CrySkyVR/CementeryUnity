using UnityEngine;
using System.Collections;
using StartApp;

public class StartAppBackPlugin : MonoBehaviour{

	void Start () {
	#if UNITY_ANDROID
		//StartAppWrapper.loadAd();
	#endif
    }

	void Update () {
	#if UNITY_ANDROID
		if (Input.GetKeyUp (KeyCode.Escape)) {
            Application.Quit();
        }
	#endif
    }
	

}