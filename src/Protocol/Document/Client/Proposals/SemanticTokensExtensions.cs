using System;
using System.Threading;
using System.Threading.Tasks;
using OmniSharp.Extensions.LanguageServer.Protocol.Client;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using OmniSharp.Extensions.LanguageServer.Protocol.Models.Proposals;

namespace OmniSharp.Extensions.LanguageServer.Protocol.Document.Client.Proposals
{
    [Obsolete(Constants.Proposal)]
    public static class SemanticTokensExtensions
    {
        public static Task<SemanticTokens> SemanticTokens(this ILanguageClientDocument mediator,
            SemanticTokensParams @params, CancellationToken cancellationToken = default)
        {
            return mediator.SendRequest<SemanticTokensParams, SemanticTokens>(
                DocumentNames.SemanticTokens, @params, cancellationToken);
        }

        public static Task<SemanticTokensOrSemanticTokensEdits> SemanticTokensEdits(this ILanguageClientDocument mediator,
            SemanticTokensEditsParams @params, CancellationToken cancellationToken = default)
        {
            return mediator.SendRequest<SemanticTokensEditsParams, SemanticTokensOrSemanticTokensEdits>(
                DocumentNames.SemanticTokensEdits, @params, cancellationToken);
        }

        public static Task<Container<SemanticTokens>> SemanticTokensRange(this ILanguageClientDocument mediator,
            SemanticTokensRangeParams @params, CancellationToken cancellationToken = default)
        {
            return mediator.SendRequest<SemanticTokensRangeParams, Container<SemanticTokens>>(
                DocumentNames.SemanticTokensRange, @params, cancellationToken);
        }
    }
}
