using UnityEngine;
using System.Collections;

public class PlayerStartPoint : MonoBehaviour {
    private PlayerController thePlayer;
    private CameraController theCamera;

    public Vector2 startDirection;
	
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        thePlayer.transform.position = transform.position;
        thePlayer.lastMove = startDirection;

        theCamera = FindObjectOfType<CameraController>();
        theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
	}
	
	
	void Update () {
	
	}
}
