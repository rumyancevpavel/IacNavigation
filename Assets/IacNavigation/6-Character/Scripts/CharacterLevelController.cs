using UnityEngine;
using UnityEngine.Serialization;

namespace IacNavigation.Character.Scripts
{
	public class CharacterLevelController : MonoBehaviour
	{
		#region Editor
		
		[SerializeField] private Camera _rayCastCamera;
		
		[SerializeField] private EllenBasicBehaviour _ellen;
		
		#endregion

		#region Methods

		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				var ray = _rayCastCamera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out RaycastHit hit))
				{
					_ellen.GoTo(hit.point);
				}
			}
		}

		#endregion
	}
}