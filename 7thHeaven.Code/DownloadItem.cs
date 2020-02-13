﻿using Iros._7th.Workshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thHeaven.Code
{
    public enum DownloadCategory
    {
        Mod,
        Catalog,
        Image
    }

    public class DownloadItem
    {
        public Guid UniqueId { get; set; }
        public DownloadCategory Category { get; set; }
        public string SaveFilePath { get; set; }
        public Install.InstallProcedure IProc { get; set; }
        public DateTime LastCalc { get; set; }
        public long LastBytes { get; set; }
        public Action PerformCancel { get; set; }
        public Action OnCancel { get; set; }
        public Action OnError { get; set; }
        public string ItemName { get; set; }
        public double PercentComplete { get; set; }
        public string DownloadSpeed { get; set; }
        public string RemainingTime { get; set; }
        public List<string> Links { get; set; }
        public bool HasStarted { get; set; }

        public DownloadItem()
        {
            LastCalc = DateTime.Now;
            UniqueId = Guid.NewGuid();
            PercentComplete = 0;
            Links = new List<string>();
            HasStarted = false;
            RemainingTime = "Unknown";
            DownloadSpeed = "Pending...";
        }
    }
}
