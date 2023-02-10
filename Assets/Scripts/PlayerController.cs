using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; //For loading the endgame scene
using TMPro;

public class PlayerController : MonoBehaviour
{
	public float speed = 100.0f;
	public TextMeshProUGUI countText;
	public GameObject winTextObject;

	private float movementX;
	private float movementY;

	private Rigidbody rb;
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winTextObject.SetActive(false);
	}

	void FixedUpdate()
	{
		Vector3 movement = new Vector3(movementX, 0.0f, movementY);

		rb.AddForce(movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);

			count = count + 1;
			
			SetCountText();
		}
	}

	void OnMove(InputValue value)
	{
		Vector2 v = value.Get<Vector2>();

		movementX = Input.GetAxis("Horizontal");
		movementY = Input.GetAxis("Vertical");
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();

		if (count >= 13)
		{
			SceneManager.LoadScene("EndGame");
			//winTextObject.SetActive(true); Removed the win text as the endgame scene will cover the
			//purpose of the text
		}
	}

	public void changeSpeed(float newSpeed)
	{
		speed = newSpeed * 100;
	}
}

