using UnityEngine;

public class Credits : MonoBehaviour
{
    public Credits()
    {
        
    }
     void QuitGame ()
    {
        PlayerPrefs.Save();
        Application.Quit();


    }


}


