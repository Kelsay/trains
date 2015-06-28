using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Models
{

    public class TrainBaseModel
    {
        public string Id;
        public string Name;
        public string Thumbnail;
    }
    public class TrainModel : TrainBaseModel
    {
        public string Description;
        public string Manufacturer;
        public IEnumerable<string> Images;

    }
}