using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Barrel : Obstacle
{
    // Start is called before the first frame update

    [SerializeField] int jumpForce = 1;
    [SerializeField] float jumpRate = 1f;
    float time;
    new void Start()
    {
        base.Start();
        time = jumpRate;
    }
    Barrel ()
    {
        MoveSpeed = 10;
    }

    // Update is called once per frame

    //POLYMORPHISM
    protected override void Move()
    {
        base.Move(); 
        time -= Time.deltaTime;

        if(time <= 0)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            time = jumpRate;
        }
    }
}
