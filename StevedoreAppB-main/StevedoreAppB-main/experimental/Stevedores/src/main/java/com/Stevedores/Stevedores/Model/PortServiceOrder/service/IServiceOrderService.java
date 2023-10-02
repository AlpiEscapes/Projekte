package com.Stevedores.Stevedores.Model.PortServiceOrder.service;


import com.Stevedores.Stevedores.Model.ReplyMessage;
import com.Stevedores.Stevedores.Model.party.dto.Party;
import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortServiceOrder;


public interface IServiceOrderService {
    PortServiceOrder CreateNewServiceOrder(PortServiceOrder order);
    PortServiceOrder GetServiceOrder(String uuid);
    boolean DeletePortServiceOrder(String uuid);
    PortServiceOrder UpdateServiceOrder(PortServiceOrder order);

}
