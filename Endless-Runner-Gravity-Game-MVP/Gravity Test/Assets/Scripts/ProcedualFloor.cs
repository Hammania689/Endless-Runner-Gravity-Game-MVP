using UnityEngine;

public class ProcedualFloor : MonoBehaviour
{
    public GameObject floor;
    public GameObject holder;
    public Transform start;

    float offset;
    int counter = 0;

    public struct Floor
    {
        public int order;
        public GameObject prefab;

        public Floor (int order, GameObject prefab)
        {
            this.order = order;
            this.prefab = prefab;
        }
    }

    void Start()
    {
       while(counter < 25){
            for (int i = 0; i < 10; i++)
            {
                Floor flr = new Floor(counter,floor);
                Instantiate(flr.prefab, start.position + new Vector3(offset, 0), start.rotation, holder.transform);

                for (int j = 0; j < 10; j++)
                    offset += Mathf.RoundToInt(Random.Range(0, 4f));

                counter ++;
                flr.order = counter;
                Debug.Log( flr.order);
            }
        }
    }
}
