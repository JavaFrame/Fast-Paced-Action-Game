﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyWeapon : Weapon
{
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override WeaponReturn TryToAttack()
    {
        return WeaponReturn.Attacked;
    }

}