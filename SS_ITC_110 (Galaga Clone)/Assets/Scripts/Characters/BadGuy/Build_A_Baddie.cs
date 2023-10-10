using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Baddie : MonoBehaviour
{
    public float speed = 2f;         // Speed of the enemy's movement
    public float amplitude = 1f;     // Amplitude of the sine wave pattern
    public float frequency = 1f;     // Frequency of the sine wave pattern

    private Vector3 startPosition;

    public BadGuyBrain badGuyBrain;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
        startPosition = transform.position;
    }

    private void Update()
    {
        float xPosition = startPosition.x + Mathf.Sin(Time.time * frequency) * amplitude;
        float yPosition = startPosition.y - Time.time * speed;

        // Update the enemy's position
        transform.position = new Vector3(xPosition, yPosition, transform.position.z);
    }
}
