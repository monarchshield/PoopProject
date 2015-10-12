using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {

    [Range(1,10)]
    public int _NumofFloors;
    public GameObject _BottomfloorMesh;
    public GameObject _MiddlefloorMesh;
    public GameObject _TopfloorMesh;
    public GameObject _EmptyChild;


    public Vector3 _Position;


	// Use this for initialization
	void Awake () 
    {
        _Position = transform.position;

        CreateBuilding();
	}
	
    

    void CreateBuilding()
    {

       float YaxisIncriment = .08f;

       Instantiate(_BottomfloorMesh, _Position, Quaternion.identity);
    

        Instantiate(_BottomfloorMesh, _Position, Quaternion.identity);
         _Position.y += YaxisIncriment;

        for (int i = 0; i < _NumofFloors; i++)
        {
            Instantiate(_MiddlefloorMesh, _Position, Quaternion.identity);
            _Position.y += .05f;
        }

        Instantiate(_TopfloorMesh, _Position, Quaternion.identity);
    }

}
