﻿// Copyright 2020 De Staat der Nederlanden, Ministerie van Volksgezondheid, Welzijn en Sport.
// Licensed under the EUROPEAN UNION PUBLIC LICENCE v. 1.2
// SPDX-License-Identifier: EUPL-1.2

using System;

namespace NL.Rijksoverheid.ExposureNotification.BackEnd.Components.Services
{
    public interface IUtcDateTimeProvider
    {
        DateTime Now();

        DateTime TakeSnapshot();

        DateTime Snapshot { get; }
    }
}