/*
package com.Stevedores.Stevedores.Controller;

import com.Stevedores.Stevedores.Controller.Interfaces.IServiceManager;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@Api(value="/api/ServiceManager",produces="application/json")
@RestController
@RequestMapping("/api/ServiceManager")
public class ServiceManager implements IServiceManager {

    private WasteManager wasteManager;
    private WaterManager waterManager;


    public ServiceManager(WasteManager wasteManager, WaterManager waterManager) {
        this.wasteManager = wasteManager;
        this.waterManager = waterManager;
    }

    @ApiOperation(value="provide water to ship",response= Boolean.class)
    @RequestMapping(value="/ProvisionWaterToShip",method = RequestMethod.POST,produces="application/json")
    @Override
    public boolean ProvisionWaterToShip(int orderId, String shipName, double amount) {
        return waterManager.RequestWater(amount);
    }

    @ApiOperation(value="remove water from ship",response= Boolean.class)
    @RequestMapping(value="/RemoveWasteFromShip",method = RequestMethod.POST,produces="application/json")
    @Override
    public boolean RemoveWasteFromShip(int orderId, String shipName, double amount) {
        return wasteManager.AddWaste(amount);
    }


    */
/*
    Not sure if cargo is our task
    *//*

    @ApiOperation(value="offload cargo from ship",response= Boolean.class)
    @RequestMapping(value="/OffloadCargoFromShip",method = RequestMethod.POST,produces="application/json")
    @Override
    public boolean OffloadCargoFromShip(int orderId, String shipName) {
        return false;
    }

    @ApiOperation(value="onload cargo from ship",response= Boolean.class)
    @RequestMapping(value="/OnloadCargoFromShip",method = RequestMethod.POST,produces="application/json")
    @Override
    public boolean OnloadCargoToShip(int orderId, String shipName) {
        return false;
    }
}
*/
