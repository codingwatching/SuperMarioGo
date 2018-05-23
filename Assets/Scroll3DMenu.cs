﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll3DMenu : MonoBehaviour {

    public List<MenuButton> menuButtons;

    private Slider slider;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();

        List<float> buttonPositions = new List<float>();
        for (int i = 0; i < menuButtons.Count; ++i)
        {
            buttonPositions.Add(menuButtons[i].getPosition().x);
        }
        slider.setPositions(buttonPositions);
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void scrollLeft()
    {
        slider.moveLeft();
    }

    public void scrollRight()
    {
        slider.moveRight();
    }

    public bool ready()
    {
        return slider.ready();
    }
}