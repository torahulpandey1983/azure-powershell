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

namespace Microsoft.Azure.Commands.DataLakeAnalytics.Test.ScenarioTests
{
    using Microsoft.WindowsAzure.Commands.ScenarioTest;
    using Microsoft.Azure.Test;
    using Xunit;

    public class DataLakeAnalyticsTests : DataLakeAnalyticsTestsBase
    {
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDataLakeAnalyticsAccount()
        {
            RunPowerShellTest(
                string.Format(
                    "Test-DataLakeAnalyticsAccount -resourceGroupName {0} -accountName {1} -dataLakeAccountName {2} -secondDataLakeAccountName {3} -blobAccountName {4} -blobAccountKey {5} -location '{6}'",
                    this.resourceGroupName, this.dataLakeAnalyticsAccountName, this.dataLakeStoreAccountName,
                    this.secondDataLakeStoreAccountName, this.azureBlobStoreName, this.azureBlobStoreAccessKey,
                    DataLakeAnalyticsTestsBase.resourceGroupLocation));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestDataLakeAnalyticsJob()
        {
            RunPowerShellTest(string.Format("Test-DataLakeAnalyticsJob -resourceGroupName {0} -accountName {1} -dataLakeAccountName {2} -location '{3}'", this.resourceGroupName, this.dataLakeAnalyticsAccountName, this.dataLakeStoreAccountName, DataLakeAnalyticsTestsBase.resourceGroupLocation));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNegativeDataLakeAnalyticsAccount()
        {
            RunPowerShellTest(string.Format("Test-NegativeDataLakeAnalyticsAccount -resourceGroupName {0} -accountName {1} -dataLakeAccountName {2} -location '{3}'", this.resourceGroupName, this.dataLakeAnalyticsAccountName, this.dataLakeStoreAccountName, DataLakeAnalyticsTestsBase.resourceGroupLocation));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestNegativeDataLakeAnalyticsJob()
        {
            RunPowerShellTest(string.Format("Test-NegativeDataLakeAnalyticsJob -resourceGroupName {0} -accountName {1} -dataLakeAccountName {2} -location '{3}'", this.resourceGroupName, this.dataLakeAnalyticsAccountName, this.dataLakeStoreAccountName, DataLakeAnalyticsTestsBase.resourceGroupLocation));
        }
    }
}
