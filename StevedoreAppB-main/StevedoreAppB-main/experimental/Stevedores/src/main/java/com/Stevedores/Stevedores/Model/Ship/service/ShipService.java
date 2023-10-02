package com.Stevedores.Stevedores.Model.Ship.service;

import com.Stevedores.Stevedores.Model.Ship.dto.ShipReply;
import com.Stevedores.Stevedores.Model.Ship.implementation.ShipImpl;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@Api(value="/api",produces="application/json")
@RestController
@RequestMapping("/api")
public class ShipService implements IShipService{

    ShipImpl shipImpl = new ShipImpl();

    @ApiOperation(value="Update the status of a ship to ARRIVED")
    @RequestMapping(value="/shipArrived",method = RequestMethod.POST,produces="application/json")
    @Override
    public ShipReply ShipArrived(String uuid) {
        return shipImpl.ShipArrived(uuid);
    }
}
