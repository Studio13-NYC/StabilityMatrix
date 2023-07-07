﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StabilityMatrix.Core.Helper.Cache;
using StabilityMatrix.Core.Models;
using StabilityMatrix.Helper;
using StabilityMatrix.Services;

namespace StabilityMatrix.Models.Packages;

public class DankDiffusion : BaseGitPackage
{
    public DankDiffusion(IGithubApiCache githubApi, ISettingsManager settingsManager, IDownloadService downloadService,
        IPrerequisiteHelper prerequisiteHelper) :
        base(githubApi, settingsManager, downloadService, prerequisiteHelper)
    {
    }

    public override string Name => "dank-diffusion";
    public override string DisplayName { get; set; } = "Dank Diffusion";
    public override string Author => "mohnjiles";
    public override string LaunchCommand { get; }
    public override Uri PreviewImageUri { get; }

    public override Task RunPackage(string installedPackagePath, string arguments)
    {
        throw new System.NotImplementedException();
    }

    public override List<LaunchOptionDefinition> LaunchOptions { get; }
    public override Task<string> GetLatestVersion()
    {
        throw new System.NotImplementedException();
    }

    public override Task<IEnumerable<PackageVersion>> GetAllVersions(bool isReleaseMode = true)
    {
        throw new System.NotImplementedException();
    }
}
