using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project_Tutor.Model {
    public class Course {
        public int Id;
        public string Name;
        public List<int> Attendees;

        public Course(int id, string name, List<int> attendees) {
            Id = id;
            Name = name;
            Attendees = attendees;
        }
    }
}