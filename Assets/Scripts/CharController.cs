using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CharController : MonoBehaviour
{
    private float x, y;
    private bool isWalking;

    public float walkingSpeed;
    private Animator a;
    public AudioSource walkSE;
    public CinemachineVirtualCamera cam;

    // Start is called before the first frame update
    void Start()
    {
        a = this.GetComponent<Animator>();
        isWalking = false;
        x = 0;
        y = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }


    void Moving()
    {
        a.SetFloat("X", x);
        a.SetFloat("Y", y);
        if (Input.GetKeyDown(KeyCode.W))
        {
            y = 1;
            x = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            y = -1;
            x = 0;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            y = 0;
            x = -1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            y = 0;
            x = 1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Transform>().Translate(x * Time.deltaTime * walkingSpeed, y * Time.deltaTime * walkingSpeed, 0);
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        if (isWalking)
        {
            if (!walkSE.isPlaying)
            {
                walkSE.Play();
            }
        }
        else
        {
            walkSE.Stop();
        }
    }


}
