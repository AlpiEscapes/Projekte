package com.Stevedores.Stevedores.service;

import com.Stevedores.Stevedores.dao.OrderDAO;
import com.Stevedores.Stevedores.dto.Order;
import com.Stevedores.Stevedores.dto.OrderStatus;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.UUID;

@Service
public class OrderService {

    @Autowired
    private OrderDAO orderDao;

    public Order placeOrder(Order order){
        List<Order> existingOrders = orderDao.findAll();

        for (Order o : existingOrders) {
            if(order.getAllocatedStart().isAfter(o.getAllocatedStart()) && order.getAllocatedStart().isBefore(o.getAllocatedStart())){
                order.setStatus(OrderStatus.DENIED);
                order.setReason("Timeslot not free");
                orderDao.save(order);
                return order;
            }
        }







        return orderDao.save(order);
    }

    public Order findByUUID(UUID uuid){
        return orderDao.findByUUID(uuid);
    }

}
