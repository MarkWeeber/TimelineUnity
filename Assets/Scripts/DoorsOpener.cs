using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsOpener : MonoBehaviour
{
    private HingeJoint [] doorJoints = null;
    private void Start()
    {
        doorJoints = GetComponentsInChildren<HingeJoint>();
    }

    public void OpenDoors()
    {
        if(doorJoints != null)
        {
            foreach (HingeJoint item in doorJoints)
            {
                item.useMotor = true;
            }
        }
    }
}
