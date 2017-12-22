using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

    public Animation anim;
    public AnimationClip walk;
    public AnimationClip idle;
    

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            anim.clip = walk;
            anim.Play();
        }
        else
        {
            anim.clip = idle;
            anim.Play();
        }
    }
}
