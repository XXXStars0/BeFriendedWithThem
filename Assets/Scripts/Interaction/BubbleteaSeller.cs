using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleteaSeller : MonoBehaviour
{
    AudioSource yeah;
    AudioSource aww;
    AudioSource bing;
    GameObject g;
    GameObject fc;
    public GameObject talk;
    public GameObject want;
    public GameObject heart;
    public GameObject tea1;
    public GameObject tea2;
    int teanum = 2;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (!friend && talkin)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (g.GetComponent<ItemSlot>().num_leafCoin > 0)
                {
                    talkin = false;
                    talk.SetActive(false);
                    bing.Play();
                    g.GetComponent<ItemSlot>().num_leafCoin -= 1;
                    g.GetComponent<ItemSlot>().num_bubbleTea += 1;
                    teanum -= 1;
                    if (teanum == 1)
                    {
                        Destroy(tea1);
                    }
                    if (teanum == 0)
                    {
                        Destroy(tea2);
                        friend = true;
                        want.SetActive(false);
                        heart.SetActive(true);
                        wait(1);
                        yeah.Play();
                        fc.GetComponent<FriendChecker>().friendNum += 1;
                    }
                }else
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
