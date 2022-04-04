using System;

namespace _01042022task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            try
            {
                meetingSchedule.SetMeeting("Rektorla gorus ", new DateTime(2022, 04, 1, 13, 00, 00), new DateTime(2022, 04, 01, 15, 10, 00));
                    meetingSchedule.SetMeeting("Dekanla gorus ", new DateTime(2022, 04, 1, 13, 00, 00), new DateTime(2022, 04, 01, 15, 10, 00));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            foreach (Meeting meet in meetingSchedule.Meetings)
            {
                Console.WriteLine(meet.Name);
            }
        }
    }
}
