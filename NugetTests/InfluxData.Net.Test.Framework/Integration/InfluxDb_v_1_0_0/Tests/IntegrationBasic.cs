﻿using Xunit;

namespace InfluxData.Net.Integration.InfluxDb.Tests
{
    [Collection("InfluxDb v1.0.0 Integration")]
    [Trait("InfluxDb v1.0.0 Integration", "Basic")]
    public class IntegrationBasic_v_1_0_0 : IntegrationBasic
    {
        public IntegrationBasic_v_1_0_0(IntegrationFixture_v_1_0_0 fixture) : base(fixture)
        {
        }
    }
}
