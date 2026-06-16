#nullable disable
using ModSettings;

namespace ScavengeTweaks {

    internal class ScavengeSettings : JsonModSettings {

        [Section("ST_SEC_WOODEN", Localize = true)]

        [Name("ST_CRATE_A", Localize = true)]
        [Description("ST_DESC_CRATE_A", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float crateATime = 1.5f;

        [Name("ST_CRATE_B", Localize = true)]
        [Description("ST_DESC_CRATE_B", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float crateBTime = 1.0f;

        [Name("ST_CRATE_SMALL", Localize = true)]
        [Description("ST_DESC_CRATE_SMALL", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float crateSmallTime = 0.25f;

        [Name("ST_CRATE_B2", Localize = true)]
        [Description("ST_DESC_CRATE_B2", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float crateB2Time = 1.0f;

        [Name("ST_CARDBOARD_BOX", Localize = true)]
        [Description("ST_DESC_CARDBOARD", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float cardboardBoxTime = 0.27f;

        [Name("ST_PLANKS", Localize = true)]
        [Description("ST_DESC_PLANKS", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float planksTime = 1.0f;

        [Name("ST_PALLET_A", Localize = true)]
        [Description("ST_DESC_PALLET_A", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float palletATime = 0.37f;

        [Name("ST_PALLET_PILE_B", Localize = true)]
        [Description("ST_DESC_PALLET_PILE_B", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float palletPileBTime = 1.5f;

        [Name("ST_PALLET_PILE_C", Localize = true)]
        [Description("ST_DESC_PALLET_PILE_C", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float palletPileCTime = 2.0f;

        [Name("ST_WOOD_SHELF", Localize = true)]
        [Description("ST_DESC_WOOD_SHELF", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float woodShelfTime = 1.5f;

        [Name("ST_WOOD_SHELF_B", Localize = true)]
        [Description("ST_DESC_WOOD_SHELF_B", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float woodShelfBTime = 2.0f;

        [Name("ST_LARGE_SHELF", Localize = true)]
        [Description("ST_DESC_LARGE_SHELF", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float largeShelfTime = 2.0f;

        [Name("ST_BEDROOM_SHELF", Localize = true)]
        [Description("ST_DESC_BEDROOM_SHELF", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float bedroomShelfTime = 1.5f;

        [Name("ST_TABLE", Localize = true)]
        [Description("ST_DESC_TABLE", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float tableTime = 1.5f;

        [Name("ST_DINING_TABLE", Localize = true)]
        [Description("ST_DESC_DINING_TABLE", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float diningTableTime = 1.5f;

        [Name("ST_DINING_TABLE_A", Localize = true)]
        [Description("ST_DESC_DINING_TABLE_A", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float diningTableATime = 1.5f;

        [Name("ST_COFFEE_TABLE", Localize = true)]
        [Description("ST_DESC_COFFEE_TABLE", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float coffeeTableTime = 0.63f;

        [Name("ST_END_TABLE", Localize = true)]
        [Description("ST_DESC_END_TABLE", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float endTableTime = 0.63f;

        [Name("ST_END_TABLE_A", Localize = true)]
        [Description("ST_DESC_END_TABLE_A", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float endTableATime = 0.63f;

        [Name("ST_CHAIR", Localize = true)]
        [Description("ST_DESC_CHAIR", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float chairTime = 0.5f;

        [Name("ST_BENCH", Localize = true)]
        [Description("ST_DESC_BENCH", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float benchTime = 1.0f;

        [Name("ST_BENCH_SMALL", Localize = true)]
        [Description("ST_DESC_BENCH_SMALL", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float benchSmallTime = 0.25f;

        [Name("ST_CUSHIONED_BENCH", Localize = true)]
        [Description("ST_DESC_CUSHIONED_BENCH", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float cushionedBenchTime = 2.5f;

        [Name("ST_CUSHIONED_BENCH_A", Localize = true)]
        [Description("ST_DESC_CUSHIONED_BENCH_A", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float cushionedBenchATime = 3.0f;

        [Name("ST_CUSHIONED_CHAIR_A", Localize = true)]
        [Description("ST_DESC_CUSHIONED_CHAIR_A", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float cushionedChairATime = 0.75f;

        [Name("ST_CUSHIONED_CHAIR_B", Localize = true)]
        [Description("ST_DESC_CUSHIONED_CHAIR_B", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float cushionedChairBTime = 0.75f;

        [Name("ST_CUSHIONED_CHAIR_C", Localize = true)]
        [Description("ST_DESC_CUSHIONED_CHAIR_C", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float cushionedChairCTime = 0.63f;

        [Name("ST_WORKBENCH", Localize = true)]
        [Description("ST_DESC_WORKBENCH", Localize = true)]
        [Slider(0.01f, 8f, 100, NumberFormat = "{0:0.00}h")]
        public float workbenchTime = 4.0f;

        [Section("ST_SEC_METAL", Localize = true)]

        [Name("ST_LAMP_FLOOR", Localize = true)]
        [Description("ST_DESC_LAMP_FLOOR", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float lampFloorTime = 0.75f;

        [Name("ST_LAMP_TABLE", Localize = true)]
        [Description("ST_DESC_LAMP_TABLE", Localize = true)]
        [Slider(0.01f, 2f, 100, NumberFormat = "{0:0.00}h")]
        public float lampTableTime = 0.25f;

        [Name("ST_BED_FRAME", Localize = true)]
        [Description("ST_DESC_BED_FRAME", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float bedFrameTime = 3.0f;


        [Name("ST_METAL_SHELF_S", Localize = true)]
        [Description("ST_DESC_METAL_SHELF_S", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float metalShelfSTime = 1.5f;

        [Name("ST_METAL_SHELF_L", Localize = true)]
        [Description("ST_DESC_METAL_SHELF_L", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float metalShelfLTime = 3.0f;

        [Name("ST_METAL_COUNTER_S", Localize = true)]
        [Description("ST_DESC_METAL_COUNTER_S", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float metalCounterSTime = 3.0f;

        [Name("ST_METAL_COUNTER_L", Localize = true)]
        [Description("ST_DESC_METAL_COUNTER_L", Localize = true)]
        [Slider(0.01f, 6f, 100, NumberFormat = "{0:0.00}h")]
        public float metalCounterLTime = 3.0f;

        [Name("ST_METAL_DOOR", Localize = true)]
        [Description("ST_DESC_METAL_DOOR", Localize = true)]
        [Slider(0.01f, 4f, 100, NumberFormat = "{0:0.00}h")]
        public float metalDoorTime = 0.75f;
    }

    internal static class Settings {
        internal static ScavengeSettings Instance;

        internal static void Initialize() {
            Instance = new ScavengeSettings();
            Instance.AddToModSettings("Scavenge Tweaks");
        }
    }
}
