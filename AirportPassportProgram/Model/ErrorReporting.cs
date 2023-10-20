﻿using System;
namespace Lab5_Solution.Model;

public enum AirportAdditionError
{
    InvalidIdLength,
    InvalidCityLength,
    InvalidRating,
    InvalidDate,
    DuplicateAirportId,
    DBAdditionError,
    NoError
}

public enum AirportDeletionError
{
    AirportNotFound,
    DBDeletionError,
    NoError
}

public enum AirportEditError
{
    AirportNotFound,
    InvalidFieldError,
    DBEditError,
    NoError
}

public enum FlyWisconsinLevel
{
    Bronze,
    Silver,
    Gold,
    None
}