using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour{
    public float moveSpeed = 4;
    public float deadZone = -25;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            // Debug.Log("Message") is a good way to see messages when a function is executed and helps debugging.
            Destroy(gameObject);
        }
    }
}
