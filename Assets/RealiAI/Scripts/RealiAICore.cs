using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RealiAI
{
    public class RealiAICore : MonoBehaviour
    {
        Time timeNow = new Time(00);
    }

    enum relationType
    {
        empty,
        married,
        lover,
        friend,
        familiar,
        strange,
        child,
        mother,
        father,
        sibling
    }

    enum gender
    {
        none,
        female,
        male
    }

    enum jobType 
    {
        none,
        talk
    }

    [System.Serializable]
    public class Time
    {
        [SerializeField] private int hour = 00;
        [SerializeField] private int minute = 00;
        [SerializeField] private int second = 00;
        private int seconds = 00;
        
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.seconds = (hour * 60 * 60) + (minute * 60) + second;
        }

        public Time(int seconds)
        {
            this.hour = Mathf.FloorToInt(seconds / (60 * 60));
            this.minute = (hour * 60) -  Mathf.FloorToInt(minute / 60);
            this.second = seconds - (hour * 60 * 60) - (minute * 60);
            this.seconds = seconds;
        }

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }
        public int Seconds { get => seconds; set => seconds = value; }
    }

    [System.Serializable]
    public class Schedule
    {
    }
}