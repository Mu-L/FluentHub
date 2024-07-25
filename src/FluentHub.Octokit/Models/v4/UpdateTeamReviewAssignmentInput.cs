// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of UpdateTeamReviewAssignment
	/// </summary>
	public class UpdateTeamReviewAssignmentInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The Node ID of the team to update review assignments of
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Turn on or off review assignment
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// The algorithm to use for review assignment
		/// </summary>
		public TeamReviewAssignmentAlgorithm? Algorithm { get; set; }

		/// <summary>
		/// The number of team members to assign
		/// </summary>
		public int? TeamMemberCount { get; set; }

		/// <summary>
		/// Notify the entire team of the PR if it is delegated
		/// </summary>
		public bool? NotifyTeam { get; set; }

		/// <summary>
		/// Remove the team review request when assigning
		/// </summary>
		public bool? RemoveTeamRequest { get; set; }

		/// <summary>
		/// Include the members of any child teams when assigning
		/// </summary>
		public bool? IncludeChildTeamMembers { get; set; }

		/// <summary>
		/// Count any members whose review has already been requested against the required number of members assigned to review
		/// </summary>
		public bool? CountMembersAlreadyRequested { get; set; }

		/// <summary>
		/// An array of team member IDs to exclude
		/// </summary>
		public List<ID> ExcludedTeamMemberIds { get; set; }
	}
}