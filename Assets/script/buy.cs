using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        SceneManager.LoadScene("PLAY");
    }
    public void newbird(int birdindex)
    {
        PlayerPrefs.SetInt("birdindex",birdindex);
        print(birdindex);
    }
}