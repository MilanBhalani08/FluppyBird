using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class pipes : MonoBehaviour
{
    public GameObject[] wall;
    public Transform point;
    // Start is called before the first frame update
    void Start()
    {           
        
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < point.position.x)
        {
            transform.position = new Vector2(transform.position.x + 15f, transform.position.y);
            int r = Random.Range(0, wall.Length);
            Vector2 posX = new Vector2(transform.position.x, Random.Range(5.5f, 9f));
            Instantiate(wall[r], posX, Quaternion.identity);
        }
    }
}