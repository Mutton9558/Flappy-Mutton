using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectScript : MonoBehaviour{
    public Rigidbody2D myRigitBody;
    public float flapStrength;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            myRigitBody.velocity = Vector2.up * flapStrength;
        }

        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }
}
