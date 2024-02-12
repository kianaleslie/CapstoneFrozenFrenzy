using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    // Placeholder Script for Prototype Leaderboard
    [SerializeField] private List<TMP_Text> leaderboardTexts;

    private List<LeaderboardEntry> leaderboard = new List<LeaderboardEntry>();

    private void Start()
    {
        AddEntry(120, "Type A", "AAA");
        AddEntry(90, "Type B", "BBB");
        AddEntry(110, "Type C", "CCC");
        UpdateLeaderboardUI();
    }

    private void AddEntry(int time, string snowballType, string name)
    {
        leaderboard.Add(new LeaderboardEntry { Time = time, SnowballType = snowballType, Name = name });
        leaderboard.Sort((x, y) => x.Time.CompareTo(y.Time));

        if (leaderboard.Count > 8)
        {
            leaderboard.RemoveAt(8);
        }
    }

    private void UpdateLeaderboardUI()
    {
        for (int i = 0; i < leaderboard.Count; i++)
        {
            leaderboardTexts[i].text = $"{leaderboard[i].Name}   {leaderboard[i].Time}   {leaderboard[i].SnowballType}";
        }
    }

    private class LeaderboardEntry
    {
        public int Time;
        public string SnowballType;
        public string Name;
    }
}
