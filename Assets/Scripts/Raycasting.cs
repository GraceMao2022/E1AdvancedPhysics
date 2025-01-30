using UnityEngine;

public class Raycasting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // incorrect: raycasting from inside object
        // RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * 10);
        // correct raycast
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(1, 0, 0), Vector2.right * 10);

        // Do stuff if nothing was hit
        if (hit.collider == null)
        {
            // visualize raycast from inside object
            //Debug.DrawRay(transform.position, Vector3.right * 1000, Color.red);

            // correct visualization
            Debug.DrawRay(transform.position + new Vector3(1, 0, 0), Vector3.right * 1000, Color.red);
        }
        else
        {
            //visualize raycast from inside object
            //Debug.DrawRay(transform.position, Vector3.right * 1000, Color.green);

            //correct visualization
            Debug.DrawRay(transform.position + new Vector3(1, 0, 0), Vector3.right * 1000, Color.green);
        }

    }
}
