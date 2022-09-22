using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendChecker : MonoBehaviour
{
    public int friendNum = 0;
    bool finished = false;
    public AudioSource win;
    public GameObject condra;
    // Start is called before the first frame update
    void Start()
    {
        condra.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished&&friendNum>=5)
        {
            finished = true;
            condra.SetActive(true);
            win.Play();
        }
    }
}
