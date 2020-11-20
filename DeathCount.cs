using UnityEngine.UI;
using UnityEngine;
using System.Collections;


public class DeathCount : MonoBehaviour {

    public Text DeathText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        DeathText.text = ("Deaths: ") + GameManager.Deathcount.ToString();

    }
}
