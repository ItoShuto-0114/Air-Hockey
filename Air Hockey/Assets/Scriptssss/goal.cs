using System.Collections;
using UnityEngine;

public class goal : MonoBehaviour
{
    [SerializeField] GameObject _puckPrefab;
    [SerializeField] Vector3 _startPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("puck"))
        {
            Destroy(other.gameObject);
            Debug.Log("ゴール！");
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(_puckPrefab, _startPos, Quaternion.identity);
        Debug.Log("リスタート");
    }
}
