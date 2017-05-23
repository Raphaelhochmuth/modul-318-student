using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id, DateTime dtetimecal, DateTime dtetimeclock);
        Connections GetConnections(string fromStation, string toStattion, DateTime dtetimecal, DateTime dtetimeclock);
    }
}