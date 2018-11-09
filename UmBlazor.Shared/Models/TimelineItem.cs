using System;
using Umbraco.Headless.Client.Net.Models;

namespace UmBlazor.Shared.Models
{
    public class TimelineItem : ContentBase
    {
        public DateTime Date { get; set;}
        public string Description { get; set; }
    }
}
