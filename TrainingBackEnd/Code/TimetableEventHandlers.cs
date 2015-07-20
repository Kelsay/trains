using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Publishing;
using Umbraco.Core.Services;
using Umbraco.Core.Events;
using Umbraco.Core.Models;

namespace Training.Code
{
    public class TimetableEventHandlers : ApplicationEventHandler
    {
        public TimetableEventHandlers()
        {
            ContentService.Published += AddNodesToTimetable;
            ContentService.UnPublished += DeleteNodesFromTimetable;
        }

        void AddNodesToTimetable(IPublishingStrategy sender, PublishEventArgs<IContent> e)
        {
            if (e.PublishedEntities.Any())
            {
                foreach (var entity in e.PublishedEntities)
                {
                    if (entity.ContentType.Alias == "Service")
                    {
                        TimetableHelper.Add(entity.Id);
                    }
                }
            }
        }

        void DeleteNodesFromTimetable(IPublishingStrategy sender, PublishEventArgs<IContent> e)
        {
            if (e.PublishedEntities.Any())
            {
                foreach (var entity in e.PublishedEntities)
                {
                    if (entity.ContentType.Alias == "Service")
                    {
                        TimetableHelper.Delete(entity.Id);
                    }
                }
            }
        }

    }

}