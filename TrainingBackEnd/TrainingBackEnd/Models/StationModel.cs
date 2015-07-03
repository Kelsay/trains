using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Models
{
    public class StationModel
    {
        public string Id { get; set; }
        public string Name;
        public string Code;
        public Int16 Latitude;
        public Int16 Longitude;

    }

    public class StationFullModel : StationModel
    {
        //public List<ServiceTimetableModel> Timetable;
    }


}