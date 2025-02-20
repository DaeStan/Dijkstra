using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoider : Kinematic
{
    Seek myMoveType;
    ObstacleAvoidance myAvoidType;

    void Start()
    {
        myMoveType = new Seek();
        myMoveType.character = this;
        myMoveType.target = myTarget;

        myAvoidType = new ObstacleAvoidance();
        myAvoidType.character = this;
        myAvoidType.target = myTarget;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate = myMoveType.getSteering();
        steeringUpdate.linear.y = 0f;
        base.Update();
    }
}
