using UnityEngine;
using System.Collections;

public class CamerMovement : MonoBehaviour {

    public GameObject player;
    Vector3 camTrans;

	// Update is called once per frame
	void FixedUpdate ()
    {
        camTrans.x  = player.transform.position.x + 7;
        transform.position = new Vector3(camTrans.x,0,-10);
	}
}
