using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    AudioSource bing;
    GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        bing = GameObject.Find("Ding").GetComponent<AudioSource>();
        g = GameObject.Find("ItemSlot");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Heroine")
        {
            bing.Play();
            g.GetComponent<ItemSlot>().num_leafCoin += 1;
            Destroy(gameObject);
        }
    }
}
