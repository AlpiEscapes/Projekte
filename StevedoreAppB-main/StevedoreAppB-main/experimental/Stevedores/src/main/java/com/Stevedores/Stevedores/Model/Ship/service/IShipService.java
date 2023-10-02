package com.Stevedores.Stevedores.Model.Ship.service;

import com.Stevedores.Stevedores.Model.Ship.dto.ShipReply;

public interface IShipService {
    public ShipReply ShipArrived(String uuid);
}
