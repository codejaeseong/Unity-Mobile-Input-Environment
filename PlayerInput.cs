using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerInput : MonoBehaviour
{
    public FixedJoystick leftJoystick;
    public FixedTouchField touchField;
    public FixedButton button;
    protected ThirdPersonUserControl control;

    protected float cameraAngle;
    protected float cameraAngleSpeed = 0.2f;

    private void Start()
    {
        control = GetComponent<ThirdPersonUserControl>();
    }

    private void Update()
    {
        control.m_Jump = button.pressed;
        control.hInput = leftJoystick.input.x;    
        control.vInput = leftJoystick.input.y;    


    }
}
