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
			}
		}

		#endregion
	}
}