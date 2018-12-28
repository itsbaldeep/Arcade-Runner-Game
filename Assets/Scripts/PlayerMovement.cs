using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 500f;
    public float sidewaysForce = 1000f;

    bool moveRight = false;
    bool moveLeft = false;

    void Update() {
        if (Input.GetKey("d") || Input.GetKey("right")) moveRight = true;
        if (Input.GetKey("a") || Input.GetKey("left")) moveLeft = true;
    }

	void FixedUpdate() {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight) rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (moveLeft) rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        moveRight = moveLeft = false;

        if (rb.position.y < -1.3f) FindObjectOfType<GameManager>().EndGame();
	}
}
