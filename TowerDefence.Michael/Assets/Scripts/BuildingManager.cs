
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {


	
   [SerializeField] private Transform pfWoooHarvester;

	private Camera mainCamera;

	private void Start(0)) {
		mainCamera = Camera.main;
	
	private void Update()
		if(Input.GetMouseButton(0)) {
			Instantiate(pfWoooHarvester, GetMouseWorldPosition(), Quaternion.identity);
		}


	}	
	

	private Vector3 GetMouseWorldPosition() {
		Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
		mouseWorldPosition.z = 0f;
		return mouseWorldPosition;
	}

	
	
}

   

