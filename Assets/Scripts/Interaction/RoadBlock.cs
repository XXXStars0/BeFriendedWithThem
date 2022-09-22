using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBlock : MonoBehaviour
{
    AudioSource yeah;
    AudioSource aww;
    AudioSource bing;
    GameObject g;
    GameObject fc;
    public GameObject talk;
    public GameObject want;
    public GameObject heart;
    public GameObject block1;
    public GameObject block2;
    public GameObject coin2;
    bool friend = false;
    bool talkin = false;
    // Start is called before the first frame update
    void Start()
    {
        yeah = GameObject.Find("Yeah").GetComponent<AudioSource>();
        aww = GameObject.Find("Aww").GetComponent<AudioSource>();
        g = GameObject.Find("ItemSlot");
        fc = GameObject.Find("FriendCount");
        bing = GameObject.Find("Ding").GetComponent<AudioSource>();
        talk.SetActive(false);
        want.SetActive(true);
        heart.SetActive(false);
        coin2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!friend && talkin)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (g.GetComponent<ItemSlot>().num_bubbleTea > 0)
                {
                    talkin = false;
                    friend = true;
                    g.GetComponent<ItemSlot>().num_bubbleTea -= 1;
                    want.SetActive(false);
                    heart.SetActive(true);
                    yeah.Play();
                    fc.GetComponent<FriendChecker>().friendNum += 1;
                    wait(1);
                    Destroy(block1);
                    Destroy(block2);
                    transform.position = new Vector2(4.11f, 10.82f);
                    coin2.SetActive(true);
                    bing.Play();
                }
                else
                {
                    aww.Play();
                }
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!friend && collision.name == "Heroine")
        {
            talk.SetActive(true);
            talkin = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        talk.SetActive(false);
        talkin = false;
    }

    IEnumerator wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }

}
