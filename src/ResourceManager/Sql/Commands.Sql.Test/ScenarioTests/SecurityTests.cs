﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Test;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.ScenarioTest.SqlTests
{
    public class SecurityTests : SqlTestsBase
    {
        protected Microsoft.Azure.Management.Storage.StorageManagementClient GetStorageV2Client()
        {
            var client = TestBase.GetServiceClient<Microsoft.Azure.Management.Storage.StorageManagementClient>(new CSMTestEnvironmentFactory());
            if (HttpMockServer.Mode == HttpRecorderMode.Playback)
            {
                client.LongRunningOperationInitialTimeout = 0;
                client.LongRunningOperationRetryTimeout = 0;
            }
            return client;
        }

        protected override void SetupManagementClients()
        {
            var sqlCSMClient = GetSqlClient(); // to interact with the security endpoints
            var storageClient = GetStorageClient();
            var storageV2Client = GetStorageV2Client();
            var resourcesClient = GetResourcesClient();
            var authorizationClient = GetAuthorizationManagementClient();
            helper.SetupSomeOfManagementClients(sqlCSMClient, storageClient, storageV2Client, resourcesClient, authorizationClient);
        }

        
        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyWithStorage()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyWithStorage");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyWithStorageV2()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyWithStorageV2");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        public void TestServerUpdatePolicyWithStorage()
        {
            RunPowerShellTest("Test-ServerUpdatePolicyWithStorage");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        public void TestDatabaseUpdatePolicyWithEventTypes()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyWithEventTypes");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        public void TestServerUpdatePolicyWithEventTypes()
        {
            RunPowerShellTest("Test-ServerUpdatePolicyWithEventTypes");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDisableDatabaseAuditing()
        {
            RunPowerShellTest("Test-DisableDatabaseAuditing");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDisableServerAuditing()
        {
            RunPowerShellTest("Test-DisableServerAuditing");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseDisableEnableKeepProperties()
        {
            RunPowerShellTest("Test-DatabaseDisableEnableKeepProperties");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerDisableEnableKeepProperties()
        {
            RunPowerShellTest("Test-ServerDisableEnableKeepProperties");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUseServerDefault()
        {
            RunPowerShellTest("Test-UseServerDefault");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailedDatabaseUpdatePolicyWithNoStorage()
        {
            RunPowerShellTest("Test-FailedDatabaseUpdatePolicyWithNoStorage");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailedServerUpdatePolicyWithNoStorage()
        {
            RunPowerShellTest("Test-FailedServerUpdatePolicyWithNoStorage");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailedUseServerDefault()
        {
            RunPowerShellTest("Test-FailedUseServerDefault");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyWithEventTypeShortcuts()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyWithEventTypeShortcuts");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdatePolicyWithEventTypeShortcuts()
        {
            RunPowerShellTest("Test-ServerUpdatePolicyWithEventTypeShortcuts");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseUpdatePolicyKeepPreviousStorage()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyKeepPreviousStorage");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdatePolicyKeepPreviousStorage()
        {
            RunPowerShellTest("Test-ServerUpdatePolicyKeepPreviousStorage");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailWithBadDatabaseIndentity()
        {
            RunPowerShellTest("Test-FailWithBadDatabaseIndentity");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestFailWithBadServerIndentity()
        {
            RunPowerShellTest("Test-FailWithBadServerIndentity");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDatabaseStorageKeyRotation()
        {
            RunPowerShellTest("Test-DatabaseStorageKeyRotation");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerStorageKeyRotation()
        {
            RunPowerShellTest("Test-ServerStorageKeyRotation");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        public void TestServerUpdatePolicyWithRetention()
        {
            RunPowerShellTest("Test-ServerUpdatePolicyWithRetention");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        public void TestDatabaseUpdatePolicyWithRetention()
        {
            RunPowerShellTest("Test-DatabaseUpdatePolicyWithRetention");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        public void TestServerRetentionKeepProperties()
        {
            RunPowerShellTest("Test-ServerRetentionKeepProperties");
        }

        [Fact(Skip = "Skip for the version header upgrade on Storage library.")]
        [Trait(Category.RunType, Category.LiveOnly)]
        public void TestDatabaseRetentionKeepProperties()
        {
            RunPowerShellTest("Test-DatabaseRetentionKeepProperties");
        }
    }
}
