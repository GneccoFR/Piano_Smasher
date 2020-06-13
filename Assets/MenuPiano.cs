using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void SimpleRow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
        
    }

    public void DoubleRow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }

    public void TripleRow()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

    public void QuitGame ()
    {
      
        Application.Quit();
    }

}
