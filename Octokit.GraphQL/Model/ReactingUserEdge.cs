namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a user that's made a reaction.
    /// </summary>
    public class ReactingUserEdge : QueryEntity
    {
        public ReactingUserEdge(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        public string Cursor { get; }

        public User Node => this.CreateProperty(x => x.Node, Octokit.GraphQL.Model.User.Create);

        /// <summary>
        /// The moment when the user made the reaction.
        /// </summary>
        public DateTimeOffset? ReactedAt { get; }

        internal static ReactingUserEdge Create(IQueryProvider provider, Expression expression)
        {
            return new ReactingUserEdge(provider, expression);
        }
    }
}