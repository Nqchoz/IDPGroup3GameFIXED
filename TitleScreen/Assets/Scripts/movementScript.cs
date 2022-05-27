using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{

    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.05f;
    private float wait;
    private bool isTouching;

    void Update()
    {

        if (wait > 0)
        {
            wait -= Time.deltaTime;
        }
        if (wait < 0)
        {
            wait = 0;
        }

        if (Input.GetKey(KeyCode.W) && !isMoving && wait == 0)
        {
            StartCoroutine(MovePlayer(Vector3.up));
            wait = 0.1f;
        }

        if (Input.GetKey(KeyCode.A) && !isMoving && wait == 0)
        {
            StartCoroutine(MovePlayer(Vector3.left));
            wait = 0.1f;
        }

        if (Input.GetKey(KeyCode.S) && !isMoving && wait == 0)
        {
            StartCoroutine(MovePlayer(Vector3.down));
            wait = 0.1f;
        }

        if (Input.GetKey(KeyCode.D) && !isMoving && wait == 0)
        {
            StartCoroutine(MovePlayer(Vector3.right));
            wait = 0.1f;
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while(elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
    }

}