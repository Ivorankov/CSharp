using System;
using System.Collections.Generic;


    class Call
    {
        //Fields
        private string phoneNumber;//Problem 8
        private int callDuration;
        private DateTime date;
        private DateTime time;

        private List<Call> callHistory = new List<Call>();

        //Constructors
        public Call(string phoneNumber, int callDuration, DateTime date, DateTime time)
        {
            this.phoneNumber = phoneNumber;
            this.callDuration = callDuration;
            this.date = date;
            this.time = time;
        }

        //Properties
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new ArgumentOutOfRangeException("Number must contain at least 8 digits");
                }
                this.phoneNumber = value;
            }
        }
        public int CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Call duration cannot be less then or equal to 0");
                }
                this.callDuration = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }
    }

