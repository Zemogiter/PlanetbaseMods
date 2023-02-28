﻿using HarmonyLib;
using Planetbase;
using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityModManagerNet.UnityModManager;
using System.Reflection;
using PlanetbaseModUtilities;

namespace ColonistReports
{
    public class ColonistReportsMod : ModBase
    {
        public static new void Init(ModEntry modEntry) => InitializeMod(new ColonistReportsMod(), modEntry, "ColonistReports");

        public override void OnInitialized(ModEntry modEntry)
        {
            RegisterStrings();

            WorkloadManager.mInstance = new WorkloadManager();

            Debug.Log("[MOD] Colonist Reports activated");
        }

        private void RegisterStrings()
        {
            StringUtils.RegisterString("reports", "Colonist Reports");
            StringUtils.RegisterString("reports_workload", "Colonist Workload");

            StringUtils.RegisterString("reports_worker_workload", "Worker Workload");
        }

        public override void OnUpdate(ModEntry modEntry, float timeStep)
        {
            WorkloadManager.mInstance.Update(timeStep);
        }

        public override void OnGameStart(GameStateGame gameStateGame)
        {

        }
    }
}
