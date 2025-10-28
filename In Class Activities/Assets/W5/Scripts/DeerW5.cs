using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    public GameObject _cat;
    public Transform _catTransform;

    private void Update()
    {
        _catTransform = _cat.GetComponent<Transform>();
        gameObject.GetComponent<NavMeshAgent>().SetDestination(_catTransform.position);
    }
}

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

