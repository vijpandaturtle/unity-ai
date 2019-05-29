﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    //colour gene
    public float r;
    public float g;
    public float b;

    //If clicked on, the person dies
    bool dead = false;

    public float timeToDie = 0;

    //Accessing game objects 
    SpriteRenderer sRenderer;
    Collider2D sCollider;

    //On clicking a certain character/collider 
    void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        //Debug.Log("Dead at :" + timeToDie);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
