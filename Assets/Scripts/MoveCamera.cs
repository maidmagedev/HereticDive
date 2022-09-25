using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Moving Cameras on Rigidbodies can be a little buggy (apparently), so we just have this script handling it instead.
// Originally made from this tutorial: "FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial by Dave / GameDevelopment" : https://www.youtube.com/watch?v=f473C43s8nE&t=263s&ab_channel=Dave%2FGameDevelopment

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
