using System;

namespace practical_3
{
    public class Team : Sponsor
    {
        private string? teamName;

        public string TeamName
        {
            get
            {
                return teamName;
            }
            set
            {
                teamName = value;
            }
        }

        public string PrintInfo()
        {
            return $"{owner} {teamName}";
        }
    }
}