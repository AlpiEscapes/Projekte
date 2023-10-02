package com.Stevedores.Stevedores.Model.PortServiceOrder.implementation;

import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortOrderStatus;
import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortServiceOrder;
import com.Stevedores.Stevedores.Model.PortServiceOrder.service.IServiceOrderService;

public class ServiceOrderImpl implements IServiceOrderService {


    @Override
    public PortServiceOrder CreateNewServiceOrder(PortServiceOrder order) {
        //Check for conditions regarding availability (time, resources, payment here)
        //Then set status
        //Then return
        order.setOrderStatus(PortOrderStatus.PLACED);

        return order;
    }

    @Override
    public PortServiceOrder GetServiceOrder(String uuid) {
        return null;
    }

    @Override
    public boolean DeletePortServiceOrder(String uuid) {
        return false;
    }

    @Override
    public PortServiceOrder UpdateServiceOrder(PortServiceOrder order) {
        return null;
    }
}
