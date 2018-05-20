﻿using UnityEngine;

namespace Cordonez.Modules.CustomScriptableObjects.Core
{
	public abstract class BaseCustomScriptableObject : ScriptableObject
	{
		[Multiline]
		public string Description = "";

		/// <summary>
		/// Bit mask that controls object destruction, saving and visibility in inspectors.
		/// This is useful to not unload a scriptable object from memory even when it is not referenced.
		/// </summary>
		public HideFlags FlagsOnEnable = HideFlags.None;

		private void OnEnable()
		{
			hideFlags = FlagsOnEnable;
		}
	}
}