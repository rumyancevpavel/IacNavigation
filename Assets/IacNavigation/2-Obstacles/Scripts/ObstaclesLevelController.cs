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
				var ray = _rayCastCamera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
				{
					var agent = smallInput ? _smallAgent : _bigAgent;
					agent.SetDestination(hit.point);
				}
			}
		}

		#endregion
	}
}