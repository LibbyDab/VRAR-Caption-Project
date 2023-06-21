using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caption_Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 captionPosition = new Vector3(-2.5f, 0.0f, -4.0f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, captionPosition, step);

    }

}