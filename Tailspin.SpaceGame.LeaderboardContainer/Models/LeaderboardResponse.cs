using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace TailSpin.SpaceGame.LeaderboardContainer
{
    public class LeaderboardResponse
    {
        // The game mode selected in the view.
        [JsonPropertyName("selectedMode")]
        public string SelectedMode { get; set; }
        // The game region (map) selected in the view.
        [JsonPropertyName("selectedRegion")]
        public string SelectedRegion { get; set; }
        // The current page to be shown in the view.
        [JsonPropertyName("page")]
        public int Page { get; set; }
        // The number of items to show per page in the view.
        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        // The scores to display in the view.
        [JsonPropertyName("scores")]
        public IEnumerable<ScoreProfile> Scores { get; set; }
        // The total number of results for the selected game mode and region in the view.
        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }
    }

    /// <summary>
    /// Combines a score and a user profile.
    /// </summary>
    public class ScoreProfile
    {
        // The player's score.
        [JsonPropertyName("score")]
        public Score Score { get; set; }
        // The player's profile.
        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }
    }
}