using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour {


    public Text LevelScore;
    public Text CurrentScore;
    public Text LevelComplete;
    public Text LevelDeathcount;
    private int ScoreCalc = 0;
    private int Level;



	// Use this for initialization
	void Start ()
    {
		Level = (int) SceneManager.GetActiveScene().buildIndex;


    }
	
	// Update is called once per frame
	void Update () {




       


        ScoreCalc = PlayerPrefs.GetInt("ScoreFile");
        {
            if (GameManager.Deathcount == 1)
            {
                ScoreCalc = PlayerPrefs.GetInt("ScoreFile") * 2;
            }

            if (GameManager.Deathcount == 0)
            {
                ScoreCalc = (PlayerPrefs.GetInt("ScoreFile") * 3);
            }

            
            else ScoreCalc /= (GameManager.Deathcount);

            ScoreCalc *= PlayerPrefs.GetInt("CloseCall");


                    
                    
        }
        LevelDeathcount.text = ("Deaths: ") + (GameManager.Deathcount);

        LevelComplete.text = ("LEVEL ") + Level;

        LevelScore.text = ("Level Score: ") + ScoreCalc.ToString();

        CurrentScore.text = ("Current Score: ") + (PlayerPrefs.GetInt("Level1Score") + PlayerPrefs.GetInt("Level5Score") + PlayerPrefs.GetInt("Level4Score") + PlayerPrefs.GetInt("Level3Score") + PlayerPrefs.GetInt("Level2Score") + PlayerPrefs.GetInt("Level6Score") + PlayerPrefs.GetInt("Level7Score") + PlayerPrefs.GetInt("Level8Score") + PlayerPrefs.GetInt("Level9Score") + PlayerPrefs.GetInt("Level10Score"));




        if (Level == 1)
        {
            PlayerPrefs.SetInt("Level1Score", ScoreCalc);
        }

        if (Level == 6)
        {
            PlayerPrefs.SetInt("Level6Score", ScoreCalc);
        }

        if (Level == 2)
        {
            PlayerPrefs.SetInt("Level2Score", ScoreCalc);

        }

        if (Level == 3)
        {
            PlayerPrefs.SetInt("Level3Score", ScoreCalc);

        }

        if (Level == 4)
        {
            PlayerPrefs.SetInt("Level4Score", ScoreCalc);

        }

        if (Level == 5)
        {
            PlayerPrefs.SetInt("Level5Score", ScoreCalc);

        }

        if (Level == 7)
        {
            PlayerPrefs.SetInt("Level Score", ScoreCalc);


        }

        if (Level == 8)
        {
            PlayerPrefs.SetInt("Level8Score", ScoreCalc);

        }

        if (Level == 9)
        {
            PlayerPrefs.SetInt("Level9Score", ScoreCalc);

        }

        if (Level == 10)
        {
            PlayerPrefs.SetInt("Level10Score", ScoreCalc);


        }




    }
}
