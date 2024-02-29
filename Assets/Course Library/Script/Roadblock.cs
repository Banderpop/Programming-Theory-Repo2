using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roadblock : Obstacle
{
    // Start is called before the first frame update
    
    new void Start()
    {
        base.Start();
        
    }

    Roadblock()
    {
        MoveSpeed = 8;
    }
    // Update is called once per frame
}
