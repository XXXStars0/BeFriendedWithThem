using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public GameObject map;
    public GameObject leafCoin;
    public GameObject bubbleTea;
    public GameObject Fruit;

    public int num_map;
    public int num_leafCoin;
    public int num_bubbleTea;
    public int num_Fruit;
    // Start is called before the first frame update
    void Start()
    {
        map.SetActive(false); ;
        leafCoin.SetActive(false); ;
        bubbleTea.SetActive(false); ;
        Fruit.SetActive(false); ;
    }

    // Update is called once per frame
    void Update()
    {
        if(num_map>0)
        {
            map.SetActive(true); 
        }
        else
        {
            map.SetActive(false); ;
        }

        if (num_bubbleTea > 0)
        {
            bubbleTea.SetActive(true);
        }
        else
        {
            bubbleTea.SetActive(false); ;
        }

        if (num_leafCoin > 0)
        {
            leafCoin.SetActive(true);
        }
        else
        {
            leafCoin.SetActive(false); ;
        }
        if (num_Fruit > 0)
        {
            Fruit.SetActive(true);
        }
        else
        {
            Fruit.SetActive(false); ;
        }
    }
}
