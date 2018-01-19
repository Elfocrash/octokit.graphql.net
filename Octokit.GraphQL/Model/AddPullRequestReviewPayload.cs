namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of AddPullRequestReview
    /// </summary>
    public class AddPullRequestReviewPayload : QueryEntity
    {
        public AddPullRequestReviewPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The newly created pull request review.
        /// </summary>
        public PullRequestReview PullRequestReview => this.CreateProperty(x => x.PullRequestReview, Octokit.GraphQL.Model.PullRequestReview.Create);

        /// <summary>
        /// The edge from the pull request's review connection.
        /// </summary>
        public PullRequestReviewEdge ReviewEdge => this.CreateProperty(x => x.ReviewEdge, Octokit.GraphQL.Model.PullRequestReviewEdge.Create);

        internal static AddPullRequestReviewPayload Create(IQueryProvider provider, Expression expression)
        {
            return new AddPullRequestReviewPayload(provider, expression);
        }
    }
}