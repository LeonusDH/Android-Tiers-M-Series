﻿using RimWorld;
using Verse;

namespace ATReforged
{
    public static class MechFallMoteMaker
    {
        public static void MakeMechFallMote(IntVec3 cell, Map map)
        {
            Mote mote = (Mote)ThingMaker.MakeThing(ThingDefOf.Mote_Bombardment, null);
            mote.exactPosition = cell.ToVector3Shifted();
            mote.Scale = 5f;
            mote.rotationRate = 0f;
            GenSpawn.Spawn(mote, cell, map);
        }

    }
}
