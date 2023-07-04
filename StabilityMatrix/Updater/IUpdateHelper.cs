﻿using System;
using System.Threading.Tasks;
using StabilityMatrix.Models.Progress;

namespace StabilityMatrix.Updater;

public interface IUpdateHelper
{
    Task StartCheckingForUpdates();

    Task DownloadUpdate(UpdateInfo updateInfo,
        IProgress<ProgressReport> progress);
}
