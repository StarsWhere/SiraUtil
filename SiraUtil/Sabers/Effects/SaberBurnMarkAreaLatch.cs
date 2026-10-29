using HarmonyLib;
using IPA.Utilities;
using SiraUtil.Affinity;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SiraUtil.Sabers.Effects
{
    internal class SaberBurnMarkAreaLatch : IDisposable, IAffinity
    {
        private SaberBurnMarkArea? _saberBurnMarkArea;
        private readonly SiraSaberFactory _siraSaberFactory;
        private readonly SaberModelManager _saberModelManager;
        private readonly Queue<SiraSaber> _earlySabers = new();

        // TODO: These are all readonly fields. Figure out if there's a way to get around that.
        private static readonly FieldAccessor<SaberBurnMarkArea, Saber[]>.Accessor Sabers;
        private static readonly FieldAccessor<SaberBurnMarkArea, Vector3[]>.Accessor PrevBurnMarkPos;
        private static readonly FieldAccessor<SaberBurnMarkArea, bool[]>.Accessor PrevBurnMarkPosValid;
        private static readonly FieldAccessor<SaberBurnMarkArea, LineRenderer[]>.Accessor LineRenderers;

        public SaberBurnMarkAreaLatch(SiraSaberFactory siraSaberFactory, SaberModelManager saberModelManager)
        {
            _siraSaberFactory = siraSaberFactory;
            _saberModelManager = saberModelManager;
            _siraSaberFactory.SaberCreated += SiraSaberFactory_SaberCreated;
            _saberModelManager.ColorUpdated += ColorUpdated;
            _siraSaberFactory.ColorUpdated += ColorUpdated;
        }

        private void SiraSaberFactory_SaberCreated(SiraSaber siraSaber)
        {  }

        private void ColorUpdated(Saber saber, Color color)
        {  }

        public void Dispose()
        {
            _siraSaberFactory.ColorUpdated -= ColorUpdated;
            _saberModelManager.ColorUpdated -= ColorUpdated;
            _siraSaberFactory.SaberCreated -= SiraSaberFactory_SaberCreated;
        }

        private void AddSaber(Saber saber)
        {  }

        private LineRenderer CreateNewLineRenderer(Color initialColor)
        { return null!; }

        internal void BurnAreaStarting(SaberBurnMarkArea __instance)
        {  }
    }
}