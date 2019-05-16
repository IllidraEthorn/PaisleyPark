using Prism.Events;

namespace PaisleyPark.Common
{
    public class WaymarkEvent : PubSubEvent<RESTWaymark> { }
    public class WaymarkRetrieveEvent : PubSubEvent<RESTWaymark> { }
    public class WaymarkLoadEvent : PubSubEvent<RESTWaymark> { }
}
