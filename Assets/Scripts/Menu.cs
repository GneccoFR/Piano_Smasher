using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameManager manager;

    public void Awake()
    {
        manager = FindObjectOfType<GameManager>();
    }

    public void LoadGame(int octaves) {

        Debug.Log("LoadGame");
        Debug.Log(octaves);
        Debug.Log(manager);
        manager.setOctaves(octaves);
        SceneManager.LoadScene("Piano");
    
        
    }

    public void QuitGame ()
    {
      
        Application.Quit();
    }

}
