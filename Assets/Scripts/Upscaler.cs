using UnityEngine;

public class Upscaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += _speed * Time.deltaTime * Vector3.one;
    }
}