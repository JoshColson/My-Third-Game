using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDeaths : MonoBehaviour {

    public Text TotalDeaths;
	
	// Update is called once per frame
	void Update ()

    {
        TotalDeaths.text = ("Total Deaths: ") + PlayerPrefs.GetInt("TotalDeaths").ToString();
	}
}
