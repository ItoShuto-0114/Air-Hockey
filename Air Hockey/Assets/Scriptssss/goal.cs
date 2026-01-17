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
           _puckPrefab.SetActive(false);
            Debug.Log("ゴール！");
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3f);
        _puckPrefab.transform.position = _startPos;
        Debug.Log("リスタート");
    }
}
