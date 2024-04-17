using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();

    [SerializeField]float waitTime = 3f;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(PrintWayPointName());
    }

    // Update is called once per frame

    IEnumerator PrintWayPointName()
    {
        foreach (WayPoint wayPoint in path)
        {
            transform.position = wayPoint.transform.position;
            yield return new WaitForSeconds(waitTime);
            
        }
    }
}
