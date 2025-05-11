using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class home : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playbtn()
    {
        SceneManager.LoadScene("PLAY");
    }
    public void controll()
    {
        SceneManager.LoadScene("SHOP");
    }
    public void pouse()
    {
        SceneManager.LoadScene("pouse");
    }
}
