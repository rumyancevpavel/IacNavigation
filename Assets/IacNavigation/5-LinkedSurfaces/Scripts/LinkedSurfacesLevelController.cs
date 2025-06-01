using System;
using UnityEngine;
using UnityEngine.AI;

namespace IacNavigation._5_LinkedSurfaces.Scripts
{
	public class LinkedSurfacesLevelController : MonoBehaviour
	{
		#region Editor
		
		[SerializeField] private Camera _rayCastCamera;
		
		[SerializeField] private NavMeshAgent _agent;
		
		#endregion

		#region Methods

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				var ray = _rayCastCamera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out RaycastHit hit))
				{
					//if(CanAgentReactDestination(_agent, hit.point))
					{
						_agent.destination = hit.point;
					}
				}
			}
		}

		private bool CanAgentReactDestination(NavMeshAgent agent, Vector3 destination)
		{
			var path = new NavMeshPath();
			if (agent.CalculatePath(destination, path))
			{
				return path.status == NavMeshPathStatus.PathComplete;
			}
			return false;
		}
		
		#endregion
	}
}