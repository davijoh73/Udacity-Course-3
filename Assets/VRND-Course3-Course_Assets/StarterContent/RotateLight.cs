using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour {

    public GameObject directionalLight;
    public Animator sunRotationAnimation;
    float startTime = 0f;
    bool isPressed = false;

	// Use this for initialization
	void Start () {
        sunRotationAnimation.StartPlayback();
	}
	
	// Update is called once per frame
	void Update () {
        //checking if Triggered is true and assigning it to a variable
        if (GvrViewer.Instance.Triggered)
        {
            isPressed = true;
        }
        if (isPressed)
        {
            ActivateRotation();
        }
        Quaternion startRotation = Quaternion.Euler(50f, 30f, 0f);
        Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f);
        if (isPressed == true)
        {
            sunRotationAnimation.StopPlayback();
            startTime += Time.deltaTime;
        }
	}

    public void ActivateRotation()
    {
        isPressed = true;
        sunRotationAnimation.SetBool("ChangeColor", true);
    }
}
