using System;
using System.Collections.Generic;
using System.Text;

namespace _01042022task1
{
    class MeetingSchedule
    {
        private List<Meeting> _meetings;
        
        public List<Meeting> Meetings
        {
            get => _meetings;
        }
        public MeetingSchedule()
        {
            _meetings = new List<Meeting>();
        }
        public void SetMeeting(string name,DateTime fromDate,DateTime toDate)
        {
            if (fromDate < toDate)
            {
                Meeting meeting = new Meeting();
                meeting.Name = name;
                meeting.FromDate = fromDate;
                meeting.ToDate = toDate;
                if (_meetings.Count == 0)
                {
                    _meetings.Add(meeting);
                }
                else
                {
                    bool HasTrue = false;
                    foreach (var meet in _meetings)
                    {
                        if (fromDate > meet.ToDate || toDate < meet.ToDate)
                        {
                            HasTrue = true;
                        }
                        else
                        {
                            throw new Exception("Bu vaxtda meeting var:");
                        }
                    }
                    if (HasTrue)
                    {
                        _meetings.Add(meeting);
                    }
                }
            }
            else
            {
                throw new Exception("fromDate daxil edin evvela,sonra toDate");
            }
            public int FindMeetingCount(DateTime time)
            {
                if (time==null)
                {
                    throw new Exception("Time null ola bilmez");
                }
                else
                {
                    int count = 0;
                    foreach (Meeting meet in _meetings)
                    {
                        if (time<meet.FromDate)
                        {
                            count++;
                        }
                    }
                    return count;
                }

            }
            public bool IsExistsMeetingByName(string name)
            {
                if (string.IsNullOrWhiteSpace(name)
                {
                    throw new Exception("Null daxil etmek olmaz");
                }
                else
                {
                    foreach  (Meeting meet in _meetings)
                    {
                        if (meet.Name.Contains(name)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }



        }
    }
}
