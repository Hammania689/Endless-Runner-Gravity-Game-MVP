using UnityEngine;
using System.Collections;

public class ProcedualFloor : MonoBehaviour
{
    public GameObject floor;
    public Transform start;
    public GameObject holder;

    float offset;
    int counter = 0;
    
	void Update ()
    {
        while(counter < 25)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(floor, start.position + new Vector3(offset, 0), start.rotation, holder.transform);
                for (int j = 0; j < 10; j++)
                {
                    Debug.Log("spawn here ");
                    offset += 1f;
                    counter ++;
                }
            }
        }
    }
}
