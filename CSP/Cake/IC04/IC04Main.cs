using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake.IC04
{
    class IC04Main
    {
        public static void Run()
        {
            List<Meeting> meetings = new List<Meeting>
            {
                new Meeting(0, 1),
                new Meeting(3, 5),
                new Meeting(4, 8),
                new Meeting(10, 12),
                new Meeting(9, 10)
            };

            List<Meeting> savedMeeting = MergeRanges(meetings);

            Console.Write("[ ");
            for (int i = 0; i < savedMeeting.Count; i++)
            {
                Console.Write($"Meeting({savedMeeting[i].StartTime}, {savedMeeting[i].EndTime})");
                if (i != savedMeeting.Count - 1)
                    Console.Write(", ");
            }            
            Console.WriteLine(" ]");
        }

        static List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            // Make a copy so we don't destroy the input, and sort by start time
            List<Meeting> sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime))
                .OrderBy(m => m.StartTime).ToList();

            // Initialize mergedMeetings w/ the earliest meeting
            List<Meeting> mergedMeetings = new List<Meeting> { sortedMeetings[0] };

            foreach (Meeting currentMeeting in sortedMeetings)
            {
                Meeting lastMergedMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    // If the current meeting overlaps w/ the last merged meeting, use the
                    // later end time of the two
                    lastMergedMeeting.EndTime = Math.Max(lastMergedMeeting.EndTime, currentMeeting.EndTime);
                }
                else
                {
                    // Add the current meeting since it doesn't overlap
                    mergedMeetings.Add(currentMeeting);
                }
            }

            return mergedMeetings;
        }
    }
}
