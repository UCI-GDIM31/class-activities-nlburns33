using UnityEditor.Experimental.GraphView;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float _speed;
    public GameObject cat;
    public Vector3 batPosition;
    public Vector3 catPosition;
    public void EnableChasing()
    {
        enabled = true;
    }
    public void DisableChasing()
    {
        enabled = false;
    }
    
    private void Update()
    {
        Transform catTransform = cat.GetComponent<Transform>();
        catPosition = catTransform.position;
        batPosition = gameObject.GetComponent<Transform>().position;
        transform.position = Vector3.MoveTowards(batPosition, catPosition, _speed * Time.deltaTime);
    }
}
