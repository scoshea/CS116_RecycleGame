using UnityEngine;
using System.Collections;

public class throwTrash : MonoBehaviour {
    public float digestionTime;
    public float multiplier;
    public int destroyTime;

    private Vector3 lastMousePosition;
    private Vector3 newMousePosition;
	private Vector2 distance;
	private Vector3 distance2;
	private Rigidbody2D rb;
	private bool moveByBelt;
	private bool startCounting;
	private float time;

	GameObject compost;
	Animator compostanim;

	GameObject landfill;
	Animator landfillanim;


	GameObject recycle;
	Animator recycleanim;

    void Start()
    {
		moveByBelt = true;
		startCounting = false;
		time = 0; 
		//starts idle animations
		compost = GameObject.Find("composite bin");
		compostanim = compost.GetComponent<Animator> ();

		landfill = GameObject.Find("landfill bin");
		landfillanim = landfill.GetComponent<Animator> ();

		recycle = GameObject.Find ("recycle bin");
		recycleanim = recycle.GetComponent<Animator> ();
    }

    void Update()
    {
		if (moveByBelt)
			transform.Translate(Vector3.down * difficultySettings.moveSpeed);
		timeOut ();
    }
		

    void OnMouseDown()
    {
        lastMousePosition = Input.mousePosition;
    }


    void OnMouseUp()
	{
		// disable collider so player cannot swipe twice

		moveByBelt = false;
		newMousePosition = Input.mousePosition;
		distance = newMousePosition - lastMousePosition;

		// making sure that x and y values are not 0
		if (Mathf.Abs(distance.x) < 0.1f)
			distance.x = 0.1f;
		if (Mathf.Abs(distance.y) < 0.1f)
			distance.y = 0.1f;
		
		float xsquare = distance.x * distance.x;
		float ysquare = distance.y * distance.y;
		distance2 = distance / (Mathf.Sqrt (xsquare + ysquare));

		rb = GetComponent<Rigidbody2D> ();
		rb.isKinematic = false;
		rb.AddForce (distance2 * multiplier);

		startCounting = true;
		//Destroy(gameObject, destroyTime);
		compostanim.SetInteger ("State", 0); //restarts compost idle animation
		landfillanim.SetInteger ("State", 0); //restarts landfill idle animation
		recycleanim.SetInteger("State", 0);
	}

	private void timeOut()
	{
		if (startCounting)
			time += Time.deltaTime;
		if (time > destroyTime) 
		{
			difficultySettings.failedRecord.Add (gameObject.name.Substring(0, gameObject.name.Length - 7));
			Destroy (gameObject);
		}
	}

	/*
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objectPosition;
    } 
    */

    
	// bin collisions
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == gameObject.tag)
        {
			difficultySettings.score += 1;
			difficultySettings.playRecord.Add (gameObject.name.Substring(0, gameObject.name.Length - 7));
			if (gameObject.tag == "recycle")
            {
                difficultySettings.digestionTime_rec = digestionTime;
				recycleanim.SetInteger ("State", 1);
            }

            if (gameObject.tag == "composite")
            {
                difficultySettings.digestionTime_com = digestionTime;
                compostanim.SetInteger("State", 1); //switches idle to eating animation
            }

            if (gameObject.tag == "landfill")
            {
                landfillanim.SetInteger("State", 1); //switches idle to eating animation
            }
            Destroy(gameObject);
        }
    }
}