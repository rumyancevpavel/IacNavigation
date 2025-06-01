using UnityEngine;
using UnityEngine.AI;

namespace IacNavigation._3_StairsAndSlopes.Scripts
{
	public class StairsAndSlopesLevelController : MonoBehaviour
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
				if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
				{
					_agent.destination = hit.point;
				}
			}
		}

		#endregion
	}
}