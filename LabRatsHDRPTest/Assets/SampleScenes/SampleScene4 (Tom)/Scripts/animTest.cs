using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTest : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("isDancing", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            if (!anim.GetBool("isDancing"))
                anim.SetBool("isDancing", true);
            else
                anim.SetBool("isDancing", false);
        }
    }
}
