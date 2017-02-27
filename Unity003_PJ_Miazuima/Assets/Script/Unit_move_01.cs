using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_move_01 : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    { // 포인팅 지정
        target = Waypoint.points[0];
    }
    void Update()
    { // 포인팅 이동
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);


        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }
    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoint.points.Length - 1)
        {
            print("waring");
            Destroy(gameObject);
        }
        wavepointIndex++;
        target = Waypoint.points[wavepointIndex];
    }

}
