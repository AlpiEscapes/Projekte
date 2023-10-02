package com.Stevedores.Stevedores.dao;

import com.Stevedores.Stevedores.dto.Order;
import com.Stevedores.Stevedores.repository.OrderRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.UUID;

@Repository
public class OrderDAO {
    @Autowired
    private OrderRepository orderRepository;

    public Order save(Order order){
        return  orderRepository.save(order);
    }

    public Order findByUUID(UUID uuid){
        return orderRepository.findOneByUuid(uuid);
    }

    public List<Order> findAll(){
        return orderRepository.findAll();
    }
}
