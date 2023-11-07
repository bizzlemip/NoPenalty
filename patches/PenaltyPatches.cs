using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using Unity.Netcode;
using UnityEngine;

namespace PermUnlockables.Patches
{
	[HarmonyPatch]
	class PenaltyPatches
	{
		[HarmonyPatch(typeof(HUDManager), "ApplyPenalty")]
		[HarmonyPrefix]
		public static bool ApplyPenalty()
		{
			return (false);
		}
		[HarmonyPatch(typeof(HUDManager), "Awake")]
		[HarmonyPostfix]
		public static void ResizeLists2(ref HUDManager __instance)
		{
			__instance.statsUIElements.penaltyTotal.transform.parent.parent.gameObject.SetActive(false);
		}
	}
}
