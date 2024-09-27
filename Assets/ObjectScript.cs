using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectScript : MonoBehaviour{
    public Rigidbody2D myRigitBody;
    public float flapStrength;
    public PlayerScoreScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<PlayerScoreScript>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            myRigitBody.velocity = Vector2.up * flapStrength;
        }

        transform.Rotate(0, 0, 90 * Time.deltaTime);

        if (transform.position.y < -12)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
