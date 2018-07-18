using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {
    
    public GameObject player;
    public Camera camera = null;
    public int movementSpeed;
	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    void Update()
    {
        // Moving Forward for player
        this.player.transform.position += transform.forward * Time.deltaTime * movementSpeed;
        camera.transform.position = this.player.transform.position;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        for (int i = 0; i < Input.touches.Length; i++)
        {
            if (isOdd(Input.touches[0].tapCount))
            {
                movementSpeed = 0;
            }
            else if (!isOdd(Input.touches[0].tapCount))
            {
                movementSpeed = 3;
            }
        }
    }
    private bool isOdd(int value)
    {
        return value % 2 != 0;
    }
}
