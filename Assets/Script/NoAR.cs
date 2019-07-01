using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System.Reflection;
using System;
using UnityEngine.SceneManagement;

public class NoAR : MonoBehaviour {

    public Camera camera;
    // Use this for initialization
    void Start () {
        if (camera.enabled)
        {
            if (camera.GetComponent<VuforiaBehaviour>() != null)
            {
                camera.GetComponent<VuforiaBehaviour>().enabled = false;
                
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Awake()
    {
        try
        {
            EventInfo evSceneLoaded = typeof(SceneManager).GetEvent("sceneLoaded");
            Type tDelegate = evSceneLoaded.EventHandlerType;

            MethodInfo attachHandler = typeof(VuforiaRuntime).GetMethod("AttachVuforiaToMainCamera", BindingFlags.NonPublic | BindingFlags.Static);

            Delegate d = Delegate.CreateDelegate(tDelegate, attachHandler);
            SceneManager.sceneLoaded -= d as UnityEngine.Events.UnityAction<Scene, LoadSceneMode>;
        }
        catch (Exception e)
        {
            Debug.LogWarning("Cant remove the AttachVuforiaToMainCamera action: " + e.ToString());
        }
    }
}
