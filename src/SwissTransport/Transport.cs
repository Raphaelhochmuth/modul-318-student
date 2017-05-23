﻿using System.IO;
using System.Net;
using Newtonsoft.Json;
using System;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message);
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id, DateTime dtetimecal, DateTime dtetimeclock)
        {
            DateTime dtdatetime = dtetimecal.Date + dtetimeclock.TimeOfDay;
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id + "&datetime=" + dtdatetime.ToString("dd.MM.yyyy HH:mm"));
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStattion, DateTime dtetimecal, DateTime dtetimeclock)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + dtetimecal.ToString("dd.MM.yyyy") + "&time=" + dtetimeclock.ToString("HH:mm"));
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
