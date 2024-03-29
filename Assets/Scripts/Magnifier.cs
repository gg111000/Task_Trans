using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
