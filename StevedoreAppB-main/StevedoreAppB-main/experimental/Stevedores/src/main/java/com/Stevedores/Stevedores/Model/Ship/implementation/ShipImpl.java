package com.Stevedores.Stevedores.Model.Ship.implementation;

import com.Stevedores.Stevedores.Model.Ship.dto.ShipReply;
import com.Stevedores.Stevedores.Model.Ship.service.IShipService;

import java.time.LocalDate;

public class ShipImpl implements IShipService {
    @Override
    public ShipReply ShipArrived(String uuid) {
        ShipReply reply = new ShipReply();
        reply.setMessage("Arrival accepted");
        reply.setDate(LocalDate.now());
        reply.setAccepted(true);
        return reply;
    }
}
