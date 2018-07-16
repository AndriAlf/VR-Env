using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    
    public GameObject player;
    public Camera camera = null;
    public int movementSpeed;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        // Moving Forward for player
        this.player.transform.position += transform.forward * Time.deltaTime * movementSpeed;
        camera.transform.position = this.player.transform.position;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
