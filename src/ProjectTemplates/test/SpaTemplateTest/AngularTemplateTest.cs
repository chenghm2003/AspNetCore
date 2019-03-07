// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.E2ETesting;
using ProjectTemplates.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace Templates.Test.SpaTemplateTest
{
    public class AngularTemplateTest : SpaTemplateTestBase
    {
        public AngularTemplateTest(ProjectFactoryFixture projectFactory, BrowserFixture browserFixture, ITestOutputHelper output)
            : base(projectFactory, browserFixture, output) { }

        [Fact]
        public void AngularTemplate_Works()
            => SpaTemplateImpl("angular");

        [Fact]
        public void AngularTemplate_IndividualAuth_Works()
            => SpaTemplateImpl_IndividualAuth("angular");

        [Fact]
        public void AngularTemplate_IndividualAuth_Works_LocalDb()
            => SpaTemplateImpl_IndividualAuth("angular", useLocalDb: true);
    }
}
