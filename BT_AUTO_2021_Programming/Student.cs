﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Student : Person
    {
        string currentStudyYear;
        bool hasScholarship;
        bool hasDormRoom;
        string[] courses;

        public Student(string currentStudyYear, bool hasScholarship, bool hasDormRoom, string name, char sex)
        {
            this.currentStudyYear = currentStudyYear;
            this.hasScholarship = hasScholarship;
            this.hasDormRoom = hasDormRoom;
            this.SetName(name);
            this.SetSex(sex);
            
            
        }

        public Student ()
        {

        }

        public void PrintStudent()
        {
            base.PrintPerson();
            Console.WriteLine("Current study yearis {0} ", currentStudyYear);
            Console.WriteLine("Dormroom status: {0} ", hasDormRoom);
            Console.WriteLine("Scholarships status: {0} ", hasScholarship);
        }

        public void EnrollCourse(string course)
        {
            this.courses.SetValue(course, 0);
        }

            
    }
}
