using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class HalamanManager : MonoBehaviour {

    public GameObject ARCam;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

    public void StartDemoScene()
    {
        SceneManager.LoadScene("DemoScene");
        Destroy(ARCam);
        VuforiaRuntime.Instance.Deinit();
    }
}
