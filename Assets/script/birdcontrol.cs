using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Threading;
public class birdcontrol : MonoBehaviour
{
    Rigidbody2D rigid;
    float speed = 5f;
    bool muted = false;
    int checkpoint;
    public Text score;
    public Text hsscore;
    int birdindex = 0;  
    public GameObject bird,bird1;
    public AudioClip Checkpointsound,birddiesound;
    AudioSource sound;
    public bool isgamepause = false;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        hsscore.text = PlayerPrefs.GetInt("HSSCORE", 0).ToString();
        sound = GetComponent<AudioSource>();
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        birdindex = PlayerPrefs.GetInt("birdindex", 0); 
        if(birdindex==0)
        {
            bird.SetActive(true);
            bird1.SetActive(false);
        }
        if(birdindex==1)
        {
            bird1.SetActive(true);
            bird.SetActive(false);         
        }
        // mute 
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("mute", 0);
        }
        else
        {
            muted = PlayerPrefs.GetInt("muted") == 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + checkpoint;
        if (checkpoint > PlayerPrefs.GetInt("HSSCORE", 0))
        {
            PlayerPrefs.SetInt("HSSCORE", checkpoint);
            hsscore.text = PlayerPrefs.GetInt("HSSCORE").ToString();
        }
        if(checkpoint >= PlayerPrefs.GetInt("HIGHSCORE",0))
        {
            PlayerPrefs.SetInt("HIGHSCORE",checkpoint);
        }
        rigid.velocity = new Vector3(speed, rigid.velocity.y);
        if(Input.GetMouseButtonDown(0))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, speed);
        }
        if (transform.rotation.x != 3)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0),speed);
        }
    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="up")
        {
            StartCoroutine(chengescean());
            sound.clip = birddiesound;
            sound.Play();
            animator.SetTrigger("die");
            isgamepause = true;
        }
        if(collision.gameObject.tag=="down")
        {
            StartCoroutine(chengescean());
            sound.clip = birddiesound;
            sound.Play();
            animator.SetTrigger("die");
            isgamepause = true;
        }
        if(collision.gameObject.tag=="pipes")
        {
            StartCoroutine(chengescean());
            sound.clip = birddiesound;
            sound.Play();
            animator.SetTrigger("die");
            isgamepause = true;
        }
        if (collision.gameObject.tag == "checkpoint")
        {
            sound.clip = Checkpointsound;
            Destroy(collision.gameObject);
            sound.Play();
            checkpoint++;
            print(checkpoint);
        }
        
    }
    IEnumerator chengescean()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("restart");
    }
    // mute volume
    public void volume()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
