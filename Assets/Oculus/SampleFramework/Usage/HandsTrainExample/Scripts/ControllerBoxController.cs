/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/

using UnityEngine;
using UnityEngine.Assertions;

namespace OculusSampleFramework
{
	public class ControllerBoxController : MonoBehaviour
	{
		[SerializeField] private TrainLocomotive _locomotive = null;
		[SerializeField] private CowController _cowController = null;
		//
		private CowOrBull _cowOrBull = null;
		GameObject myCow;

		private void Awake()
		{
			Assert.IsNotNull(_locomotive);
			Assert.IsNotNull(_cowController);
			//
			// Assert.IsNotNull(_cowOrBull);
			myCow = GameObject.Find("Cow");
		}
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				_locomotive.StartStopStateChanged();
			}
		}

		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				_locomotive.DecreaseSpeedStateChanged();
			}
		}

		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				_locomotive.IncreaseSpeedStateChanged();
			}
		}

		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				_locomotive.SmokeButtonStateChanged();
			}
		}

		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				_locomotive.WhistleButtonStateChanged();
			}
		}

		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				_locomotive.ReverseButtonStateChanged();
			}
		}

		public void SwitchVisualization(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				HandsManager.Instance.SwitchVisualization();
			}
		}

		public void GoMoo(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				_cowController.GoMooCowGo();
			}
		}


		public void SwitchAnimals(InteractableStateArgs obj)
		{
			if(obj.NewInteractableState == InteractableState.ActionState)
			{
				// _cowController.GoMooCowGo();
				myCow.SetActive(false);
				// Debug.Log("Right Button Clicked!");
				// myBull.SetActive(false);
				// _cowOrBull.SwitchAnimals();
			}
		}

		// public void MoveClouds(InteractableStateArgs obj)
		// {
		// 	if (obj.NewInteractableState == InteractableState.ActionState)
		// 	{
		// 		HandsManager.Instance.SwitchVisualization();
		// 	}
		// }

	}
}
