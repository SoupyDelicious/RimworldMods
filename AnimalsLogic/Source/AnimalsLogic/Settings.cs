﻿using UnityEngine;
using Verse;

namespace AnimalsLogic
{
    class Settings : ModSettings
    {
        public static bool prevent_eating_stuff = true;
        public static float training_wildeness_effect_to = 0;

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);

            listing_Standard.CheckboxLabeled("Prevent animals from eating random stuff", ref prevent_eating_stuff);

            listing_Standard.Label("Wildeness effect on training");
            training_wildeness_effect_to = 1 - listing_Standard.Slider(1 - training_wildeness_effect_to, 0, 1);

            listing_Standard.End();
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<bool>(ref prevent_eating_stuff, "prevent_eating_stuff", true, false);
            Scribe_Values.Look<float>(ref training_wildeness_effect_to, "training_wildeness_effect_to", 0, false);
        }
    }
}
