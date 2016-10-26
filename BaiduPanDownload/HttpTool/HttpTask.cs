﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiduPanDownload.HttpTool
{
    abstract class HttpTask
    {
        public int ID { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string State { get; protected set; } = "等待中";

        public bool Running { get; protected set; } = false;

        public bool Paste { get; protected set; } = false;

        public bool TaskComplete { get; protected set; } = false;

        public abstract long GetSpeed();

        public abstract void ContinueTask();

        public abstract float GetPercentage();

        public abstract string GetState();

        public abstract new int GetType();

        public abstract void Start();

        public abstract void StopTask();

        public abstract void PasteTask();

        protected void  SetComplete()
        {
            Running = false;
            TaskComplete = true;
        }
    }
}
