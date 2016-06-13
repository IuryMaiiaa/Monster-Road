using UnityEngine;
using System.Collections;

public class CameraFallow : MonoBehaviour {
    public Transform playerPosicao;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(playerPosicao.position.x+10, playerPosicao.position.y+22,
                                                playerPosicao.position.z-20);
	}
}
