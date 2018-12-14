using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake.IC04
{
    class Meeting
    {
        private int _startTime;
        private int _endTime;

        public Meeting(int startTime, int endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
        }

        public int StartTime
        {
            get => _startTime;
            set => _startTime = value;
        }

        public int EndTime
        {
            get => _endTime;
            set => _endTime = value;
        }
    }
}
