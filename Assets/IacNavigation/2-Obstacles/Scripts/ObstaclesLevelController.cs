using System;
using UnityEngine;
using UnityEngine.AI;

namespace IacNavigation.Obstacles
{
	public class ObstaclesLevelController : MonoBehaviour
	{
		#region Editor

		[SerializeField] private Camera _rayCastCamera;

		[SerializeField] private NavMeshAgent _smallAgent;

		[SerializeField] private NavMeshAgent _bigAgent;
		
		#endregion

		#region Methods

		private void Update()
		{
			var smallInput = Input.GetMouseButtonDown(0);
			var bigInput = Input.GetMouseButtonDown(1);
			if (smallInput || bigInput)
			{
			}
		}

		#endregion
	}
}