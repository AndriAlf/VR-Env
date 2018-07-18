using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DateScript : MonoBehaviour {

    public Text dateText;
	// Update is called once per frame
	void Update () {
        DateTime tanggal = DateTime.Now;
        dateText.text = tanggal.ToString("dddd, dd MMMM yyyy");
	}
}
