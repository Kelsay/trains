using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Training.Models
{

    // Timetable model for the database
    [TableName("Timetable")]
    public class DatabaseTimetableModel
    {
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }
        public int StationId { get; set; }
        public int ServiceId { get; set; } 
        public string Time { get; set; }

    }


    // Timetable model 
    // Data taken form the DataGrid on the Service Document Type

    public class ServiceTimetableModel
    {
        public int Station;
        public string Time;
    }

    // Timetable model - display on station
    public class StationTimetableModel
    {
        public string Time;
        public string Destination;
    }

}