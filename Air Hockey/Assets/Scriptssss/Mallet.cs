using UnityEngine;

public class Mallet : MonoBehaviour
{
    [SerializeField] float _speed = 10;
    Vector3 _move;
    Rigidbody _rb;
    float _time;
    [SerializeField] float _maxforce = 10;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        _rb.linearVelocity = new Vector3(x * _speed, 0, z * _speed);
        if (Input.GetKey(KeyCode.Space))
        {
          _time += Time.deltaTime;
            Debug.Log(_time + "ïbó≠Ç‹Ç¡ÇƒÇÈÇ≈");
            if (_time > _maxforce)
            {
              _time = _maxforce;
                Debug.Log("ç≈ëÂ");
            }

        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            _rb.AddForce(_rb.linearVelocity * 2 * _time, ForceMode.Impulse);
            Debug.Log("ÉIÉâÉ@");
            _time = 0;
        }
    }
}
