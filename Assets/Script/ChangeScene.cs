using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ChangeScene : MonoBehaviour {

    public Camera ARCam;
    public GameObject ARObject;
    public GameObject VRObject;
    public GameObject GVR;

    MixedRealityController.Mode mode = MixedRealityController.Mode.HANDHELD_AR_DEVICETRACKER;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (mode == MixedRealityController.Mode.VIEWER_VR)
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.VIEWER_VR);
            Debug.Log("Mode VR On!");
        }
	}

    public void changeVRScene()
    {
        mode = MixedRealityController.Mode.VIEWER_VR;
        ARCam.clearFlags = CameraClearFlags.Skybox;
        VideoBackgroundManager.Instance.SetVideoBackgroundEnabled(false);
        
        VRObject.SetActive(true);
        ARObject.SetActive(false);
        GVR.SetActive(true);
    }
    public void ChangeARScene()
    {
        mode = MixedRealityController.Mode.HANDHELD_AR_DEVICETRACKER;
        ARCam.clearFlags = CameraClearFlags.Color;
        VideoBackgroundManager.Instance.SetVideoBackgroundEnabled(true);

        VRObject.SetActive(false);
        ARObject.SetActive(true);
        GVR.SetActive(false);
    }
}
