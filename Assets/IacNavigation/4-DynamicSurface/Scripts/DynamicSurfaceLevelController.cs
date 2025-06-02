using UnityEngine;
using UnityEngine.AI;

namespace IacNavigation._4_DynamicSurface.Scripts
{
	public class DynamicSurfaceLevelController : MonoBehaviour
	{
		#region Consts

		private const string IS_OPENE_ANIMATION_PARAM_NAME = "is_open";

		#endregion
		
		#region Editor

		[SerializeField] private Camera _rayCastCamera;
		
		[SerializeField] private Animator _doorAnimator;

		[SerializeField] private NavMeshAgent _agent;
		
		#endregion

		#region Methods

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
			}

			if (Input.GetMouseButtonDown(0))
			{
				var ray = _rayCastCamera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
				{
				}
			}
		}

		private void SetDoorOpened(bool isOpen)
		{
			_doorAnimator.SetBool(IS_OPENE_ANIMATION_PARAM_NAME, isOpen);
		}

		#endregion
	}
}