using UnityEngine;

public class enemyzone : MonoBehaviour
{
    [SerializeField]enemy1 _enemy1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("puck"))
        {
           _enemy1._isnear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("puck"))
        {
            _enemy1._isnear = false;
        }
    }
}
