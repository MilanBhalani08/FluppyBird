using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
    public Button playpage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void retry()
    {
        SceneManager.LoadScene("PLAY");
    }
    public void home()
    {
        SceneManager.LoadScene("HOME");
    }
    // game pouse function 
    public void play()
    {
        SceneManager.LoadScene("PLAY");
    }
}
