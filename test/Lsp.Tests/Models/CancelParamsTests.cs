using System;
using FluentAssertions;
using Newtonsoft.Json;
using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using OmniSharp.Extensions.LanguageServer.Protocol.Serialization;
using Xunit;

namespace Lsp.Tests.Models
{
    public class CancelParamsTests
    {
        [Theory, JsonFixture]
        public void SimpleTest(string expected)
        {
            var model = new CancelParams() {
                Id = "123"
            };
            var result = Fixture.SerializeObject(model);

            result.Should().Be(expected);

            var deresult = new OmniSharp.Extensions.LanguageServer.Protocol.Serialization.Serializer(ClientVersion.Lsp3).DeserializeObject<CancelParams>(expected);
            deresult.Should().BeEquivalentTo(model);
        }
    }
}
