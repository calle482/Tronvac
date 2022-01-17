using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject Target;
    public int TargetCount = 0;

    void Update()
    {
        // Spawnar en ny target om det finns mindre än 6 stycken på kartan
        while (TargetCount < 6)
        {
            Instantiate(Target, new Vector3(Random.Range(17, 33), Random.Range(1,9), Random.Range(46,46)) ,Quaternion.identity);
            TargetCount +=1;
        }
    }
}
