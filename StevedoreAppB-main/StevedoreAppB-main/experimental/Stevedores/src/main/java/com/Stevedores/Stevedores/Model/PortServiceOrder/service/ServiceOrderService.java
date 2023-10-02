package com.Stevedores.Stevedores.Model.PortServiceOrder.service;

import com.Stevedores.Stevedores.Model.PortServiceOrder.implementation.ServiceOrderImpl;
import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortServiceOrder;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

/*
    CRUD operations for port service orders
 */
@Api(value="/api/OrderManager",produces="application/json")
@RestController
@RequestMapping("/api/OrderManager")
public class ServiceOrderService implements IServiceOrderService {

    ServiceOrderImpl serviceOrder = new ServiceOrderImpl();
    @ApiOperation(value="Create new port service order",response=PortServiceOrder.class)
    @RequestMapping(value="/order",method = RequestMethod.POST,produces="application/json")
    @Override
    /*
    Creates a new Port Service order and returns it so that it can be displayed.
    */
    public PortServiceOrder CreateNewServiceOrder(PortServiceOrder order) {
        return serviceOrder.CreateNewServiceOrder(order);
    }

    /*
    Gets a PortServiceOrder by id and returns it
    */
    @ApiOperation(value="Get an existing service order by its uuid",response=PortServiceOrder.class)
    @RequestMapping(value="/order",method = RequestMethod.GET,produces="application/json")
    @Override
    public PortServiceOrder GetServiceOrder(String uuid) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.

    }

    /*
    Deletes a PortServiceOrder by id and returns if it worked
    */
    @ApiOperation(value="Delete an existing service order by its uuid",response=Boolean.class)
    @RequestMapping(value="/order",method = RequestMethod.DELETE,produces="application/json")
    @Override
    public boolean DeletePortServiceOrder(String uuid) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.

    }

    /*
    Deletes a PortServiceOrder by id and returns if it worked
    */
    @ApiOperation(value="Update an existing service order",response=PortServiceOrder.class)
    @RequestMapping(value="/order",method = RequestMethod.PUT,produces="application/json")
    @Override
    public PortServiceOrder UpdateServiceOrder(PortServiceOrder order) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.

    }
}
