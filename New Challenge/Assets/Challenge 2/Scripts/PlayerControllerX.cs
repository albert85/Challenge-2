using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeCounter = 0;
    public float dogSpawnDelay = 1f;


    // Update is called once per frame
    void Update()
    {
        timeCounter = timeCounter
            + Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (timeCounter > dogSpawnDelay))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeCounter = 0;
        }

    }

}
