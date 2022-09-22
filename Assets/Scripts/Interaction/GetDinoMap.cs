using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDinoMap : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource bing;
    GameObject g;
    bool tagg = true;
    void Start()
    {
        bing= GameObject.Find("Ding").GetComponent<AudioSource>();
        g = GameObject.Find("ItemSlot");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tagg && collision.name=="Heroine")
        {
            tagg=!tagg;
            bing.Play();
            g.GetComponent<ItemSlot>().num_map += 1;
        }
    }
}
