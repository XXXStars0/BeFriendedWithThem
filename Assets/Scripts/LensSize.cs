using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LensSize : MonoBehaviour
{
    private TMPro.TextMeshProUGUI LensIndecator;
    public CinemachineVirtualCamera cam;
    // Start is called before the first frame update
    void Start()
    {
        LensIndecator = this.GetComponent<TMPro.TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        float siz = cam.m_Lens.OrthographicSize;
        LensIndecator.text = "Lens Size: " + siz;
    }
}
