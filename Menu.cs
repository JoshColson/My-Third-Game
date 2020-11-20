using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame()

    {

        PlayerPrefs.SetInt("ScoreFile", 0);
        PlayerPrefs.SetInt("Level1Score", 0);
        PlayerPrefs.SetInt("Level2Score", 0);
        PlayerPrefs.SetInt("Level3Score", 0);
        PlayerPrefs.SetInt("Level4Score", 0);
        PlayerPrefs.SetInt("Level5Score", 0);
        PlayerPrefs.SetInt("Level6Score", 0);
        PlayerPrefs.SetInt("Level7Score", 0);
        PlayerPrefs.SetInt("Level8Score", 0);
        PlayerPrefs.SetInt("Level9Score", 0);
        PlayerPrefs.SetInt("Level10Score", 0);
        PlayerPrefs.SetInt("TotalDeaths", 0);
        PlayerPrefs.SetInt("CloseCall", 1);


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);



        //TEMPORARY:

        //PlayerPrefs.SetInt("highscore", 0);

        //Debug.Log("Highscore record: " + PlayerPrefs.GetInt("highscore"));



    }
}

