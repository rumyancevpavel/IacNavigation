using UnityEngine;
using UnityEngine.AI;

namespace IacNavigation.Basics
{
	public class BasicsLevelController : MonoBehaviour
	{
		#region Edirtor

		[SerializeField] private Camera _rayCastCamera;

		[SerializeField] private NavMeshAgent _targetAgent;
		
		#endregion

		#region Methods

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				var ray = _rayCastCamera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray.origin, ray.direction, out var hit))
				{
					_targetAgent.SetDestination(hit.point);
				}
			}
		}

		#endregion
	}
}