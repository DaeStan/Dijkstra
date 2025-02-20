using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : Seek
{
    public GameObject[] targetpath;
    int current;
    float targetRad = .5f;

    public override SteeringOutput getSteering()
    {
        if (target == null)
        {
            current = 0;
            float distanceToTarget = float.PositiveInfinity;
            for(int i = 0;  i < targetpath.Length; i++)
            {
                GameObject choosen = targetpath[i];
                Vector3 vectorToChoosen = choosen.transform.position - character.transform.position;
                float distanceToChoosen = vectorToChoosen.magnitude;
                if(distanceToChoosen < distanceToTarget)
                {
                    current = i;
                    distanceToTarget = distanceToChoosen;
                }
            }
            target = targetpath[current];
        }

        float distance = (target.transform.position - character.transform.position).magnitude;
        if (distance < targetRad)
        {
            current++;
            if (current > targetpath.Length - 1)
            {
                current = 0;
            }
            target = targetpath[current];
        }
        return base.getSteering();
    }
}