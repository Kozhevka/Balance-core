using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private GameActive gameActiveScript;

    private Touch theTouch;

    [SerializeField] float speedMod = 0.01f;
    private Vector3 startPos;
    private Vector3 touchDeltPosition;


}