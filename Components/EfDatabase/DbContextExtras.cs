// Copyright � 2020 De Staat der Nederlanden, Ministerie van Volksgezondheid, Welzijn en Sport.
// Licensed under the EUROPEAN UNION PUBLIC LICENCE v. 1.2
// SPDX-License-Identifier: EUPL-1.2

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace NL.Rijksoverheid.ExposureNotification.BackEnd.Components.EfDatabase
{
    public static class DbContextExtras
    {
        public static IDbContextTransaction BeginTransaction(this DbContext context)
        {
            if (context.Database.CurrentTransaction != null)
                throw new InvalidOperationException("Database has existing transaction.");

            return context.Database.BeginTransaction();
        }

        public static void SaveAndCommit(this DbContext context)
        {
            if (context.Database.CurrentTransaction == null)
                throw new InvalidOperationException("No current transaction.");

            context.SaveChanges();
            context.Database.CurrentTransaction.Commit();
        }
    }
}