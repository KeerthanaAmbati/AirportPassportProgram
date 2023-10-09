﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab5_Solution.Model;
public interface IBusinessLogic
{
    AirportAdditionError AddAirport(String id, String city, DateTime dateVisited, int rating);
    AirportDeletionError DeleteAirport(String id);
    AirportEditError EditAirport(String id, String city, DateTime dateVisited, int rating);
    Airport FindAirport(String id);
    String CalculateStatistics();
    ObservableCollection<Airport> GetAirports();
}
