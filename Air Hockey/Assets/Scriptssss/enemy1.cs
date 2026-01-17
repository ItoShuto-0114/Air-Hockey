using UnityEngine;

public class enemy1 : MonoBehaviour
{
    [SerializeField] Transform _puck;
    [SerializeField] GameObject _puckprehub;
    [SerializeField] float _speed = 5;
    public bool _isnear;
    void Update()
     {
       
        Debug.Log(_isnear);
        if (_isnear == true)
        {
            
            Vector3 target = new Vector3(
                _puck.position.x,
                transform.position.y,
                _puck.position.z
            );

            transform.position = Vector3.MoveTowards(
                transform.position,
                target,
                _speed * Time.deltaTime
                );
        }
        else
        {

        }
    }
}
