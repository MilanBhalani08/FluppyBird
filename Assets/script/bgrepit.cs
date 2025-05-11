using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class bgrepit : MonoBehaviour
{
    public Transform genpoint;
    public GameObject bgprefeb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<genpoint.position.x)
        {
            transform.position = new Vector2(transform.position.x+17.81f, transform.position.y);
            Instantiate(bgprefeb, transform.position, Quaternion.identity);
        }
    }
}
