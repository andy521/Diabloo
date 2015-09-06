﻿using UnityEngine;
using System.Reflection;
using System.Collections;
using fuckRPGLib;

public class Dash : Skill
{

    public Dash ( )
    {
        OnAddingEffect();
    }

    protected override void OnAddingEffect ( )
    {
        // Debug.Log("PLayer learn Dash!!!!");
    }

    public override void OnRemovingEffect ( )
    {
        // Debug.Log("Player remove Dash!!!!");
    }

    // a active skill must both have a "Launch", a "Lasting" and a "Stop"
    // an instantaneous effect when ues this skill
    // only called one time
    static public void OnLaunch ( )
    {
        // Debug.Log("Launch Dash!!!");
    }

    // a lasting effect, called every frame at duration
    // a normalized time t
    static public void OnLasting (float t)
    {
        // Debug.Log("Dashing!!!");
    }

    // a skill has already stopped
    static public void OnStop ()
    {
        // Debug.Log("Dash stop!");
    }


}
