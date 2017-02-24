using UnityEngine;
using System.Collections;

public class throwTrash : MonoBehaviour {
    public float multiplier;
    public int destroyTime;
    private Vector3 lastMoustPosition;
    private Vector3 newMousePosition;
    private Vector3 force;
    private Rigidbody2D rb;

    void OnMouseDown()
    {
        lastMoustPosition = Input.mousePosition;
    }

    void OnMouseUp()
    {
        newMousePosition = Input.mousePosition;
        force = newMousePosition - lastMoustPosition;
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = false;
        rb.AddForce(force * multiplier);
        Destroy(transform.parent.gameObject, destroyTime);
    }

    /*void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objectPosition;
    }*/
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "recycle")
        {
            scoreKeeper.score += 1;
			BarManager.currentValue += 5;
            Destroy(transform.parent.gameObject);
        }
    }
}
