using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wonder : Seek
{
    protected override Vector3 getTargetPosition()
    {
        return target.transform.position + Random.insideUnitSphere * 50;

       // Vector3 circlePoint = Random.insideUnitCircle.normalized;
       // return target.transform.position + target.transform.forward + (target.transform.right * circlePoint.x * 20) + (target.transform.up * circlePoint.y * 20);
    }
}