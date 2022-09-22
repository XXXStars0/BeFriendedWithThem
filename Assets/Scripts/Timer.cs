using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float playtime;
    private TMPro.TextMeshProUGUI timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = this.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playtime = Mathf.Floor(Time.time);
        timer.text = "Timer: "+playtime;
    }
}
