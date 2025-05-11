using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform bird,bird1;
    Vector2 off;
    int birdindex = 0;
    // Start is called before the first frame update
    void Start()
    {
        off = transform.position - bird.position;
        birdindex = PlayerPrefs.GetInt("birdindex", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(birdindex==0)
        {
            transform.position = new Vector3(bird.position.x + off.x, transform.position.y, transform.position.z);
        }
        if(birdindex==1)
        {
            transform.position = new Vector3(bird1.position.x + off.x, transform.position.y, transform.position.z);
        }    
    }
}
