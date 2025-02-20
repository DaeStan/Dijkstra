using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitChaser : Kinematic
{
    PathFinder myMoveType;
    LookWhereGoing myRotateType;
    public GameObject[] myPath;

    void Start()
    {
        myRotateType = new LookWhereGoing();
        myRotateType.character = this;
        myRotateType.target = myTarget;

        myMoveType = new PathFinder();
        myMoveType.character = this;
        myMoveType.targetpath = myPath;
    }
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.angular = myRotateType.getSteering().angular;
        steeringUpdate.linear = myMoveType.getSteering().linear;
        base.Update();
    }
}
