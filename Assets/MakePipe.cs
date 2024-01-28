using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timediff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timediff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(4.45f, Random.Range(-1.35f, 4f), 0);
            timer = 0;
            Destroy(newPipe, 10.0f);
        }
    }
}
