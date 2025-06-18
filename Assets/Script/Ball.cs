using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 300.0f;
    private void Awake(){
        _rigidbody = GetComponent<Rigidbody2D>();   
    }
    private void Start(){
        resetPosition();
        AddStartingForce();
   
    }

   public void AddStartingForce()
{
    float y = Random.value < 0.5f ? Random.Range(-0.8f, -0.5f) : Random.Range(0.5f, 0.8f);
    float x = Random.value < 0.5f ? 0.8f : -0.8f;

    Vector2 direction = new Vector2(x, y).normalized;
    _rigidbody.linearVelocity = direction * speed * Time.fixedDeltaTime;
}
    

   public void AddForce(Vector2 force){
    _rigidbody.AddForce(force);
   }

   public void resetPosition(){
    _rigidbody.position = Vector2.zero;
    _rigidbody.linearVelocity = Vector2.zero;
   }
}
