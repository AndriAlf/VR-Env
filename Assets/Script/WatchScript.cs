using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WatchScript : MonoBehaviour {

    public Text infoJam;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        DateTime watch = DateTime.Now;
        String jam = watch.Hour.ToString().PadLeft(2,'0');
        String menit = watch.Minute.ToString().PadLeft(2,'0');
        String detik = watch.Second.ToString().PadLeft(2, '0');
        infoJam.text = jam + ":" + menit + ":" + detik;
	}
}
