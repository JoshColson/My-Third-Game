using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public Text highscoreText;







    // Use this for initialization
    void Start ()
    {


        if (PlayerPrefs.GetInt("Level1Score") + PlayerPrefs.GetInt("Level5Score") + PlayerPrefs.GetInt("Level4Score") + PlayerPrefs.GetInt("Level3Score") + PlayerPrefs.GetInt("Level2Score") + PlayerPrefs.GetInt("Level6Score") + PlayerPrefs.GetInt("Level7Score") + PlayerPrefs.GetInt("Level8Score") + PlayerPrefs.GetInt("Level9Score") + PlayerPrefs.GetInt("Level10Score") > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", (PlayerPrefs.GetInt("Level1Score") + PlayerPrefs.GetInt("Level5Score") + PlayerPrefs.GetInt("Level4Score") + PlayerPrefs.GetInt("Level3Score") + PlayerPrefs.GetInt("Level2Score") + PlayerPrefs.GetInt("Level6Score") + PlayerPrefs.GetInt("Level7Score") + PlayerPrefs.GetInt("Level8Score") + PlayerPrefs.GetInt("Level9Score") + PlayerPrefs.GetInt("Level10Score")));
            PlayerPrefs.Save();

            PlayerPrefs.SetInt("newHighscore", 1);
        }


        highscoreText.text = PlayerPrefs.GetInt("highscore").ToString();




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
