using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    float moveSpeed  = 10;
    protected  virtual float LeftBound { get; set; } = -15;

    protected float MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value >= 0 ? value : 0; }
    }




    private PlayerController playerControllerScript;
    protected void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            Move();
        }

        DestoryIfBoundary();
        
    }


    protected virtual void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
    }
    
    void DestoryIfBoundary()
    {
        if (transform.position.x < LeftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
