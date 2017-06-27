using UnityEngine;
using System.Collections;

public class CharaAni : MonoBehaviour {
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

	void Update () {
        anim.SetBool("Roll", Pad.ClickCheck != "false");

    }
}
