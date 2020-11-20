using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public static int Deathcount = 0;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public GameObject newHighscoreUI;

    public static int sceneID = 0;






    void Start()
    {
        PlayerPrefs.SetInt("newHighscore", 0);


        sceneID = SceneManager.GetActiveScene().buildIndex;

        //Debug.Log("Level 1 Score: " + PlayerPrefs.GetInt("Level1Score"));
        //Debug.Log("Level 2 Score: " + PlayerPrefs.GetInt("Level2Score"));
        //Debug.Log("Level 3 Score: " + PlayerPrefs.GetInt("Level3Score"));
        //Debug.Log("Level 4 Score: " + PlayerPrefs.GetInt("Level4Score"));
        //Debug.Log("Level 5 Score: " + PlayerPrefs.GetInt("Level5Score"));
        //Debug.Log("Level 6 Score: " + PlayerPrefs.GetInt("Level6Score"));
        //Debug.Log("Level 7 Score: " + PlayerPrefs.GetInt("Level7Score"));
        //Debug.Log("Level 8 Score: " + PlayerPrefs.GetInt("Level8Score"));
        //Debug.Log("Level 9 Score: " + PlayerPrefs.GetInt("Level9Score"));
        //Debug.Log("Level 10 Score: " + PlayerPrefs.GetInt("Level10Score"));
        //Debug.Log("ScoreFile " + PlayerPrefs.GetInt("ScoreFile"));


        Application.targetFrameRate = 60;



        if (sceneID == 11 && (PlayerPrefs.GetInt("newHighscore") == 1))
        {
            newHighscoreUI.SetActive(true);

        }



    } 

    private void Update()


    {
        QualitySettings.vSyncCount = 0;

        if (sceneID == 11 && PlayerPrefs.GetInt("newHighscore") == 1)
        {
            newHighscoreUI.SetActive(true);

        }
    }

    public void CompleteLevel()
    {
        PlayerPrefs.Save();
        completeLevelUI.SetActive(true);
        
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            Deathcount++;
            if (PlayerPrefs.GetInt("CloseCall") > 1)
            {
                PlayerPrefs.SetInt("CloseCall", 1);
            }
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("CloseCall", 1);
    }

}
	

