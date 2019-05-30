﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof(ThirdPersonCharacter))]
public class Brain : MonoBehaviour
{
    public int DNAlength = 1;
    public float timeAlive;
    public DNA dna;

    private ThirdPersonCharacter m_Character;
    private Vector3 m_Move;
    private bool m_Jump;
    bool alive = true;

    //event listener for when it hits dead ground 
    void OnCollisionEnter (Collision obj)
    {
        if(obj.gameObject.tag == "dead")
        {
            alive = false;
        }
    }

    public void Init()
    {
        //Initialize DNA 
        //0 forward 
        //1 back
        //2 left 
        //3 right 
        //4 jump 
        //5 crouch 
        dna = new DNA(DNAlength, 6);
        m_Character = GetComponent<ThirdPersonCharacter>();
        timeAlive = 0;
        alive = true;
    }

    //fixedupdate is called in sync with physics 
    //custom character controller
    private void FixedUpdate()
    {
        //read DNA
        float h = 0;
        float v = 0;
        bool crouch = false;
        if (dna.GetGene(0) == 0) v = 1;
        else if (dna.GetGene(0) == 1) v = -1;
        else if (dna.GetGene(0) == 2) h = -1  
        else if (dna.GetGene(0) == 3)
        else if (dna.GetGene(0) == 4)
        else if (dna.GetGene(0) == 5)
    }
}
