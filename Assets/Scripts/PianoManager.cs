using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PianoManager : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] List<GameObject> octaves;
    void Awake()
    {
        gameManager = GameManager.GetInstance();
    }

    // Start is called before the first frame update
    void Start()
    {
        int num_octaves = gameManager.getOctaves();
        for(int i=0; i < octaves.Count; i++)
        {
            if (num_octaves - 1 < i)
            {
                octaves.ElementAt(i).SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
