#nullable disable
using HarmonyLib;
using Il2Cpp;

namespace ScavengeTweaks.Patches {

    [HarmonyPatch(typeof(Panel_BreakDown), nameof(Panel_BreakDown.Enable))]
    internal static class Panel_BreakDown_Enable_Patch {

        private static void Postfix(Panel_BreakDown __instance, bool enable) {
            if (!enable || __instance.m_BreakDown == null) return;

            if (__instance.m_BreakDown.gameObject == null) return;
            string rawName = __instance.m_BreakDown.gameObject.name;

            // Strip Unity instance suffixes like " (PLACED)", " 1 (PLACED)", etc.
            int idx = rawName.IndexOf(' ');
            string name = idx > 0 ? rawName.Substring(0, idx) : rawName;

            switch (name) {
                // Wooden crates
                case "OBJ_BoxCrateA_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.crateATime; break;
                case "OBJ_BoxCrateB_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.crateBTime; break;
                case "Obj_CratesA_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.crateSmallTime; break;
                case "Obj_CratesB_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.crateB2Time; break;

                // Cardboard box
                case "OBJ_BoxCardboardA_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.cardboardBoxTime; break;

                // Wood planks pile
                case "OBJ_WoodPlanksPile":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.planksTime; break;

                // Single pallet / board
                case "OBJ_PalletA_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.palletATime; break;

                // Pallet piles
                case "OBJ_PalletPileB_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.palletPileBTime; break;
                case "OBJ_PalletPileC_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.palletPileCTime; break;

                // Wooden shelf
                case "OBJ_WoodShelfA_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.woodShelfTime; break;
                case "OBJ_WoodShelfB_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.woodShelfBTime; break;

                // Table
                case "OBJ_TableSinkA_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.tableTime; break;

                // Chair
                case "Obj_ChairWoodB_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.chairTime; break;

                // Bench
                case "Obj_BenchC_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.benchTime; break;
                case "Obj_BenchD_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.benchSmallTime; break;

                // Workbench
                case "INTERACTIVE_WorkBench":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.workbenchTime; break;

                // Metal shelves
                case "OBJ_MetalShelfA_LOD0":
                case "OBJ_MetalShelfD_LOD0":
                case "OBJ_MetalLockerA_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.metalShelfSTime; break;
                case "OBJ_MetalShelfB_LOD0":
                case "OBJ_MetalShelfC_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.metalShelfLTime; break;

                // Metal counters/tables
                case "OBJ_MetalCounterA_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.metalCounterSTime; break;
                case "OBJ_MetalCounterB_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.metalCounterLTime; break;

                // Broken metal door
                case "OBJ_MetalLockerDoorA1_LOD0":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.metalDoorTime; break;

                // Bed frame
                case "OBJ_WhalingShipBedFrame_Prefab":
                    __instance.m_BreakDown.m_TimeCostHours = Settings.Instance.bedFrameTime; break;
            }
        }
    }
}
