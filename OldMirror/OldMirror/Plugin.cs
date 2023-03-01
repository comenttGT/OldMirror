using UnityEngine;
using BepInEx;

namespace OldMirror
{
	[BepInPlugin("comenttGT", "OldMirror", "1.0.0")]
	public class Plugin : BaseUnityPlugin
    {
		public void Start()
        {

			GameObject Mirror = GameObject.Find("Level/lower level/mirror (1)");
			Mirror.SetActive(true);
			GameObject Camera = GameObject.Find("Level/lower level/mirror (1)/Camera");
			Camera.GetComponent<Camera>().allowHDR = false;
			Camera.GetComponent<Camera>().allowMSAA = false;
		}
	}
}
