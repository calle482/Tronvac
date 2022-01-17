using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{

     public Vector3 positionToMoveTo;

    void Start()
    {
        
        TargetMovement();
        StartCoroutine(LerpPosition(positionToMoveTo, 1));
        
    }
    // Förflyttar enemyn till den random plats som blivit vald
     IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;

        while (time < duration)
        {
             transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
        
        TargetMovement();

    }


    // Väljer den random platsen enemyn ska röra sig mot
    void TargetMovement()
    {
        positionToMoveTo = new Vector3(Random.Range(17, 33), Random.Range(1,9), Random.Range(46,46));
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
    }
}
