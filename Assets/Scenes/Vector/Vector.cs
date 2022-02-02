using UnityEngine;

public class Vector : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private bool _distance;
    

    private void Update()
    {
        CheckDistance();

        
            if (_distance)
            {
                Debug.LogError("Distance is too long");
            }
        
    }

    private void CheckDistance()
    {
        var heading = _player.position - transform.position;
        var distance = heading.magnitude;

        //var direction = heading / distance;

        if (distance >= 10f)       
            _distance = true;
        

        Debug.Log(distance);
    }
}
