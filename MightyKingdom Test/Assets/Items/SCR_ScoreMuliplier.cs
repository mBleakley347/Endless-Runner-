using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_ScoreMuliplier : SCR_Items
{
    [SerializeField] private int mult;
    [SerializeField] private float timeLimit;

    public override void PickUp()
    {
        SCR_Manager.instance.ChangeScoreMult(mult, timeLimit);
    }
}
