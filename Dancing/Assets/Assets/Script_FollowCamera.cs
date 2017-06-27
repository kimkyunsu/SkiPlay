using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Script_FollowCamera : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
            return;

        Vector3 pos = this.transform.position;
        pos.y = pos.y + 3;

        Vector3 cpos = Camera.main.transform.position;
        cpos.x = pos.x;

        Camera.main.transform.position = cpos;
        Camera.main.transform.LookAt(pos);
	}
}
