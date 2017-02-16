﻿using GitHub.Unity;
using System.Threading.Tasks;

namespace GitHub.Api
{
    interface IPlatform
    {
        Task<IPlatform> Initialize(IProcessManager processManager);
        IGitEnvironment GitEnvironment { get; }
        ICredentialManager CredentialManager { get; }
    }
}