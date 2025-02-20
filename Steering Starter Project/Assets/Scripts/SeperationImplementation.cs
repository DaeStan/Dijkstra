using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SeperationImplementation : Kinematic
{
    Arrive myMoveType;
    Align myRotateType;
    Separation mySeperation;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Arrive();
        myMoveType.character = this;
        myMoveType.target = myTarget;

        mySeperation = new Separation();
        mySeperation.character = this;
        mySeperation.targets = FindObjectsOfType<Kinematic>();


        myRotateType = new Align();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();

        if (mySeperation.getSteering().linear.magnitude == 0)
        {
            steeringUpdate.linear = myMoveType.getSteering().linear;
        }
        else
        {
            steeringUpdate.linear = mySeperation.getSteering().linear;
        }
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
